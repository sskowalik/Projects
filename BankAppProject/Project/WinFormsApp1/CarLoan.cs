using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class CarLoan: Loan
    {
        Car Car = new Car();
        Money Money= new Money();
        public CarLoan(Car car, Money money)
        {
            Car= car;
            Money= money;
        }
        public void TakeLoan(Money money, int amount)
        {
            if (amount > 100000)
            {
                var x = MessageBox.Show("You can't loan that much money!");
            }
            else
            {
                money.changeAmountOfMoney(amount);
            }
        }
    }
}
