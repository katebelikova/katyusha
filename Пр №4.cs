/*using System.Xml.Serialization;
using System;
 
namespace Practice04
{
    public class Person
    {
        public string Name { get; set; } = "Undefined";
        public int Age { get; set; } = 1;

        public Person() { }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class class1
    {
        static void Main(string[] args)
        {
            Person person = new Person("Tom", 37);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            string filepath = "C:\\Users\\User\\Desktop\\pix.txt";
            // отримуємо потік, куди записуватимемо серіалізований об'єкт
            using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, person);
                Console.WriteLine("Object has been serialized");
            }

            // десеріалізуємо об'єкт
            using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate))
            {
                Person? dperson = xmlSerializer.Deserialize(fs) as Person;
                Console.WriteLine($"Name: {dperson?.Name}  Age: {dperson?.Age}");
            }
        }
    }
}*/


using System.Xml.Serialization;

namespace Example2
{
    public class Person
    {
        public string Name { get; set; } = "Undefined";
        public int Age { get; set; } = 1;

        public Person() { }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[]
            {
                new Person("Tom", 37),
                new Person("Bob", 46)
            };
            string filepath = "C:\\Users\\User\\Desktop\\pix.txt";

            XmlSerializer formatter = new XmlSerializer(typeof(Person[]));
            // збереження масиву у файл
            using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, people);
            }
            // відновлення масиву із файлу
            using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate))
            {
                Person[]? newpeople = formatter.Deserialize(fs) as Person[];

                if (newpeople != null)
                {
                    foreach (Person person in newpeople)
                    {
                        Console.WriteLine($"Name: {person.Name} --- Age: {person.Age}");
                    }
                }
            }
        }
    }
}
