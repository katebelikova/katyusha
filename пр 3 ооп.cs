using System;

class TPTriangle
{
    // Поля для зберігання довжин катетів
    private double a;
    private double b;

    // Конструктор без параметрів
    public TPTriangle()
    {
        a = 0;
        b = 0;
    }

    // Конструктор з параметрами
    public TPTriangle(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    // Конструктор копіювання
    public TPTriangle(TPTriangle other)
    {
        this.a = other.a;
        this.b = other.b;
    }

    // Метод введення даних
    public void Input()
    {
        Console.Write("Введіть довжину катета a: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть довжину катета b: ");
        b = Convert.ToDouble(Console.ReadLine());
    }

    // Метод виведення даних
    public void Output()
    {
        Console.WriteLine($"Катети: a = {a}, b = {b}");
    }

    // Метод для обчислення площі
    public double Area()
    {
        return 0.5 * a * b;
    }

    // Метод для обчислення периметру
    public double Perimeter()
    {
        return a + b + Hypotenuse();
    }

    // Метод для визначення гіпотенузи
    public double Hypotenuse()
    {
        return Math.Sqrt(a * a + b * b);
    }

    // Перевантаження оператора порівняння
    public static bool operator ==(TPTriangle t1, TPTriangle t2)
    {
        return t1.a == t2.a && t1.b == t2.b;
    }

    public static bool operator !=(TPTriangle t1, TPTriangle t2)
    {
        return !(t1 == t2);
    }

    // Перевантаження оператора +
    public static TPTriangle operator +(TPTriangle t1, TPTriangle t2)
    {
        return new TPTriangle(t1.a + t2.a, t1.b + t2.b);
    }

    // Перевантаження оператора -
    public static TPTriangle operator -(TPTriangle t1, TPTriangle t2)
    {
        return new TPTriangle(t1.a - t2.a, t1.b - t2.b);
    }

    // Перевантаження оператора *
    public static TPTriangle operator *(TPTriangle t, double scalar)
    {
        return new TPTriangle(t.a * scalar, t.b * scalar);
    }
}

// Програма-клієнт для тестування
class Program
{
    static void Main(string[] args)
    {
        // Створення трикутників
        TPTriangle triangle1 = new TPTriangle(3, 4);
        TPTriangle triangle2 = new TPTriangle();

        // Введення даних для другого трикутника
        triangle2.Input();

        // Виведення даних трикутників
        triangle1.Output();
        triangle2.Output();

        // Обчислення площі і периметру
        Console.WriteLine($"Площа трикутника 1: {triangle1.Area()}");
        Console.WriteLine($"Периметр трикутника 1: {triangle1.Perimeter()}");

        Console.WriteLine($"Площа трикутника 2: {triangle2.Area()}");
        Console.WriteLine($"Периметр трикутника 2: {triangle2.Perimeter()}");

        // Перевірка рівності трикутників
        if (triangle1 == triangle2)
        {
            Console.WriteLine("Трикутники рівні.");
        }
        else
        {
            Console.WriteLine("Трикутники не рівні.");
        }

        // Операції додавання, віднімання, множення
        TPTriangle sum = triangle1 + triangle2;
        TPTriangle difference = triangle1 - triangle2;
        TPTriangle scaled = triangle1 * 2.0;

        // Виведення результатів операцій
        Console.WriteLine("Результат додавання:");
        sum.Output();

        Console.WriteLine("Результат віднімання:");
        difference.Output();

        Console.WriteLine("Результат множення на скаляр:");
        scaled.Output();
    }
}