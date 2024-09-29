/*ПРИКЛАД 1
 namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            Console.WriteLine("\n\n Одновимірний масив iArray");
            int[] iArray = new int[10];
            for (j = 0; j < 10; j++)
                iArray[j] = j * j;
            // Присвоєння значень елементів у циклі
            for (j = 0; j < 10; j++)
                // Виведення елементів
                Console.WriteLine("\n" + j + " " + iArray[j]);

            Console.WriteLine("\n Одновимірний масив chArray з ініціалізацією");
            char[] chArray = { 'a', 'b', 'c', 'd' };
            // Оголошення з ініціалізацією
            j = -1;
            do
            {
                j++;
                Console.WriteLine("\n" + j + " " + chArray[j]);
            }
            while (chArray[j] != 'd');
            // Виведення елементів масиву
            Console.WriteLine();
            Console.Write("\n Значення присвоєно ");
            Console.WriteLine("Не всі елементи масиву iiArray \n");
            int[] iiArray = new int[10];
            for (j = 0; j < 6; j++)
                iiArray[j] = j * j;
            iiArray[9] = 81;
            foreach (int jj in iiArray)
            {
                Console.Write(" " + jj);
            }
            Console.WriteLine("\n\n");
            Console.Write(" ");
            Console.ReadKey();
        }
    }
}*/




/*ПРИКЛАД2 
 using System;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            // Початкове значення
            string strValue;
            int[] iArray = new int[10];
            for (j = 0; j < 10; j++)
            {
                strValue = Console.ReadLine();
                // Введення та присвоєння значень
                iArray[j] = Convert.ToInt32(strValue);
            }
            for (j = 0; j < 10; j++)
                // Виведення елементів
                Console.WriteLine("\n" + j + " " + iArray[j]);

            Console.ReadKey();
        }
    }
}*/



/*ПРИКЛАД 3
 using System;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, num1, num2;
            string str;
            double db1, db2;
            Random rnd = new Random();

            int[] iArray1 = new int[10];
            int[] iArray2 = new int[10];
            double[] dArray1 = new double[10];
            double[] dArray2 = new double[10];

            // Заповнення масивів int
            for (j = 0; j < 10; j++)
            {
                iArray1[j] = rnd.Next(1, 101);
                iArray2[j] = 50 - rnd.Next(1, 101);
            }

            // Заповнення масивів double
            for (j = 0; j < 10; j++)
            {
                num1 = rnd.Next(1, 101);
                db1 = Convert.ToDouble(num1);
                dArray1[j] = db1 + Convert.ToDouble(rnd.Next(1, 101)) / 100;

                num2 = 50 - rnd.Next(1, 101);
                db2 = Convert.ToDouble(num2);
                dArray2[j] = db2 - Convert.ToDouble(rnd.Next(1, 101)) / 100;
            }

            // Виведення масивів
            Console.WriteLine("\n-----------------------------------------------");
            Console.WriteLine("\n Масиви типу int   Масиви типу double");
            Console.WriteLine("\n-----------------------------------------------");

            for (j = 0; j < 10; j++)
            {
                str = string.Format("\n {0, 4:D} {1, 6:D} {2, 6:D} {3, 8:D} {4, 8:F2} {5, 8:F2}",
                    j, iArray1[j], iArray2[j], j, dArray1[j], dArray2[j]);
                Console.WriteLine(str);
                Console.WriteLine("\n-----------------------------------------------");
            }

            Console.ReadKey();
        }
    }
}*/




/* ПРИКЛАД 4
 using System;
using System.IO;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            string strValue;
            int[] iArray1 = new int[10];
            int[] iArray2 = new int[10];

            // Corrected file paths (use double backslashes in file paths)
            StreamReader sRead = new StreamReader("d:\\dat.txt");
            StreamWriter sWrite = new StreamWriter("d:\\res.txt");

            // Reading data from the file and processing
            for (j = 0; j < 10; j++)
            {
                strValue = sRead.ReadLine();
                iArray1[j] = Convert.ToInt32(strValue);
                iArray2[j] = 10 * iArray1[j];

                // Format and display the output
                strValue = string.Format("\n {0, 4:D} {1, 6:D} {2, 6:D}", j, iArray1[j], iArray2[j]);
                Console.WriteLine(strValue);
                Console.WriteLine();

                // Write the second array to the output file
                sWrite.WriteLine(iArray2[j]);
            }

            // Closing file streams
            sRead.Close();
            sWrite.Close();

            // Waiting for a key press to exit
            Console.ReadKey();
        }
    }
}*/



/*ПРИКЛАД 5
using System;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, num;
            string str;
            string str1 = "Сума", str2 = "Сума";
            string str3 = "СрАрф", str4 = "СрАрф";
            double db1, db2;
            double sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            Random rnd = new Random();
            int[] iArray1 = new int[15];
            int[] iArray2 = new int[15];
            double[] dArray1 = new double[15];
            double[] dArray2 = new double[15];

            // Filling the integer arrays and calculating sums
            for (j = 0; j < 15; j++)
            {
                iArray1[j] = rnd.Next(1, 101);
                iArray2[j] = 50 - rnd.Next(1, 101);
                sum1 += iArray1[j];
                sum2 += iArray2[j];
            }

            // Filling the double arrays and calculating sums
            for (j = 0; j < 15; j++)
            {
                num = rnd.Next(1, 101);
                db1 = Convert.ToDouble(num);
                dArray1[j] = db1 + Convert.ToDouble(rnd.Next(1, 101)) / 100;
                num = 50 - rnd.Next(1, 101);
                db2 = Convert.ToDouble(num);
                dArray2[j] = db2 - Convert.ToDouble(rnd.Next(1, 101)) / 100;
                sum3 += dArray1[j];
                sum4 += dArray2[j]; // Fixed space issue here
            }

            // Output section
            Console.WriteLine("\n-----------------------------------------------");
            Console.WriteLine("\n Масиви типу int   Масиви типу double");
            Console.WriteLine("\n-----------------------------------------------");
            for (j = 0; j < 15; j++)
            {
                str = string.Format("\n {0,10:D} {1,10:D} {2,10:D} {3,10:D} {4,10:F2} {5,10:F2}",
                    j, iArray1[j], iArray2[j], j, dArray1[j], dArray2[j]);
                Console.WriteLine(str);
            }

            Console.WriteLine("\n---------------------------------------------------");
            Console.WriteLine("\n {0} {1,10:F2} {2} {3,10:F2} {4,10:F2}", str1, sum1, str2, sum3, sum4);
            Console.WriteLine("\n {0} {1,10:F2} {2} {3,10:F2} {4,10:F2}", str3, sum1 / 15, str4, sum3 / 15, sum4 / 15);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}*/




/* ПРИКЛАД 6
 using System;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, num, sum = 0;
            Random rnd = new Random();
            int[] iArray = new int[10];

            // Filling the array with random numbers
            for (j = 0; j < 10; j++)
            {
                iArray[j] = rnd.Next(1, 101);
            }

            // Calculating the sum of even elements
            for (j = 0; j < 10; j++)
            {
                num = Convert.ToInt32(iArray[j] % 2);
                if (num == 0) sum += iArray[j];
            }

            // Outputting the array elements
            foreach (int jj in iArray)
            {
                Console.Write(" " + jj);
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("Сума парних елементів = " + sum);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}*/



/* ПРИКЛАД 7
 using System;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, jnum = 0;
            Random rnd = new Random();
            int[] iArray = new int[20];

            // Filling the array with random numbers
            for (j = 0; j < 20; j++)
            {
                iArray[j] = 50 - rnd.Next(1, 101);
            }

            // Finding the index of the second positive element
            for (j = 0; j < 20; j++)
            {
                if (iArray[j] > 0) jnum += 1;
                if (jnum == 2) break;
            }

            // Outputting the array elements
            foreach (int jj in iArray)
            {
                Console.Write(" " + jj);
            }
            Console.WriteLine("\n\n");

            // Displaying the index and value of the second positive element
            Console.WriteLine("індекс другого позитивного елемента = " + j);
            Console.WriteLine("iArray[" + j + "] = " + iArray[j]);

            jnum = 0;

            // Finding the index of the third negative element
            for (j = 0; j < 20; j++)
            {
                if (iArray[j] < 0) jnum += 1;
                if (jnum == 3) break;
            }

            // Displaying the index and value of the third negative element
            Console.WriteLine("індекс третього негативного елемента = " + j);
            Console.WriteLine("iArray[" + j + "] = " + iArray[j]);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}*/




/* ПРИКЛАД 8
 using System;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            int jnum = 0, N = 20;
            int jAA = 0, jBB = 0;
            int j, k, temp;
            Random rnd = new Random();
            int[] iArray = new int[N];
            int[] jA = new int[N];
            int[] jB = new int[N];

            // Filling the original array with random numbers
            for (j = 0; j < N; j++)
            {
                iArray[j] = rnd.Next(1, 101);
            }

            Console.WriteLine("\n вихідний масив \n\n");
            foreach (int jj in iArray)
            {
                Console.Write(" " + jj);
            }
            Console.WriteLine("\n\n");

            // Splitting the array into A and B
            for (j = 0; j < N; j++)
            {
                jnum = iArray[j] / 2;
                if (iArray[j] == jnum * 2)
                {
                    jA[jAA] = iArray[j];
                    jAA += 1;
                }
                else
                {
                    jB[jBB] = iArray[j];
                    jBB += 1;
                }
            }

            Console.WriteLine("\n масив A[ ] \n\n");
            for (int i = 0; i < jAA; i++)
            {
                Console.Write(" " + jA[i]);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("\n масив B[ ] \n\n");
            for (int i = 0; i < jBB; i++)
            {
                Console.Write(" " + jB[i]);
            }
            Console.WriteLine("\n\n");

            // Sorting array A
            for (k = 0; k < jAA - 1; k++)
            {
                for (j = 0; j < jAA - k - 1; j++)
                {
                    if (jA[j + 1] < jA[j])
                    {
                        temp = jA[j];
                        jA[j] = jA[j + 1];
                        jA[j + 1] = temp;
                    }
                }
            }

            // Sorting array B
            for (k = 0; k < jBB - 1; k++)
            {
                for (j = 0; j < jBB - k - 1; j++)
                {
                    if (jB[j + 1] < jB[j])
                    {
                        temp = jB[j];
                        jB[j] = jB[j + 1];
                        jB[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\n відсортований масив A[ ] \n\n");
            for (int i = 0; i < jAA; i++)
            {
                Console.Write(" " + jA[i]);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("\n відсортований масив B[ ] \n\n");
            for (int i = 0; i < jBB; i++)
            {
                Console.Write(" " + jB[i]);
            }
            Console.WriteLine("\n\n");

            Console.ReadKey();
        }
    }
}*/





//ЗАВДАННЯ 4
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = 20;
            Random rnd = new Random();
            int[] array = new int[M];
            int maxPositiveIndex = -1;
            int maxPositiveValue = int.MinValue;

            for (int i = 0; i < M; i++)
            {
                array[i] = rnd.Next(-100, 101);
            }

            Console.WriteLine("Масив:");
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < M; i++)
            {
                if (array[i] > 0 && array[i] > maxPositiveValue)
                {
                    maxPositiveValue = array[i];
                    maxPositiveIndex = i;
                }
            }

            if (maxPositiveIndex == -1)
            {
                Console.WriteLine("У масиві немає додатніх елементів.");
                return;
            }

            int negativeCount = 0;
            for (int i = 0; i < maxPositiveIndex; i++)
            {
                if (array[i] < 0)
                {
                    negativeCount++;
                }
            }

            Console.WriteLine("Найбільший додатній елемент: " + maxPositiveValue);
            Console.WriteLine("Кількість від’ємних елементів перед найбільшим додатнім елементом: " + negativeCount);
            Console.ReadKey();
        }
    }
}

