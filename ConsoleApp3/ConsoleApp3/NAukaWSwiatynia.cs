using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class NAukaWSwiatynia
    {
        public static Boolean matematycznaWalka()
        {
            Console.WriteLine("Nauka");
            Random rnd = new Random();
            int[] tablica = { rnd.Next(0, 10), rnd.Next(0, 10) };
            int dzialanie = rnd.Next(0, 4);
            if (dzialanie == 0)
            {
                Console.WriteLine("dodawanie");
                Console.WriteLine($" {tablica[0]} +{tablica[1]}");
                string inp = Console.ReadLine();
                if (Int16.Parse(inp) == tablica[0] + tablica[1])
                {
                    return true;
                }
                else return false;

            }
            else if (dzialanie == 1)
            {
                Console.WriteLine("odejmowanie");
                Console.WriteLine($" {tablica[0]} -{tablica[1]}");
                string inp = Console.ReadLine();
                if (Int16.Parse(inp) == tablica[0] - tablica[1])
                {
                    return true;
                }
                else return false;
            }
            else if (dzialanie == 2)
            {
                Console.WriteLine("mnozenie");
                Console.WriteLine($" {tablica[0]} *{tablica[1]}");
                string inp = Console.ReadLine();
                if (Int16.Parse(inp) == tablica[0] * tablica[1])
                {
                    return true;
                }
                else return false;
            }
            else
            {
                Console.WriteLine("Bonus EXP");
                return true;
            }
        }
    }
}
