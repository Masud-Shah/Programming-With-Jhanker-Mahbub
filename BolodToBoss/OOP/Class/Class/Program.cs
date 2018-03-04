using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Flower redRose= new Flower("Red Rose","Red","Awesome");

            Console.WriteLine(redRose.Name +" "+redRose.Color+" "+redRose.Smell);

            Flower whiteRose = new Flower("White Rose", "White", "Awesome");

            Console.WriteLine(whiteRose.Name + " " + whiteRose.Color + " " + whiteRose.Smell);
        }
    }
}
