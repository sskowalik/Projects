using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Transfer
    {
        public Transfer() { }
        User User = new User();
        Money Money = new Money();
        public Transfer(User user, Money money)
        {
            User = user;
            Money = money;
            Console.WriteLine(money.amountOfMoney);
        }
        public string Tittle;
        public bool CheckIfEnoughMoney(Money x, float amountNeeded)
        {
            Console.WriteLine(Money.amountOfMoney);
            if (x.amountOfMoney >= amountNeeded)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void RunTransfer(Money UserFrom, Money UserTo, float moneyToSend)
        {
            if (CheckIfEnoughMoney(UserFrom, moneyToSend) == true)
            {
                UserFrom.changeAmountOfMoney(-moneyToSend);
                UserTo.changeAmountOfMoney(moneyToSend);
            }
        }
    }
}
