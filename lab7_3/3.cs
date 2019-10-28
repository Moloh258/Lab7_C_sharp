using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int A = Convert.ToInt32(Console.ReadLine());
            if (A > 9 && A < 100 && A % 2 == 0)
            {
                Console.WriteLine("Данное число является четным двузначным");
            }
            else
            {
                Console.WriteLine("Данное число не является четным двузначным");
            }
        }
    }
}
