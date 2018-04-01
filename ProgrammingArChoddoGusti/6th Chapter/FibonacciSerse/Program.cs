using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSerse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Find Serise : ");
            int n = Convert.ToInt32(Console.ReadLine());
            FiboSerise(n);
            Console.WriteLine();
        }

        public static void FiboSerise(int n)
        {
            Console.Write("0 1");
            int a = 0, b = 1, c = 0;
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write(" " + c);
                a = b;
                b = c;
            }
        }
    }
}
