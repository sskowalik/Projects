using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Mortgage : Loan
    {

        User User = new User();
        Money Money = new Money();
        public Mortgage() { }
        public Mortgage(User user, Money money)
        {
            User = user;
            Money = money;
        }
        public void TakeLoan(Money money, int amount)
        {
            money.changeAmountOfMoney(amount);
        }

    }
}
