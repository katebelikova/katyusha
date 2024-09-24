/* приклад 1
string s = "Dfg + t5 - r7y; asd* s34; rt";
int t = s.IndexOf(";"); int i, k = 0;
for (i = 0; i <= t; i++)
{
    if (char.IsLetter(s[i])) k++;
}
Console.WriteLine(k); Console.ReadKey();*/

/*приклад 2
string s = "АУАУАПАУК"; int i = 0;
do
{
    string ss = s.Substring(i, 2); if (ss == "АУ")
    {
        s = s.Insert(i, "О"); i = i + 3;
    }
    else
    {
        i++;
    };
} while (i < s.Length - 1);
Console.WriteLine(s); Console.ReadKey();*/

/*приклад 3
string s = "бiологiя алгебра iсторiя географiя геометрiя";
string c = "i"; string[] a;
a = s.Split(' '); int i;
for (i = 0; i < a.Length; i++)
{
    int t = a[i].IndexOf(c); if (t != -1) Console.WriteLine(a[i]);
}
Console.ReadKey();*/

/*приклад 4
string s1 = "бiологiя алгебра iсторiя географiя геометрiя"; string[] a;
a = s1.Split(' '); Array.Reverse(a);
string s2 = string.Join(" ", a); Console.WriteLine(s2);
Console.ReadKey();*/



/*завдання 9*/
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 1:");
        string input = "бабушка дома делает бублики";
        char letter1 = 'а';
        char letter2 = 'б';

        int count1 = 0, count2 = 0;

        foreach (char c in input)
        {
            if (c == letter1)
                count1++;
            if (c == letter2)
                count2++;
        }

        if (count1 > count2)
            Console.WriteLine($"Буква '{letter1}' зустрічається частіше.");
        else if (count2 > count1)
            Console.WriteLine($"Буква '{letter2}' зустрічається частіше.");
        else
            Console.WriteLine("Обидві букви зустрічаються однаково часто.");

        Console.WriteLine();


        Console.WriteLine("Задача 2:");
        string S = "я дома";
        string S1 = "опа";
        string S2 = "ам";

        string result2 = S.Replace(S1, S2 + S1);

        Console.WriteLine(result2);

        Console.WriteLine();


        Console.WriteLine("Задача 3:");
        string sentence = "все дома";
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

        string result3 = textInfo.ToTitleCase(sentence.ToLower());

        Console.WriteLine(result3);

        Console.WriteLine();


        Console.WriteLine("Задача 4:");
        string sentence4 = "мама дома готовит кушати";
        string[] words = sentence4.Split(' ');

        for (int i = 0; i < words.Length - 1; i += 2)
        {
            string temp = words[i];
            words[i] = words[i + 1];
            words[i + 1] = temp;
        }

        string result4 = string.Join(" ", words);

        Console.WriteLine(result4);
    }
}
