using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTRGame
{
    internal class Weapon
    {
        public string Name { get; private set; }
        public int AtackMin { get; private set; }
        public int AtackMax { get; private set; }
        public int LvlRequired { get; private set; }

        public Weapon(){}
        public Weapon(string n, int amin, int amax, int lvl)
        {
            Name = n;
            AtackMin = amin;
            AtackMax = amax;
            LvlRequired = lvl;
        }
        public void getInfo()
        {
            Thread.Sleep(500);
            Console.WriteLine("NAZWA BRONI: "+Name);
            Thread.Sleep(500);
            Console.WriteLine("WARTOŚĆ ATAKU "+AtackMin +" - "+AtackMax);
            Thread.Sleep(500);
            Console.WriteLine("WYMAGANY POZIOM: "+LvlRequired);
            Thread.Sleep(500);
        }
    }
}
