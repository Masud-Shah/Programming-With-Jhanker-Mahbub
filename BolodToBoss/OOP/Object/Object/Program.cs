using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p= new Person(2416,"Prodip","Sarker","Male","Dhaka");

            //p.Id = 2416;
            //p.FirstName = "Prodip";
            //p.LastName = "Sarker";
            //p.Gender = "Male";
            //p.City = "Dhaka";


            Console.WriteLine(p.Id);


      
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }

        public Person(int id,string firstName, string lastName, string gender, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            City = city;
        }
    }
}
