using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MargeSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            int []first= new int[4] {2,4,5,7};
            int[] secound = new int[3] {1,3,6};

            int length = first.Length + secound.Length;
            int j = 0, k = 0;

            List<int>margedList= new List<int>();

            for (int i = 0; i < length-1; i++)
            {
                if (first[j] < secound[k])
                {
                    margedList.Add(first[j]);
                    j++;
                }
                else
                {
                    margedList.Add(secound[k]);
                    k++;
                }
            }

            foreach (int i in margedList)
            {
                Console.Write(i+" ");
            }
        }
    }
}
