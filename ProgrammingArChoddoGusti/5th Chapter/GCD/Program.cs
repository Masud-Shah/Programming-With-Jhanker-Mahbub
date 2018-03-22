using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = greatestCommonDivisor(54, 24);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static  int  greatestCommonDivisor(int a, int b)
        {
            var divisor = 2;
            var greatestDivisor = 1;

            if (a < 2 || b < 2)
                return 1;

            while (a >= divisor && b >= divisor)
            {
                if (a % divisor == 0 && b % divisor == 0)
                {
                    greatestDivisor = divisor;
                }
                divisor++;
            }
            return greatestDivisor;
        }
    }
}
