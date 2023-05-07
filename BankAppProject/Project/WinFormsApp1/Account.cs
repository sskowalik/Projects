using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Account
    {
        User user;
        Money money;
        public Account()
        {

        }
        public Account(Money money)
        {
            this.money = money;
        }
        public Account(User user, Money money)
        {
            this.user = user;
            this.money = money;
        }

        public bool CheckIfControlableUser()
        {
            if (user.password == null)
            {
                return false;
            }
            else return true;
        }
        public List<string> sender = new List<string>();
        public List<string> receiver = new List<string>();
        public List<string> date = new List<string>();
        public List<string> amount = new List<string>();

        public void AddToLists(string s, string r,string d, string a)
        {
            sender.Add(s);
            receiver.Add(r);
            date.Add(d);
            amount.Add(a);
        }
        

    }
}
