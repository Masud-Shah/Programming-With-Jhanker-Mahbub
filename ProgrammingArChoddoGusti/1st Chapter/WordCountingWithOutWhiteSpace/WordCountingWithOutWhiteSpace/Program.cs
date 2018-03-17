using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCountingWithOutWhiteSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
          
            int result= CountWord(str);
            Console.WriteLine("Total Word = {0}",result);
            Console.ReadLine();
        }

        private static int CountWord(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' '&& str[i-1] !=' ')
                {
                    count++;
                }
            }
            count++;
            return count;
        }
    }
}
