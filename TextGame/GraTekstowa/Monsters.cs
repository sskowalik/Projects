using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTRGame
{
    internal class Monsters
    {
        public string Name { get; private set; }
        public int MonsterAttack { get; private set; }
        public int MonsterHP { get; private set; }
        public int MonsterDefence { get; private set; }

        public int MonsterEXPToHero { get; private set; }
        public int MonsterGOLDToHero { get; private set; }
        public Monsters(string n, int a, int h, int e, int g)
        {
            Name = n;
            MonsterAttack = a;
            MonsterHP = h;
            MonsterEXPToHero = e;
            MonsterGOLDToHero = g;

        }
        public Monsters(string n, int a, int h, int e, int g, int d)
        {
            Name = n;
            MonsterAttack = a;
            MonsterHP = h;
            MonsterEXPToHero = e;
            MonsterGOLDToHero = g;
            MonsterDefence = d;

        }
        public void showInfo()
        {
            Console.WriteLine("NAZWA POTWORA: "+ Name);
            Console.WriteLine("ATAK POTWORA "+ MonsterAttack);
            Console.WriteLine("PUNKTY ŻYCIA POTWORA: " + MonsterHP);
            if (MonsterDefence!=0)
            {
                Console.WriteLine("PANCERZ POTWORA: " + MonsterDefence);
            }
            Console.WriteLine("NAGRODY: "+MonsterGOLDToHero +" SZTUK ZŁOTA --- " + MonsterEXPToHero +" PUNKTÓW DOŚWIADCZENIA");
            Thread.Sleep(1500);
            Console.WriteLine();


        }
    }
}
