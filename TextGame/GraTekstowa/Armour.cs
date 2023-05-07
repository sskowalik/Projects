using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTRGame
{
    internal class Armour
    {
        public string Name { get; private set; }
        public int HP { get; private set; }
        public int DmgReduction { get; private set; }

        public int LvlRequired { get; private set; }
        public Armour() { }

        public Armour(string n, int redu, int hp, int lvl)
        {
            Name = n;
            DmgReduction = redu;
            HP = hp;
            LvlRequired = lvl;
        }
        public void getInfo()
        {
            Thread.Sleep(500);
            Console.WriteLine("NAZWA ZBROJI: " + Name);
            Thread.Sleep(500);
            Console.WriteLine("REDUKCJA OBRAŻEŃ " + DmgReduction);
            Thread.Sleep(500);
            Console.WriteLine("BONUS DO PUNKTÓW ŻYCIA: " +HP);
            Thread.Sleep(500);
            Console.WriteLine("WYMAGANY POZIOM: " + LvlRequired);
            Thread.Sleep(500);
        }
    }
}
// 🗡 🗡🗡 🛡🛡🛡