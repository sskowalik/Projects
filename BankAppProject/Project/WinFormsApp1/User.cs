using System;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsApp1
{
    public partial class User
    {
        public List<User> list = new List<User>();
        public string name { get; set; }
        public string age { get; set; }
        public string surname { get; set; }
        public string contactMail { get; set; }
        public string password { get; set; }
        public string id { get; set; }
        public string ID_number { get; set; }
        public string Adress { get; set; }
        public void CreateUser()
        { }
       

        public void AddToList(User user)
        {
            list.Add(user);
        }
        public void RefreshRealUser()
        {
            StreamReader sr = File.OpenText("D:\\Studia\\Programowanie i projektowanie obiektowe\\PROJECT\\PROJECT\\Project\\WinFormsApp1\\Data.txt");
            string s = "";
            int i = 0;
            while ((s = sr.ReadLine()) != null)
            {
                if (i == 0)
                {
                    name = s;
                }
                if (i == 1)
                {
                    surname = s;
                }
                if (i == 2)
                {
                    Adress = s;
                }
                if (i==3)
                {
                    age= s;
                }
                if (i==4)
                {
                    id= s;
                }
                if (i==5)
                {
                    contactMail= s;
                }
                if (i==6)
                {
                    ID_number = s;
                }
                if (i==7)
                {
                    password= s;
                }
                i++;
            }
            sr.Close();
        }
        
    }

}
