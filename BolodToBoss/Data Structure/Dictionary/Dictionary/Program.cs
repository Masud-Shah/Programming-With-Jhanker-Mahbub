using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> players= new Dictionary<int, string>();

            players[1] = "Masrafiee";
            players[2] = "Sabbir";
            players[3] = "Soumoy";

            foreach (KeyValuePair<int,string> player in players)
            {
                Console.WriteLine(player.Value+" = "+player.Key);
            }
            Console.WriteLine();
            Console.WriteLine("Dictionary soring..........");
            Console.WriteLine();
            List<string> playerList= new List<string>(players.Values);
            playerList.Sort();
            Console.WriteLine(String.Join(" ",playerList.ToArray()));
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            Dictionary<string,int> moneys= new Dictionary<string, int>();

            moneys["Pintu"] = 500;
            moneys["Apurbo"] = 300;
            moneys["Tamjid"] = 50;
            moneys["Tuhin"] = 1800;

            foreach (KeyValuePair<string,int> i in moneys)
            {
                Console.WriteLine(i.Key+" = "+i.Value);
            }

          

            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            Hashtable htMobile= new Hashtable();
             
            htMobile.Add(1,"Prodip");
            htMobile.Add("F", "Tamjid");
            htMobile.Add(3, "Tuhin");

            ICollection key = htMobile.Keys;

            foreach (var h in key)
            {
                Console.WriteLine(h+ " = "+htMobile[h]);
            }
        }
    }
}
