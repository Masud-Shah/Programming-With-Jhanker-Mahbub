using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Person
    {
        public string Name { get; set; }
        public string City { get; set; }

        public Person(string name,string city)
        {
            Name = name;
            City = city;
        }
    }
}
