using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTRGame
{
    internal class Quest
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Exp_gain { get; private set; }
        public int Lvl_required { get; private set; }
        public int Gold_gain { get; private set; }

        private int Count;
        public void addToCount()
        {
            Count++;
        }
        public int getCount()
        {
            return Count;
        }
        public Quest(string n, string d, int e, int g, int l, int c)
        {
            Name = n;
            Description = d;
            Exp_gain = e;
            Lvl_required = l;
            Gold_gain = g;
            Count= c;
        }
        public void getQuestInfo()
        {
            if(Lvl_required!=0)
            Console.WriteLine("WYMAGANY POZIOM: "+ Lvl_required);
            Thread.Sleep(1500);
            Console.WriteLine("MISJA: " + Name);
            Thread.Sleep(1500);
            Console.WriteLine("OPIS: " + Description);
            Thread.Sleep(1500);
            if(Lvl_required!=30)
                Console.WriteLine("NAGRODY: ZŁOTO: " + Gold_gain + " SZTUK ZŁOTA --- DOŚWIADCZENIE: " + Exp_gain+ " PUNKTÓW DOŚWIADCZENIA");
            Thread.Sleep(1500);
            
        }
    }
}
