using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteNumberWithRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteNumber(10);
            Console.ReadLine();
        }

        public static void WriteNumber(int number)
        {
            if (number == 0)
                return;
            Console.Write(number+" ");
            WriteNumber(number-1);
        }
    }
}
