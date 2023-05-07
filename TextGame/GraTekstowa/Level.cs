using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTRGame
{
    internal class Level
    {
        private int Lvl=0;
        public void LvlUp ()
        {
            Lvl++;
        }
        public int getLvl()
        {
            return Lvl;
        }
    }
}
