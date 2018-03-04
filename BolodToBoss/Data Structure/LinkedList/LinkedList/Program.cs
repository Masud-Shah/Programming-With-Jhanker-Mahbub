using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Person> manonBondhon= new List<Person>();
            

            //Person p= new Person("Tuhin","Bogura");
            //Person p1= new Person("Tamjid","Rajshahi");
            //Person p2= new Person("Prodip","Manikgonj");
            //Person p4 = new Person("Prodip", "Manikgonj");
            //Person p3= new Person("Joy","Dhaka");

            //manonBondhon.Add(p);
            //manonBondhon.Add(p1);
            //manonBondhon.Add(p2);
            //manonBondhon.Add(p3);
            //manonBondhon.Add(p4);

            //foreach (Person person in manonBondhon)
            //{
            //    Console.WriteLine("Name : "+person.Name +" City : "+person.City);
            //}
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine();
            //manonBondhon.Remove(p4);
            //foreach (Person person in manonBondhon)
            //{
            //    Console.WriteLine("Name : " + person.Name + " City : " + person.City);
            //}

            //manonBondhon.Sort();
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine();
          
            //foreach (Person person in manonBondhon)
            //{
            //    Console.WriteLine("Name : " + person.Name + " City : " + person.City);
            //}

            List<int> number= new List<int>() {1,3,5,7,6,2,9,4,8,1,3,4,8};

            foreach (var i in number)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("----------Sort------------");
            Console.WriteLine();

            number.Sort();
            foreach (var i in number)
            {
                Console.Write(i+" ");
            }

            number.Reverse();

            Console.WriteLine();
            Console.WriteLine("----------Reverse------------");
            Console.WriteLine();

            foreach (var i in number)
            {
                Console.Write(i+" ");
            }

            Console.WriteLine();
            Console.WriteLine("----------Remove Duplicate Value------------");
            Console.WriteLine();

            List<int> removeDuplicatenumber = number.Distinct().ToList();

            foreach (var i in removeDuplicatenumber)
            {
                Console.Write(i+" ");
            }


            Console.WriteLine();
            Console.WriteLine("----------Count all value------------");
            Console.WriteLine();

            int a = number.Count;
            Console.WriteLine(a);
            Console.WriteLine();
            Console.WriteLine("----------Remove one------------");
            Console.WriteLine();

            number.Remove(9);
            foreach (var i in number)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.WriteLine("----------First one------------");
            Console.WriteLine();

            int find = number.First();
            Console.WriteLine(find);

           
        }
    }
}
