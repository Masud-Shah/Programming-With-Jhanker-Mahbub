using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveAddNumberAndAddOnlyOddNumbe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> userNumber= new List<int>() {12,23,45,65,63,13,5,8};
            List<int>numbers=new List<int>();

            for (int i = 0; i < userNumber.Count; i++)
            {
                int a = userNumber[i];
                if (a%2 == 0)
                {
                    continue;
                }
                else
                {
                    numbers.Add(a);
                }
            }

            List<int> result = numbers.Distinct().ToList();

            foreach (var i in result)
            {
                Console.Write(i+" ");
            }
        }
    }
}
