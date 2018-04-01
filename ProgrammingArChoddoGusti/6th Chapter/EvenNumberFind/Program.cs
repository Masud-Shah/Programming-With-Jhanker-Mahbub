using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumberFind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Find Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int result= EvenNumber(n);
            Console.WriteLine(result);
            Console.WriteLine();
        }

        public static int EvenNumber(int n)
        {
            if (n < 1)
                return 1;
            return 2*EvenNumber(n - 1);
        }
    }
}
