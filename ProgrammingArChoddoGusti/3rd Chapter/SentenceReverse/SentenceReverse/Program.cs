using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SentenceReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string reverseString = "";
            var words = str.Split();

            for (int i = words.Length-1; i >=0; i--)
            {
                reverseString += words[i] + " ";
            }

            Console.WriteLine("Reverse Sting = {0}",reverseString);
            Console.ReadLine();
        }

       
    }
}
