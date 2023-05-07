using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal interface Loan
    {
        public void TakeLoan(Money money, int amount);
    }
}
