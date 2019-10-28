using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int X = Convert.ToInt32(Console.ReadLine());
            int a = X / 100;
            int b = X % 100;
            int c = b % 10;
            b = b / 10;
            if (a > b && b > c)
            {
                Console.WriteLine("Цифры данного числа образуют убывающую последовательность");
            }
            else
            {
                if (a < b && b < c)
                {
                    Console.WriteLine("Цифры данного числа образуют возрастающую последовательность");
                }
            }
        }
    }
}
