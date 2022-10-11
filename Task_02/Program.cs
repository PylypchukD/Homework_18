using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_02_1;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Создайте класс с методом помеченным модификатором доступа public. Докажите, что к данному методу можно обратиться не только из текущей сборки, но и из производного класса внешней сборки. 
             */

            InternalClass internalClass = new InternalClass(); // Ошибка уровня компиляции из-за отсутствия модификатора доступа public, иначе все работает.
            internalClass.Show();

            Console.ReadKey();
        }
    }
}
