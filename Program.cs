/*using System;
using System.Collections.Generic;
using System.Linq;*/

/* ЗАВДАННЯ №1

 class Program
{
    static void Main()
    {
        int N = 10; 
        Random rand = new Random();
        List<int> numbers = new List<int>();

        for (int i = 0; i < N; i++)
        {
            numbers.Add(rand.Next(-5, 6));
        }

        Console.WriteLine("Початкова колекція: " + string.Join(", ", numbers));

        numbers.RemoveAll(x => x % 3 == 0 || x % 5 == 0);

        Console.WriteLine("Колекція після видалення кратних 3 або 5: " + string.Join(", ", numbers));
    }
}*/




/*ЗАВДАННЯ №2
 
 class Program
{
    static void Main()
    {
        int N = 10; 
        int X = 30; 
        Random rand = new Random();
        List<int> numbers = new List<int>();

        // Формуємо колекцію з N випадкових чисел в інтервалі [5; 50]
        for (int i = 0; i < N; i++)
        {
            numbers.Add(rand.Next(5, 51));
        }

        Console.WriteLine("Початкова колекція: " + string.Join(", ", numbers));

        int lastIndex = numbers.FindLastIndex(x => x > X);

        if (lastIndex != -1)
        {
            numbers.Insert(lastIndex, -1);
        }

        Console.WriteLine("Колекція після вставки -1: " + string.Join(", ", numbers));
    }
}*/




/*ЗАВДАННЯ №3 
 
 class Program
{
    static void Main()
    {
        int N = 10; 
        Random rand = new Random();
        List<int> collection1 = new List<int>();
        List<int> collection2 = new List<int>();

        for (int i = 0; i < N; i++)
        {
            collection1.Add(rand.Next(1, 11));
            collection2.Add(rand.Next(1, 11));
        }

        Console.WriteLine("Перша колекція: " + string.Join(", ", collection1));
        Console.WriteLine("Друга колекція: " + string.Join(", ", collection2));

        List<int> resultCollection = new List<int>();
        for (int i = 0; i < N; i++)
        {
            resultCollection.Add(collection1[i] * collection2[i]);
        }

        Console.WriteLine("Третя колекція (добутки): " + string.Join(", ", resultCollection));
    }
}*/






/* ПРИКЛАД 1
Random o = new Random();
List<int> chisla = new List<int>();
for (int i = 0; i < 10; i++)
{
    chisla.Add(o.Next(1, 20));
}
for (int i = 0; i < chisla.Count; i++)
{
    Console.Write("{0} ", chisla[i]);
}*/



/* ПРИКЛАД 2
Random o = new Random();
List<int> chisla = new List<int>();
for (int i = 0; i < 10; i++)
{
    chisla.Add(o.Next(1, 20));
}

int mx = chisla[0];
int nmx = 0;
for (int i = 1; i < chisla.Count; i++)
{
    if (chisla[i] > mx)
    {
        mx = chisla[i];
        nmx = i;
    }
}
Console.WriteLine("\nМаксимальное число: {0}, Индекс: {1}", mx, nmx);*/



/*ПРИКЛАД 3
Random o = new Random();
List<int> chisla = new List<int>();
for (int i = 0; i < 10; i++)
{
    chisla.Add(o.Next(1, 10));
}
for (int i = 0; i < chisla.Count; i++)
{
    Console.Write("{0} ", chisla[i]);
}
Console.WriteLine();
int x = Convert.ToInt32(Console.ReadLine());
chisla.Remove(x);
for (int i = 0; i < chisla.Count; i++)
{
    Console.Write("{0} ", chisla[i]);
}*/



/*ПРИКЛАД 4
Random o = new Random();
List<int> chisla = new List<int>();
for (int i = 0; i < 10; i++)
{
    chisla.Add(o.Next(1, 10));
}

for (int i = 0; i < chisla.Count; i++)
{
    Console.Write("{0} ", chisla[i]);
}

Console.WriteLine();
int x = Convert.ToInt32(Console.ReadLine());
for (int i = chisla.Count - 1; i >= 0; i--)
{
    if (chisla[i] == x)
    {
        chisla.RemoveAt(i);
    }
}
for (int i = 0; i < chisla.Count; i++)
{
    Console.Write("{0} ", chisla[i]);*/




/*ПРИКЛАД 5
Random o = new Random();
List<int> chisla = new List<int>();
for (int i = 0; i < 10; i++)
{
    chisla.Add(o.Next(1, 10));
}
for (int i = 0; i < chisla.Count; i++)
{
    Console.Write("{0} ", chisla[i]);
}

Console.WriteLine();
int k = Convert.ToInt32(Console.ReadLine());
if (k >= 0 && k < chisla.Count)
{
    chisla.RemoveAt(k);
}
else
{
    Console.WriteLine("Индекс вне диапазона.");
}
for (int i = 0; i < chisla.Count; i++)
{
    Console.Write("{0} ", chisla[i]);
}*/




/*ПРИКЛАД 6
Random o = new Random();
List<int> chisla = new List<int>();
for (int i = 0; i < 10; i++)
{
    chisla.Add(o.Next(1, 10));
}

for (int i = 0; i < chisla.Count; i++)
{
    Console.Write("{0} ", chisla[i]);
}

Console.WriteLine();
int x = Convert.ToInt32(Console.ReadLine());
for (int i = chisla.Count - 1; i >= 0; i--)
{
    if (chisla[i] == x)
    {
        chisla.RemoveAt(i);
    }
}
for (int i = 0; i < chisla.Count; i++)
{
    Console.Write("{0} ", chisla[i]);*/




/*ПРИКЛАД 7
Random o = new Random();
List<int> chisla = new List<int>();
for (int i = 0; i < 10; i++)
{
    chisla.Add(o.Next(1, 10));
}
for (int i = 0; i < chisla.Count; i++)
{
    Console.Write("{0} ", chisla[i]);
}
Console.WriteLine();
Console.Write("Введите индекс: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
if (k >= 0 && k <= chisla.Count)
{
    chisla.Insert(k, x);
}
else
{
    Console.WriteLine("Индекс вне диапазона.");
}
for (int i = 0; i < chisla.Count; i++)
{
    Console.Write("{0} ", chisla[i]);
}*/




/*ПРИКЛАД 8
Random o = new Random();
List<int> chisla = new List<int>();
for (int i = 0; i < 10; i++)
{
    chisla.Add(o.Next(1, 10));
}
for (int i = 0; i < chisla.Count; i++)
{
    Console.Write("{0} ", chisla[i]);
}
Console.WriteLine();
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
for (int i = chisla.Count - 1; i >= 0; i--)
{
    if (chisla[i] % 2 == 0)
    {
        chisla.Insert(i + 1, x);
    }
}
for (int i = 0; i < chisla.Count; i++)
{
    Console.Write("{0} ", chisla[i]);
}*/
