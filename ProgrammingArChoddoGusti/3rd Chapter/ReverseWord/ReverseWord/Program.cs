using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWord
{
    class Program
    {
       public static void Main(string[] args)
        {
           string word = Console.ReadLine();

           string s = ReverseString(word);
           Console.WriteLine("Reverse Word = {0}",s);
           Console.WriteLine();

           if (word == s)
           {
               Console.WriteLine("Palindrome");
           }
           else
           {
               Console.WriteLine("Not palindrome");
           }
            Console.ReadLine();
        }

        public static string ReverseString(string str)
        {
            string reverseWord = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverseWord += str[i].ToString();
            }
            return reverseWord;
        }
    }
}
