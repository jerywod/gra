using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Level
    {
        public static int[] levelowanie(int xp, int typ)
        {
            if (xp >= 100)
            {
                xp = xp - 100;
                
                if (typ == 0)
                {
                    int[] zwrot = { 10, 2 };
                    return zwrot;
                }
                if (typ == 1)
                {
                    int[] zwrot = { 3, 6 };
                    return zwrot;
                }
                else{
                    int[] zwrot = { 1, 1 };
                    return zwrot;
                }
            }
            int[] zwwrot = { 0, 0};
            return zwwrot;
        }
    }
}
