using System;
using System.Collections.Generic;

namespace WinFormsApp1
{
    public class Creator 
    {
        public string GenerateID()
        {
            string id_ = "";
            for (int i = 0; i < 10; i++)
            {
                Random rand = new Random();
                id_ = id_ + rand.Next(0, 10).ToString();
            }
            return id_;
        }
        public User CreateUser(int option)
        {
            if(option==1)
            {
                User user1 = new User();
                user1.name = "Jan";
                user1.surname = "Kowalski";
                user1.age = "30";
                user1.id = GenerateID();
                user1.Adress = "WARSZAWA 22-113 Fiołkowa 21";
                user1.ID_number = "XYA21153";
                return user1;
            }
            if (option == 2)
            {
                User user2 = new User();
                user2.name = "Anna";
                user2.surname = "Bąk";
                user2.age = "18";
                user2.id = GenerateID();
                user2.Adress = "KRAKÓW 12-453 Miodowa 1A";
                user2.ID_number = "ZAC16073";
                return user2;
            }
            if (option == 3)
            {
                User user3 = new User();
                user3.name = "Waldemar";
                user3.surname = "Nowak";
                user3.age = "66";
                user3.id = GenerateID();
                user3.Adress = "KATOWICE 42-113 Żelazna 112";
                user3.ID_number = "DAY32139";
                return user3;
            }
            return null;
            

        }

    }
}


