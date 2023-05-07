using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace WinFormsApp1
{
    internal class LoginData
    {
        public string password_given;
        public string login_given;
        public string password_static;
        public string login_static;
        public bool CheckIfDataCorrect()
        {
           
                StreamReader sr = File.OpenText("D:\\Studia\\Programowanie i projektowanie obiektowe\\PROJECT\\PROJECT\\Project\\WinFormsApp1\\Data.txt");
            string s = "";
            int i= 0;
            int check = 0;
            while ((s=sr.ReadLine()) != null)
            {
                if (i == 0)
                {
                    login_static = s;
                }
                if (i == 7)
                {
                    password_static = s;
                }
                i++;
            }
            sr.Close();
            if (login_static == login_given && password_static == password_given)
            {
                
                return true;

            }
            else return false;
            
            
        }
    }
}
