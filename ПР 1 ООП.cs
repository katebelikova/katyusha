/*Завдання 10
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace XmlSerializationExample
{
    [XmlRoot("firma")]
    public class Firma
    {
        [XmlElement("personal")]
        public List<Personal> PersonalList { get; set; }
    }

    public class Personal
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlElement("firstname")]
        public string FirstName { get; set; }

        [XmlElement("lastname")]
        public string LastName { get; set; }

        [XmlElement("nickname")]
        public string Nickname { get; set; }

        [XmlElement("salary")]
        public decimal Salary { get; set; }
    }

    public static class XmlConverter
    {
        public static Firma DeserializeFirma(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Firma));
            using (StringReader reader = new StringReader(xml))
            {
                return (Firma)serializer.Deserialize(reader);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            string xmlData = @"<?xml version=""1.0""?>
<firma>
  <personal id=""1001"">
    <firstname>олег</firstname>
    <lastname>Пупкин</lastname>
    <nickname>oleg</nickname>
    <salary>100000</salary>
  </personal>
  <personal id=""2001"">
    <firstname>Петро</firstname>
    <lastname>Гадув</lastname>
    <nickname>petro</nickname>
    <salary>200000</salary>
  </personal>
</firma>";

            Firma firma = XmlConverter.DeserializeFirma(xmlData);

            foreach (var personal in firma.PersonalList)
            {
                Console.WriteLine($"ID: {personal.Id}");
                Console.WriteLine($"Ім'я: {personal.FirstName}");
                Console.WriteLine($"Прізвище: {personal.LastName}");
                Console.WriteLine($"ник нейм: {personal.Nickname}");
                Console.WriteLine($"Зарплата: {personal.Salary}");
                Console.WriteLine();
            }
        }
    }*/



/*Завдання 7
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace XmlSerializationExample
{
    [XmlRoot("breakfast_menu")]
    public class CaffeeMenu
    {
        [XmlElement("food")]
        public List<Food> Foods { get; set; }
    }

    public class Food
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("price")]
        public string Price { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("calories")]
        public int Calories { get; set; }
    }

    public static class XmlConverter
    {
        public static CaffeeMenu DeserializeCaffeeMenu(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(CaffeeMenu));
            using (StringReader reader = new StringReader(xml))
            {
                return (CaffeeMenu)serializer.Deserialize(reader);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            string xmlData = @"<?xml version=""1.0""?>
<breakfast_menu>
  <food>
    <name>Морозиво</name>
    <price>$8</price>
    <description>пломбір з додаванням будь якого топингу</description>
    <calories>650</calories>
  </food>
  <food>
    <name>Французький Тост</name>
    <price>$4.50</price>
    <description>зроблений зі шматочків домашнього хліба</description>
    <calories>400</calories>
  </food>
  <food>
    <name>донатс</name>
    <price>$3</price>
    <description>донатс з будь якою начінкою</description>
    <calories>950</calories>
  </food>
</breakfast_menu>";

            CaffeeMenu caffeeMenu = XmlConverter.DeserializeCaffeeMenu(xmlData);

            foreach (var food in caffeeMenu.Foods)
            {
                Console.WriteLine($"Назва: {food.Name}");
                Console.WriteLine($"Ціна: {food.Price}");
                Console.WriteLine($"Опис: {food.Description}");
                Console.WriteLine($"Калорії: {food.Calories}");
                Console.WriteLine();
            }
        }
    }
}*/

