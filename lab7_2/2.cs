using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число C");
            int C = Convert.ToInt32(Console.ReadLine());
            if (A < B && B < C)
            {
                Console.WriteLine("Двойное неравенство справедливо");
            }
            else
            {
                Console.WriteLine("Неравенство несправедливо");
            }
        }
    }
}
