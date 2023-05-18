using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace ConsoleApp3
{
    internal class Walka
    {
        

    public static int[] Walka2(int dmg,int zycie) {
            int[] bluebuff = { 30, 7, 30, 10 };
            int[] redbuff = { 30, 14, 30, 10 };
            int[] gromp = { 20, 3, 5, 20 };
            int[] kurczak = { 5, 1, 2, 60 };
            int[] nagrody= {0,0,zycie};
            Random rnd = new Random();
            int walka = rnd.Next(0, 100);
            Console.WriteLine(walka);
            if (walka >= 0 && walka <= 10) {
                //blue
                Console.WriteLine("Walka");
                int zycieblue = bluebuff[0];
                int dmgblue = bluebuff[1];
                while (true)
                {
                    zycieblue=zycieblue - dmg;
                    if(zycieblue < 0) {
                        nagrody[0] = bluebuff[2];
                        nagrody[1] = bluebuff[3];
                        nagrody[2] = zycie;
                        Console.WriteLine($"Wygrales :{bluebuff[2]}XP");
                        break;
                    }
                    zycie = zycie - dmgblue;
                    if (zycie < 0)
                    {
                        nagrody[0] = bluebuff[2];
                        nagrody[1] = bluebuff[3];
                        nagrody[2] = 0;
                        Console.WriteLine($"przegrales");
                        break;
                    }
                    Console.WriteLine($"zycie blue :{zycieblue}");
                    Console.WriteLine($"zycie twoje :{zycie}");
                }
            }
            else if (walka > 10 && walka <= 20)
            {  //red
                int zyciered = redbuff[0];
                int dmgred = redbuff[1];
                while (true)
                {
                    zyciered = zyciered - dmg;
                    if (zyciered < 0)
                    {
                        nagrody[0] = redbuff[2];
                        nagrody[1] = redbuff[3];
                        nagrody[2] = zycie;
                        Console.WriteLine($"Wygrales :{redbuff[2]}XP");
                        break;
                    }
                    zycie = zycie - dmgred;
                    if (zycie < 0)
                    {
                        nagrody[0] = redbuff[2];
                        nagrody[1] = redbuff[3];
                        nagrody[2] = 0;
                        Console.WriteLine($"przegrales");
                        break;
                    }
                }
            }
        
            else if (walka > 20 && walka <= 40)
            { //gromp
                int zyciegromp = gromp[0];
                int dmggromp = gromp[1];
                while (true)
                {
                    zyciegromp = zyciegromp - dmg;
                    if (zyciegromp < 0)
                    {
                        nagrody[0] = gromp[2];
                        nagrody[1] = gromp[3];
                        nagrody[2] = zycie;
                        Console.WriteLine($"Wygrales :{gromp[2]}XP");
                        break;
                    }
                    zycie = zycie - dmggromp;
                    if (zycie < 0)
                    {
                        nagrody[0] = gromp[2];
                        nagrody[1] = gromp[3];
                        nagrody[2] = 0;
                        Console.WriteLine($"p[rzegrales");
                        break;
                    }
                }
            }
            else
            {//kurczak
                Console.WriteLine("kuracz");
                int zyciekurczak = kurczak[0];
                int dmgkurczak = kurczak[1];
                while (true)
                {
                    zyciekurczak = zyciekurczak - dmg;
                    if (zyciekurczak < 0)
                    {
                        nagrody[0] = kurczak[2];
                        nagrody[1] = kurczak[3];
                        nagrody[2] = zycie;
                        Console.WriteLine($"Wygrales :{kurczak[2]}XP");
                        break;
                    }
                    zycie = zycie - dmgkurczak;
                    if (zycie < 0)
                    {
                        nagrody[0] = kurczak[2];
                        nagrody[1] = kurczak[3];
                        nagrody[2] = 0;
                        Console.WriteLine($"przegrales");
                        break;
                    }
                }
            }
            
            return nagrody;
        }
    }
}
