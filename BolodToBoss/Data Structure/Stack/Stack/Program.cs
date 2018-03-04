using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> winterCloths= new Stack<string>();

            winterCloths.Push("Ganji");
            winterCloths.Push("T-shirt");
            winterCloths.Push("Sweater");
            winterCloths.Push("Chador");


            foreach (string winterCloth in winterCloths)
            {
                Console.WriteLine(winterCloth);
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------");

            winterCloths.Pop();

            foreach (string winterCloth in winterCloths)
            {
                Console.WriteLine(winterCloth);
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------");

            winterCloths.Pop();

            foreach (string winterCloth in winterCloths)
            {
                Console.WriteLine(winterCloth);
            }

            Console.WriteLine();
            Console.WriteLine("---------------------------");

            winterCloths.Pop();

            foreach (string winterCloth in winterCloths)
            {
                Console.WriteLine(winterCloth);
            }

            Console.WriteLine();
            Console.WriteLine("---------------------------");

            winterCloths.Pop();

            foreach (string winterCloth in winterCloths)
            {
                Console.WriteLine(winterCloth);
            }

          
            Console.WriteLine();
            Console.WriteLine("---------------------------");


            winterCloths.Push("Ganji");

            foreach (string winterCloth in winterCloths)
            {
                Console.WriteLine(winterCloth);
            }

            Console.ReadLine();
        }
    }
}
