using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] result=new int[8] {34,56,45,89,58,3,45,25};
           
            int temp = 0;
            int minimum = 0;

            for (int i = 0; i < result.Length - 1; i++)
            {
                minimum = i;
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[j] < result[minimum])
                    {
                        minimum = j;
                    }

                }
                temp = result[minimum];
                result[minimum] = result[i];
                result[i] = temp;
            }


            foreach (var i in result)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();

            //Array.Sort(result);

            //foreach (var i in result)
            //{
            //    Console.Write(i+" ");
            //}
          
        }
    }
}
