using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTRGame
{
    internal class Gold
    {
        private int amount = 0;

        public void addGold(int a)
        {
            amount = a + amount;
        }
        public int getGold()
        {
            return amount;
        }
    }
}
