using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Flower
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Smell { get; set; }

        public Flower(string name, string color, string smell)
        {
             Name=name;
           Color=color;
           Smell=smell;
        }
    }
}
