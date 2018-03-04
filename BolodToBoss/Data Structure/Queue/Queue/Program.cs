using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<string> QueueName= new Queue<string>();

            QueueName.Enqueue("Joy");
            QueueName.Enqueue("Tamjid");
            QueueName.Enqueue("Tuhin");
            QueueName.Enqueue("Prodip");

            foreach (string name in QueueName)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("----------------------------------");

            QueueName.Dequeue();

            foreach (string name in QueueName)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("----------------------------------");

            QueueName.Dequeue();

            foreach (string name in QueueName)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("----------------------------------");

            QueueName.Enqueue("Tanmoy");


            foreach (string name in QueueName)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("----------------------------------");
        }
    }
}
