using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelChecking
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
           
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u'|| str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    count++;
                }
            }

            Console.WriteLine("Total Vowel = {0}",count);

            Console.ReadLine();
        }
    }
}
