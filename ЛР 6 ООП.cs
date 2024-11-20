using System;
using System.Linq;
using System.Threading;

class Program
{
    static void Main()
    {
        int[] numbers = new int[10];
        Random random = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(0, 26);
        }

        Console.WriteLine("Масив чисел: " + string.Join(", ", numbers));

        Thread t0 = new Thread(() =>
        {
            Console.WriteLine("Числа, більші за 10:");
            foreach (var num in numbers)
            {
                if (num > 10)
                {
                    Console.WriteLine(num);
                }
            }
        });

        Thread t1 = new Thread(() =>
        {
            double average = numbers.Average();
            Console.WriteLine($"Середнє арифметичне значення масиву: {average:F2}");
        });

        t0.Start();
        t1.Start();

        t0.Join();
        t1.Join();

        Console.WriteLine("Робота програми завершена.");
    }
}
