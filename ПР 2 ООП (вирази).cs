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
