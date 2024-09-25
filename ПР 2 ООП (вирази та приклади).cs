using System;
using System.Text.RegularExpressions;

/*ЗАВДАННЯ №1
 class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть логін:");
        string login = Console.ReadLine();

        string pattern = @"^[a-zA-Z][a-zA-Z0-9]{1,9}$";

        if (Regex.IsMatch(login, pattern))
        {
            Console.WriteLine("Логін коректний.");
        }
        else
        {
            Console.WriteLine("Логін некоректний. Він має містити від 2 до 10 символів, починатися з літери та містити тільки літери і цифри.");
        }
    }
}*/


/*ЗАВДАННЯ №2
 class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть рядок:");
        string input = Console.ReadLine();

        string result = ReplaceWordForms(input);

        Console.WriteLine("Результат заміни:");
        Console.WriteLine(result);
    }

    static string ReplaceWordForms(string input)
    {
        string pattern = @"\b(сонечко|сонечка|сонечку|сонечком|сонечкові|сонечок)\b";

        string replacement = "луна";

        string result = Regex.Replace(input, pattern, replacement, RegexOptions.IgnoreCase);

        return result;
    }
}*/

/*ПРИКЛАД 1
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string data1 = "Петро, Андрій, Микола";
        string data2 = "Петро, Андрій, Олександр";
        Regex myReg = new Regex("Микола"); // Створення регулярного виразу

        Console.WriteLine(myReg.IsMatch(data1)); // True
        Console.WriteLine(myReg.IsMatch(data2)); // False
    }
}*/
/* ПРИКЛАД №2
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string data1 = "Петро, Андрій, Микола";
        Regex myReg = new Regex("Микола");
        Match match = myReg.Match(data1);

        Console.WriteLine(match.Value);
        Console.WriteLine(match.Index);
    }
}*/

/* ПРИКЛАД 3
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string data1 = "Петро, Микола, Андрій, Микола";
        Regex myReg = new Regex("Микола");
        MatchCollection matches = myReg.Matches(data1);
        Console.WriteLine(matches.Count);
        foreach (Match m in matches)
            Console.WriteLine(m.Value);
    }
}*/

/* ПРИКЛАД 4
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string data1 = "Петро, Микола, Андрій, Микола";
        Regex myReg = new Regex("Микола");
        data1 = myReg.Replace(data1, "Максим");
        Console.WriteLine(data1);
    }
}*/

/* ПРИКЛАД 6
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string data1 = "Петро, Микола, Андрій, Микола";
        Regex myReg = new Regex(",\\s*");  
        string[] names = myReg.Split(data1);

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}*/


/*ПРИКЛАД 6
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Regex myReg = new Regex(@"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$");
        Console.WriteLine(myReg.IsMatch("email@email.com")); // True
        Console.WriteLine(myReg.IsMatch("email@email")); // False
        Console.WriteLine(myReg.IsMatch("@email.com")); // False
    }
}*/


/* ПРИКЛАД 7
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string data = "nikolay, sergey, oleg";
        Regex myRegIgnoreCase = new Regex("Sergey", RegexOptions.IgnoreCase);
        Regex myReg = new Regex("Sergey");

        Console.WriteLine(myRegIgnoreCase.IsMatch(data)); // True
        Console.WriteLine(myReg.IsMatch(data)); // False
    }
}*/


/*ПРИКЛАД 8
using System;
using System.Text.RegularExpressions;

class Program
{
    static string GetDomain(string url)
    {
        Regex re = new Regex("https://", RegexOptions.IgnoreCase);
        url = re.Replace(url, ""); // Видаляємо частину https://
        Regex reWww = new Regex(@"www\.", RegexOptions.IgnoreCase);
        url = reWww.Replace(url, ""); // Видаляємо частину www.
        int end = url.IndexOf("/");

        if (end != -1)
            url = url.Substring(0, end);
        return url;
    }

    static void Main(string[] args)
    {
        string url1 = "https://krypton.com.ua/tutorial/csharp/";
        string url2 = "https://krypton.com.ua/tutorial/ci-10-net-6/";
        Console.WriteLine(GetDomain(url1)); // krypton.com.ua
        Console.WriteLine(GetDomain(url2)); // krypton.com.ua
    }
}*/
