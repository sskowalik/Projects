using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Money
    {
        public float amountOfMoney = 0;
        public void changeAmountOfMoney(float amount)
        {
            amountOfMoney = amountOfMoney + amount;
        }
    }
}
