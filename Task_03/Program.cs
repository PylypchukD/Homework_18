using MyNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Создайте собственное пространство имен MyNamespace с классом MyClass и подключите его в другом приложении.
             */

            MyClass myClass = new MyClass();
            myClass.Show();

            Console.ReadKey();
        }
    }
}
