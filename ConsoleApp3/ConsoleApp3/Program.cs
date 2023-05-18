// See https://aka.ms/new-console-template for more information
using ConsoleApp3;
using System;

Console.WriteLine("Hello, World!");
int[] staty =Bohater.wyborBohatera();

int[] upgrade;
int MAXzycie = staty[0];
while (true)
{
    Console.WriteLine($" masz życia {staty[0]}");
    Console.WriteLine($"masz dmg {staty[1]}");
    Console.WriteLine($"masz xp {staty[2]}");
    Console.WriteLine($"masz golda {staty[3]}");

    Console.WriteLine(" co chcesz zrobić -a idz sie bić b- lecz sie c- poddaj sie ");
    string inp = Console.ReadLine();
    if(inp == "a")
    {
        int[] ints = Walka.Walka2(staty[1], staty[0]);
        if (ints[2] < 1) { Console.WriteLine("przegrales");
            break;
        }
        staty[2] =staty[2]+ ints[0];
        staty[3] =staty[3]+ ints[1];
        staty[0] = ints[2]; 
    }
    if (inp == "b")
    {
        if (NAukaWSwiatynia.matematycznaWalka())
        {
            staty[0] = staty[0] + 10;
            staty[2] = staty[2] + 5;
            if (staty[0] > MAXzycie) staty[0] = MAXzycie;
        }
    }
    if (inp =="c")
    {
        Console.WriteLine("przegrales");
        break;
    }
    upgrade = Level.levelowanie(staty[2], staty[4]);
  
    staty[0] = staty[0] + upgrade[0];
    MAXzycie = MAXzycie + upgrade[0];
    staty[1] = staty[1] + upgrade[1];
    upgrade[0] = 0;
    upgrade[1] = 0;

    if (staty[3] > 10000) { Console.WriteLine("wygrałes");
        break;
    }
}