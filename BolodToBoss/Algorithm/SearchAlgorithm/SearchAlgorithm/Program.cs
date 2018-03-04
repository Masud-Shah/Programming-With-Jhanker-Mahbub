using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] choukirTola = new string[6];

            //choukirTola[0] = "Balish";
            //choukirTola[1] = "Kol-Balish";
            //choukirTola[2] = "T-Shir";
            //choukirTola[3] = "Charger";
            //choukirTola[4] = "Sim";
            //choukirTola[5] = "Head-Phone";
           
            //for (int i = 0; i < choukirTola.Length; i++)
            //{
            //    var searchCharger = choukirTola[i];
            //    if (searchCharger == "Charger")
            //    {
            //        Console.WriteLine("Paici charger :)");
            //        Console.WriteLine();
            //        break;
            //    }
            //}


            string[] locationSearch= new string[5];
            locationSearch[0] = "Cousin-House";
            locationSearch[1] = "Home-Town";
            locationSearch[2] = "Hotel";
            locationSearch[3] = "Friend-House";
            locationSearch[4] = "Town-House";

            // Find Index In Array,,,,,,,,,,,,,

            var index = Array.FindIndex(locationSearch, x => x == "Friend-House");

            Console.WriteLine("Index= "+index);
            for (int i = 0; i < locationSearch.Length; i++)
            {
                var findHouse = locationSearch[i];
                if (findHouse == "Friend-House")
                {
                    Console.WriteLine("Paici :)");
                    Console.WriteLine("Index = "+i);
                    break;
                }
            }
        }
    }
}
