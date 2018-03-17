using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SentenceCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '.' || str[i] == '?' || str[i] == '!')
                {
                    count++;
                }
            }

            Console.WriteLine("Total Sentance = {0}",count);
            Console.ReadLine();
        }
    }
}
