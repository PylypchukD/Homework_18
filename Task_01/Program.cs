using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task_02;

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Используя пример выполненного домашнего задания 3 из 14 урока, реализуйте возможность подключения вашего пространства имен и работы с MyDictionary аналогично экземпляру класса Dictionary. 
             */

            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
            dictionary.Add("Белый", "White");
            dictionary.Add("Серый", "Gray");
            dictionary.Add("Черный", "Black");
            dictionary.Add("Синий", "Blue");
            dictionary.Add("Красный", "Red");
            dictionary.Add("Желтый", "Yellow");
            dictionary.Add("Зеленый", "Green");

            Console.WriteLine($"Количество элементов в словаре: {dictionary.Lenght}");

            Console.WriteLine("Элементы словаря: ");
            for (int i = 0; i < dictionary.Lenght; i++)
            {
                Console.WriteLine(dictionary[i]);
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Поищем значение \"Белый\": {dictionary["Белый"]}");

            Console.ReadKey();
        }
    }
}
