using System;
using System.Threading.Tasks;

namespace PhoneProject
{
    // Класс Telephone (телефон)
    class Telephone
    {
        public delegate void PhoneRingHandler();
    public event PhoneRingHandler Event1;
    public void Ring()
    {
        Console.WriteLine("Телефон звонит...");
        Event1?.Invoke();
    }
}

    // Класс Subscriber (абонент)
    class Subscriber
    {
        public delegate void PhoneAnswerHandler();
public event PhoneAnswerHandler Event2;  
public event PhoneAnswerHandler Event3;

private Random random = new Random();
public void OnPhoneRing()
{
    Console.WriteLine("Звонит телефон.");
    bool pickUp = random.Next(2) == 0;

    if (pickUp)
    {
        Event3?.Invoke();
    }
    else
    {
        Event2?.Invoke();
    }
}
    }

    // Класс Answerphone (автоответчик)
    class Answerphone
    {
    public void OnNoAnswer()
    {
        Console.WriteLine("Не снимаю трубку. Автоответчик: введите сообщение:");
        string message = Console.ReadLine();
        Console.WriteLine($"Сообщение записано: {message}");
    }
}

    // Класс Talk (разговор)
    class Talk
    {
    public void OnAnswer()
    {
        Console.WriteLine("Снимаю трубку. Алло?");
    }
}

    // Класс Program (тестирующий)
    class Program
    {
    static void Main(string[] args)
    {
        Telephone phone = new Telephone();
        Subscriber subscriber = new Subscriber();
        Answerphone answerphone = new Answerphone();
        Talk talk = new Talk();

        phone.Event1 += subscriber.OnPhoneRing;
        subscriber.Event2 += answerphone.OnNoAnswer;
        subscriber.Event3 += talk.OnAnswer;

        phone.Ring();
    }
}
}

