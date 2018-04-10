using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoesFind
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Mango> mangoes= new List<Mango>();
           Mango m= new Mango() { Weight = 550,Category = "Himsagore", IsFormaline = true};
           Mango m1= new Mango() {Weight = 450, Category = "Langra", IsFormaline = false};
           Mango m2= new Mango() { Weight = 700, Category = "Fozilee", IsFormaline = false};
           Mango m3 = new Mango() { Weight = 550, Category = "Himsagore", IsFormaline = true };
           Mango m4 = new Mango() { Weight = 450, Category = "Langra", IsFormaline = false };
           Mango m5 = new Mango() { Weight = 780, Category = "Fozilee", IsFormaline = true };

            mangoes.Add(m);
            mangoes.Add(m1);
            mangoes.Add(m2);
            mangoes.Add(m3);
            mangoes.Add(m4);
            mangoes.Add(m5);

            FindWeight(mangoes);

            Console.WriteLine("Fozliee Mango over 400 and Not Formaline");
            Console.WriteLine();

            FazlileeMango(mangoes);

            Console.WriteLine();
            Console.WriteLine("Mango find............");
           
            FindMango(mangoes);

        }

        private static void FindWeight(List<Mango> mangoes)
        {
            List<Mango> MangoWeight = mangoes.Where(x => x.Weight > 500).ToList();

            foreach (Mango mango in MangoWeight)
            {
                Console.WriteLine(mango.Category + " " + " Weight = " + mango.Weight + " IsFormaline= " + mango.IsFormaline);
            }
        }

        private static void FazlileeMango(List<Mango> mangoes)
        {
            List<Mango> MangoWeight = mangoes.Where(x => x.Weight > 400 && x.Category== "Fozilee" && x.IsFormaline==false).ToList();

            foreach (Mango mango in MangoWeight)
            {
                Console.WriteLine(mango.Category + " " + " Weight = " + mango.Weight + " IsFormaline= " + mango.IsFormaline);
            }
        }
        private static void FindMango(List<Mango> mangoes)
        {
            Console.Write("Please write your Mango : ");
            string name = Console.ReadLine();
            List<Mango> MangoWeight = mangoes.Where(x => x.Category==name).ToList();

            foreach (Mango mango in MangoWeight)
            {
                Console.WriteLine(mango.Category + " " + " Weight = " + mango.Weight + " IsFormaline= " + mango.IsFormaline);
            }
        }
    }
}
