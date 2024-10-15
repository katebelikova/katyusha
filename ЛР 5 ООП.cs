/* Приклад 1
using System;

namespace ConsoleApp19
{
    // Інтерфейс, що отримує параметр тип T
    interface Operations<T>
    {
        // Оголошення методів, які використовують тип T
        double Add(T var1, T var2);
        double Sub(T var1, T var2);
    }

    // Клас, що реалізує інтерфейс Operations<T>
    class MyClass<T> : Operations<T>
    {
        // Реалізація методу додавання
        public double Add(T var1, T var2)
        {
            double res = Convert.ToDouble(var1) + Convert.ToDouble(var2);
            return res;
        }

        // Реалізація методу віднімання
        public double Sub(T var1, T var2)
        {
            double res = Convert.ToDouble(var1) - Convert.ToDouble(var2);
            return res;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Демонстрація використання узагальненого інтерфейсу
            // 1. Для типу-заповнювача int
            MyClass<int> mc1 = new MyClass<int>();
            double res1 = mc1.Add(23, 48);
            Console.WriteLine("res1 = {0}", res1);

            // 2. Для типу-заповнювача float
            MyClass<float> mc2 = new MyClass<float>();
            double res2 = mc2.Sub(8.804f, 1.704f);
            Console.WriteLine("res2 = {0:f}", res2);

            Console.ReadKey();
        }
    }
}*/


/* Приклад 2
 using System;

namespace ConsoleApp19
{
    // Інтерфейс Operations, що отримує параметр тип T
    interface Operations<T>
    {
        double Add(T var1, T var2);
        double Sub(T var1, T var2);
    }

    // Клас, що реалізує інтерфейс Operations<T>
    class OperationsClass<T> : Operations<T>
    {
        public double Add(T var1, T var2)
        {
            double res = Convert.ToDouble(var1) + Convert.ToDouble(var2);
            return res;
        }

        public double Sub(T var1, T var2)
        {
            double res = Convert.ToDouble(var1) - Convert.ToDouble(var2);
            return res;
        }
    }

    // Інтерфейс MyInterface, який отримує два параметри типу T1, T2
    interface MyInterface<T1, T2>
    {
        void Print1(T1 var1);
        void Print2(T2 var2);
    }

    // Клас, що реалізує інтерфейс MyInterface<T1, T2>
    class PrintClass<T1, T2> : MyInterface<T1, T2>
    {
        public void Print1(T1 var1)
        {
            Console.WriteLine("var1 = {0}", var1);
        }

        public void Print2(T2 var2)
        {
            Console.WriteLine("var2 = {0}", var2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Демонстрація використання Operations<T>
            Console.WriteLine("=== Демонстрація Operations<T> ===");

            // 1. Для типу-заповнювача int
            OperationsClass<int> op1 = new OperationsClass<int>();
            double addResult1 = op1.Add(23, 48);
            double subResult1 = op1.Sub(23, 48);
            Console.WriteLine("Add result1 = {0}", addResult1);
            Console.WriteLine("Sub result1 = {0}", subResult1);

            // 2. Для типу-заповнювача float
            OperationsClass<float> op2 = new OperationsClass<float>();
            double addResult2 = op2.Add(8.804f, 1.704f);
            double subResult2 = op2.Sub(8.804f, 1.704f);
            Console.WriteLine("Add result2 = {0:f}", addResult2);
            Console.WriteLine("Sub result2 = {0:f}", subResult2);

            Console.WriteLine();

            // Демонстрація використання MyInterface<T1, T2>
            Console.WriteLine("=== Демонстрація MyInterface<T1, T2> ===");

            // 1. Оголосити екземпляр класу з типами-наповнювачами int, string
            PrintClass<int, string> pc1 = new PrintClass<int, string>();
            pc1.Print1(233);
            pc1.Print2("Hello world!");

            // 2. Оголосити екземпляр класу з типами-наповнювачами double, char
            PrintClass<double, char> pc2 = new PrintClass<double, char>();
            pc2.Print1(8.77);
            pc2.Print2('z');

            // 3. Реалізація типів long, long
            PrintClass<long, long> pc3 = new PrintClass<long, long>();
            pc3.Print1(32323L);
            pc3.Print2(30000L);

            Console.ReadKey();
        }
    }
}*/




/*Приклад 4
 using System;

namespace ConsoleApp19
{
    // Інтерфейс Operations, що отримує параметр тип T
    interface Operations<T>
    {
        double Add(T var1, T var2);
        double Sub(T var1, T var2);
    }

    // Клас, що реалізує інтерфейс Operations<T>
    class OperationsClass<T> : Operations<T> where T : IConvertible
    {
        public double Add(T var1, T var2)
        {
            double res = Convert.ToDouble(var1) + Convert.ToDouble(var2);
            return res;
        }

        public double Sub(T var1, T var2)
        {
            double res = Convert.ToDouble(var1) - Convert.ToDouble(var2);
            return res;
        }
    }

    // Інтерфейс MyInterface, який отримує два параметри типу T1, T2
    interface MyInterface<T1, T2>
    {
        void Print1(T1 var1);
        void Print2(T2 var2);
    }

    // Клас, що реалізує інтерфейс MyInterface<T1, T2>
    class PrintClass<T1, T2> : MyInterface<T1, T2>
    {
        public void Print1(T1 var1)
        {
            Console.WriteLine("var1 = {0}", var1);
        }

        public void Print2(T2 var2)
        {
            Console.WriteLine("var2 = {0}", var2);
        }
    }

    // Клас, у якому оголошується узагальнений метод Print
    class Info
    {
        // Узагальнений метод, який отримує параметр тип TT та int
        public void Print<TT>(TT param1, int param2)
        {
            Console.WriteLine("param1 = {0}", param1);
            Console.WriteLine("param2 = {0}", param2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Демонстрація Operations<T> ===");

            // 1. Демонстрація Operations<T> для типу int
            OperationsClass<int> op1 = new OperationsClass<int>();
            double addResult1 = op1.Add(23, 48);
            double subResult1 = op1.Sub(23, 48);
            Console.WriteLine("Add result1 = {0}", addResult1);
            Console.WriteLine("Sub result1 = {0}", subResult1);

            // 2. Демонстрація Operations<T> для типу float
            OperationsClass<float> op2 = new OperationsClass<float>();
            double addResult2 = op2.Add(8.804f, 1.704f);
            double subResult2 = op2.Sub(8.804f, 1.704f);
            Console.WriteLine("Add result2 = {0:f}", addResult2);
            Console.WriteLine("Sub result2 = {0:f}", subResult2);

            Console.WriteLine();

            Console.WriteLine("=== Демонстрація MyInterface<T1, T2> ===");

            // 1. Оголошення екземпляра PrintClass з типами int, string
            PrintClass<int, string> pc1 = new PrintClass<int, string>();
            pc1.Print1(233);
            pc1.Print2("Hello world!");

            // 2. Оголошення екземпляра PrintClass з типами double, char
            PrintClass<double, char> pc2 = new PrintClass<double, char>();
            pc2.Print1(8.77);
            pc2.Print2('z');

            // 3. Оголошення екземпляра PrintClass з типами long, long
            PrintClass<long, long> pc3 = new PrintClass<long, long>();
            pc3.Print1(32323L);
            pc3.Print2(30000L);

            Console.WriteLine();

            Console.WriteLine("=== Демонстрація класу Info з узагальненим методом Print<TT> ===");

            // Примірник класу Info
            Info info = new Info();

            // 1. Виклик без явно вказаного параметра типу
            // 1.1. Виклик із параметром типу string
            info.Print("String", 23);

            // 1.2. Виклик із параметром типу char
            info.Print('F', 330);

            // 2. Виклик із явно вказаним параметром типу
            // 2.1. Виклик із явно зазначеним типом double
            info.Print<double>(2.88, 33);

            // 2.2. Виклик з явно вказаним типом string
            info.Print<string>("String", 23);

            Console.ReadKey();
        }
    }
}*/



/* Приклаж 5
 using System;

namespace ConsoleApp19
{
    // Неузагальнений клас, що містить узагальнений метод Print()
    class PrintInfo
    {
        // Узагальнений метод Print<T>()
        public void Print<T>(T value)
        {
            Type tp = typeof(T);
            Console.WriteLine("Тип: {0}, value = {1}", tp.Name, value);
            Console.WriteLine(new string('-', 30)); // Роздільник для кращої читабельності
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Демонстрація використання узагальненого методу Print<T>()
            PrintInfo pi = new PrintInfo();
            pi.Print<double>(25.88);
            pi.Print<int>(1232);
            pi.Print<char>('c');
            pi.Print<bool>(false);
            pi.Print<string>("BestProg");
            Console.ReadKey();
        }
    }
}*/



/* Приклад 5
 using System;

namespace ConsoleApp19
{
    /// <summary>
    /// Інтерфейс для виконання арифметичних операцій над типом T.
    /// </summary>
    interface Operations<T>
    {
        double Add(T var1, T var2);
        double Sub(T var1, T var2);
    }

    /// <summary>
    /// Клас, що реалізує інтерфейс Operations<T>.
    /// </summary>
    class OperationsClass<T> : Operations<T> where T : IConvertible
    {
        /// <summary>
        /// Метод для додавання двох значень типу T.
        /// </summary>
        public double Add(T var1, T var2)
        {
            try
            {
                double res = Convert.ToDouble(var1) + Convert.ToDouble(var2);
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при додаванні: {ex.Message}");
                return 0;
            }
        }

        /// <summary>
        /// Метод для віднімання двох значень типу T.
        /// </summary>
        public double Sub(T var1, T var2)
        {
            try
            {
                double res = Convert.ToDouble(var1) - Convert.ToDouble(var2);
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при відніманні: {ex.Message}");
                return 0;
            }
        }
    }

    /// <summary>
    /// Інтерфейс для друку двох параметрів різних типів.
    /// </summary>
    interface MyInterface<T1, T2>
    {
        void Print1(T1 var1);
        void Print2(T2 var2);
    }

    /// <summary>
    /// Клас, що реалізує інтерфейс MyInterface<T1, T2>.
    /// </summary>
    class PrintClass<T1, T2> : MyInterface<T1, T2>
    {
        /// <summary>
        /// Метод для друку першого параметра.
        /// </summary>
        public void Print1(T1 var1)
        {
            Console.WriteLine("var1 = {0}", var1);
        }

        /// <summary>
        /// Метод для друку другого параметра.
        /// </summary>
        public void Print2(T2 var2)
        {
            Console.WriteLine("var2 = {0}", var2);
        }
    }

    /// <summary>
    /// Неузагальнений клас, що містить узагальнений метод Print().
    /// </summary>
    class Info
    {
        /// <summary>
        /// Узагальнений метод, який отримує параметр типу TT та ціле число.
        /// </summary>
        public void Print<TT>(TT param1, int param2)
        {
            Type tp = typeof(TT);
            Console.WriteLine("Тип: {0}, value1 = {1}", tp.Name, param1);
            Console.WriteLine("Тип: Int32, value2 = {0}", param2);
            Console.WriteLine(new string('-', 40));
        }
    }

    /// <summary>
    /// Неузагальнений інтерфейс, що містить узагальнений метод GetInfo.
    /// </summary>
    interface IInfo
    {
        /// <summary>
        /// Метод, який отримує два параметри типу T1 та T2 і повертає рядок з інформацією.
        /// </summary>
        string GetInfo<T1, T2>(T1 value1, T2 value2);
    }

    /// <summary>
    /// Неузагальнений клас, що реалізує інтерфейс IInfo.
    /// </summary>
    class CInfo : IInfo
    {
        /// <summary>
        /// Узагальнений метод GetInfo<T1, T2>().
        /// Метод повертає інформаційний рядок про типи T1, T2 та їхні значення.
        /// </summary>
        public string GetInfo<T1, T2>(T1 value1, T2 value2)
        {
            Type tp1 = typeof(T1);
            Type tp2 = typeof(T2);
            return $"Type1: {tp1.FullName}, Value1: {value1}. Type2: {tp2.FullName}, Value2: {value2}.";
        }
    }

    /// <summary>
    /// Основний клас програми з методом Main.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Демонстрація Operations<T> ===\n");

            // 1. Демонстрація Operations<T> для типу int
            OperationsClass<int> op1 = new OperationsClass<int>();
            double addResult1 = op1.Add(23, 48);
            double subResult1 = op1.Sub(23, 48);
            Console.WriteLine("Add result1 = {0}", addResult1);
            Console.WriteLine("Sub result1 = {0}", subResult1);

            // 2. Демонстрація Operations<T> для типу float
            OperationsClass<float> op2 = new OperationsClass<float>();
            double addResult2 = op2.Add(8.804f, 1.704f);
            double subResult2 = op2.Sub(8.804f, 1.704f);
            Console.WriteLine("Add result2 = {0:f}", addResult2);
            Console.WriteLine("Sub result2 = {0:f}", subResult2);

            Console.WriteLine("\n=== Демонстрація MyInterface<T1, T2> ===\n");

            // 1. Оголошення екземпляра PrintClass з типами int, string
            PrintClass<int, string> pc1 = new PrintClass<int, string>();
            pc1.Print1(233);
            pc1.Print2("Hello world!");

            // 2. Оголошення екземпляра PrintClass з типами double, char
            PrintClass<double, char> pc2 = new PrintClass<double, char>();
            pc2.Print1(8.77);
            pc2.Print2('z');

            // 3. Оголошення екземпляра PrintClass з типами long, long
            PrintClass<long, long> pc3 = new PrintClass<long, long>();
            pc3.Print1(32323L);
            pc3.Print2(30000L);

            Console.WriteLine("\n=== Демонстрація класу Info з узагальненим методом Print<T> ===\n");

            // Примірник класу Info
            Info info = new Info();

            // 1. Виклик без явно вказаного параметра типу
            // 1.1. Виклик із параметром типу string
            info.Print("BestProg", 23);

            // 1.2. Виклик із параметром типу char
            info.Print('F', 330);

            // 2. Виклик із явно вказаним параметром типу
            // 2.1. Виклик із явно зазначеним типом double
            info.Print<double>(2.88, 33);

            // 2.2. Виклик з явно вказаним типом string
            info.Print<string>("BestProg", 23);

            Console.WriteLine("\n=== Демонстрація IInfo та CInfo ===\n");

            // Створити екземпляр класу CInfo
            IInfo info1 = new CInfo();

            // Викликати метод GetInfo<T1, T2>() для різних типів-заповнювачів
            // <int, double>
            string str = info1.GetInfo<int, double>(23, 8.883);
            Console.WriteLine(str);

            // <char, float>
            str = info1.GetInfo<char, float>('a', 23.55f);
            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}*/


/* ЗАВДАННЯ 5
 using System;

public class TPTriangle
{
    private double _катетА;
    private double _катетБ;

    public double КатетА
    {
        get { return _катетА; }
        set { _катетА = value > 0 ? value : 0; }
    }

    public double КатетБ
    {
        get { return _катетБ; }
        set { _катетБ = value > 0 ? value : 0; }
    }

    public TPTriangle()
    {
        _катетА = 1;
        _катетБ = 1;
    }

    public TPTriangle(double катетА, double катетБ)
    {
        КатетА = катетА;
        КатетБ = катетБ;
    }

    public TPTriangle(TPTriangle трикутник)
    {
        _катетА = трикутник._катетА;
        _катетБ = трикутник._катетБ;
    }

    public double Площа()
    {
        return (КатетА * КатетБ) / 2;
    }

    public double Периметр()
    {
        return КатетА + КатетБ + Math.Sqrt(КатетА * КатетА + КатетБ * КатетБ);
    }

    public bool Порівняти(TPTriangle інший)
    {
        return Площа() > інший.Площа();
    }

    public static TPTriangle operator +(TPTriangle перший, TPTriangle другий)
    {
        return new TPTriangle(перший.КатетА + другий.КатетА, перший.КатетБ + другий.КатетБ);
    }

    public static TPTriangle operator -(TPTriangle перший, TPTriangle другий)
    {
        return new TPTriangle(перший.КатетА - другий.КатетА, перший.КатетБ - другий.КатетБ);
    }

    public static TPTriangle operator *(TPTriangle трикутник, double множник)
    {
        return new TPTriangle(трикутник.КатетА * множник, трикутник.КатетБ * множник);
    }

    public override string ToString()
    {
        return $"Трикутник [Катет А: {КатетА}, Катет Б: {КатетБ}, Площа: {Площа()}, Периметр: {Периметр()}]";
    }
}

class Програма
{
    static void Main()
    {
        Console.Write("Введіть довжину катета А: ");
        double катетА = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть довжину катета Б: ");
        double катетБ = Convert.ToDouble(Console.ReadLine());

        var трикутник1 = new TPTriangle(катетА, катетБ);
        Console.WriteLine(трикутник1);

        var трикутник2 = new TPTriangle(3, 4);
        Console.WriteLine(трикутник2);

        var трикутник3 = new TPTriangle(трикутник2);
        Console.WriteLine(трикутник3);

        var трикутник4 = трикутник2 + трикутник3;
        Console.WriteLine(трикутник4);

        var трикутник5 = трикутник2 - трикутник3;
        Console.WriteLine(трикутник5);

        var трикутник6 = трикутник2 * 1.5;
        Console.WriteLine(трикутник6);

        Console.WriteLine($"Чи трикутник6 більший за трикутник2? {трикутник6.Порівняти(трикутник2)}");
    }
}*/
