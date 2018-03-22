using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactrialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=  Factrial(4);
            Console.WriteLine(a);
            Console.ReadLine();
        }

        public static int Factrial(int number)
        {
            if (number == 0)
                return 1;
            return number*Factrial(number - 1);

        }
    }
}
