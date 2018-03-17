using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveWordFromSEntance
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hy, what's up guys? hy";
            List<char> finalList=new List<char>();

            for (int i = 0; i < str.Length; i++)
            {
                char s = str[i];
                finalList.Add(s);
            }

            List<Char> result = finalList.Distinct().ToList();

            foreach (var VARIABLE in result)
            {
                Console.Write(VARIABLE+" ");
            }
        }
    }
}
