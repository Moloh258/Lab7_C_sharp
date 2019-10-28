using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int B = Convert.ToInt32(Console.ReadLine());
            if (A > 2 && B <= 3)
            {
                Console.WriteLine("Неравенства A > 2 и B <= 3 справедливы");
            }
            else Console.WriteLine("Неравества несправедливы");
        }
    }
}
