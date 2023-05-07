using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTRGame
{
    internal class Helmet
    {
        public string Name { get; private set; }
        public int Armor { get; private set; }
        public int LvlRequired { get; private set; }
        public Helmet() { }

        public Helmet(string n, int ar, int lvl)
        {
            Name = n;
            Armor = ar;
            LvlRequired = lvl;
        }
        public void getInfo()
        {
            Thread.Sleep(500);
            Console.WriteLine("NAZWA HEŁMU: " + Name);
            Thread.Sleep(500);
            Console.WriteLine("PANCERZ " + Armor);
            Thread.Sleep(500);
            Console.WriteLine("WYMAGANY POZIOM: " + LvlRequired);
            Thread.Sleep(500);
        }
    }
}
