using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class StudentLoan : Loan
    {
        User User = new User();
        Money Money = new Money();
        public StudentLoan(User user, Money money) 
        {
            User = user;
            Money = money;
        }
        public void TakeLoan(Money money, int amount)
        {
            if (Convert.ToInt32(User.age)<24)
            {
                if(amount>1000)
                {
                    var x = MessageBox.Show("You can't loan that much money!");
                }
                if (amount<=0)
                {
                    var x = MessageBox.Show("You can't loan that less money!");
                }
                if(amount>0 && amount<=1000)
                {
                    var x = MessageBox.Show("Student Loan - Taken!");
                    Money.changeAmountOfMoney(amount);
                }
                
            }
            else { var x = MessageBox.Show("You are too old for that loan!"); }
        }
    }
}
