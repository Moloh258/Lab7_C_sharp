using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int X = Convert.ToInt32(Console.ReadLine());
            int a = X / 1000;
            int b = X / 100;
            b = b % 10;
            int c = X % 100;
            int d = c % 10;
            c = c / 10;
            if (a == d && b == c)
            {
                Console.WriteLine("Данное число читается одинаково слева направо и справа налево");
            }
            else
            {
                Console.WriteLine("Данное число не читается одинаково слева направо и справа налево");
            }            
        }
    }
}
