using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mobile> mobiles= new List<Mobile>();
            Mobile M= new Mobile() { Brand = "Welton", Price = 4500, Camera = 8};
            Mobile M4 = new Mobile() { Brand = "LG", Price = 8500, Camera = 12 };
            Mobile M3 = new Mobile() { Brand = "HTC", Price = 7500, Camera = 11 };
            Mobile M1 = new Mobile() { Brand = "Symphony", Price = 5500, Camera = 9 };
            Mobile M2 = new Mobile() { Brand = "Micromax", Price = 6500, Camera = 10 };
           

            mobiles.Add(M);
            mobiles.Add(M4);
            mobiles.Add(M3);
            mobiles.Add(M1);
            mobiles.Add(M2);
            SortByProperty(mobiles);
        }

        static void SortByProperty(List<Mobile> mobiles)
        {
            List<Mobile> SortedList = mobiles.OrderBy(o => o.Price).ToList();

            foreach (var mobile in SortedList)
            {
                Console.WriteLine(mobile.Brand + " - " + mobile.Price+" - "+mobile.Camera);
            }
        }
    }
}
