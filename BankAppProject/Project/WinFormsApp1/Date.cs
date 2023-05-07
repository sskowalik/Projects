using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Date
    {
        private string date;
        public void SetDate()
        {
            date = DateTime.Now.ToString();
        }
        public string GetDate()
        {
            SetDate();
            return date;
        }
    }
}
