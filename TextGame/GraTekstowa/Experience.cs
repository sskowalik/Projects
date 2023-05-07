using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTRGame
{
    internal class Experience
    {
        private int Exp=0;
        private int Exp_max=10;
        public Level Level { get; set; }
        public Experience(Level lvl)
        {
            this.Level = lvl;
        }
        public void addExp (int e)
        {
            Exp = Exp+e;
            while (Exp > Exp_max)
            {
                Exp = Exp - Exp_max;
                Level.LvlUp();
                setExp_max();
                Console.WriteLine("GRATULACJE! AWANSOWAŁEŚ NA NOWY POZIOM! AKTUALNY POZIOM BOHATERA: " + Level.getLvl());
                Thread.Sleep(1500);

            }
        }
        public int getExp()
        {
            return Exp;
        }
        public void setExp_max()
        {
            Exp_max = Exp_max+(int)1.4*Level.getLvl();
        }
        public int getExp_max()
        {
            return Exp_max;
        }
    }
}
