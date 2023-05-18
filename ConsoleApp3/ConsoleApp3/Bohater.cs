using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Bohater
    {
        public static int[] wyborBohatera()
        {
            Console.WriteLine("Wybór bohatera");
            Console.WriteLine("Garen -g \t Ashe - a");
            string odpowedz =Console.ReadLine();
            if (odpowedz == "g") {
                Console.WriteLine("Wybrano garena");
                int[] staty = { 100, 5, 0, 30,0 };
                return staty;
            }
            else if (odpowedz == "a") {
                Console.WriteLine("Wybrano aszke");

                int[] staty = { 30, 20, 5, 70,1 };
                return staty;
            }
            else {
                Console.WriteLine("zostajesz minionem");
                //hp  dmg xp golda
                int[] staty = {10,10,0,10,2};
                return staty;
            }
       
        } 
    }
}
