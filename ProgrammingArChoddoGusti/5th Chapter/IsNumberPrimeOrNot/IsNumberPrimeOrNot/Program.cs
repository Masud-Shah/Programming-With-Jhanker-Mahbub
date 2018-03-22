using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsNumberPrimeOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Prime(23);
        }

        private static void Prime(int a)
        {    
            int count = 0;
            for (int i = 2; i < a; i++)
            {
                if (a%i == 0)
                {
                     count++;
                 
                }    
            }

            if (count > 0)
            {
                Console.WriteLine("Not Prine");
            }
            else
            {
                Console.WriteLine("Prime");
            }
        }
    }
}
