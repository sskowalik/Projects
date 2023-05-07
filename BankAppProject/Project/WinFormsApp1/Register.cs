using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent(); 
            
        }
        User ControlableUser = new User();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2 != null) { ControlableUser.surname = textBox2.Text; }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1 != null) { ControlableUser.name = textBox1.Text; }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateUser();
            ControlableUser.AddToList(ControlableUser);
            if(CheckIfAllFilled()==false)
            {
                var x = MessageBox.Show("All data has to be filled!");
            }
            else
            {
                Close();

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4 != null) { ControlableUser.Adress = textBox4.Text; }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3 != null) { ControlableUser.age = textBox3.Text; }


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6 != null) { ControlableUser.ID_number = textBox6.Text; }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5 != null) { ControlableUser.contactMail = textBox5.Text; }

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8 != null) { ControlableUser.id = textBox8.Text; }
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7 != null) { ControlableUser.password = textBox7.Text; }

        }
        public User CreateUser()
        {

            WriteToFile();
            return ControlableUser;

        }
        public void WriteToFile()
        {
            StreamWriter writer = new StreamWriter("D:\\Studia\\Programowanie i projektowanie obiektowe\\PROJECT\\PROJECT\\Project\\WinFormsApp1\\Data.txt", true);
            if (CheckIfAllFilled() == true)
            {
                writer.WriteLine(ControlableUser.name);
                writer.WriteLine(ControlableUser.surname);
                writer.WriteLine(ControlableUser.Adress);
                writer.WriteLine(ControlableUser.age);
                writer.WriteLine(ControlableUser.contactMail);
                writer.WriteLine(ControlableUser.ID_number);
                writer.WriteLine(ControlableUser.id);
                writer.WriteLine(ControlableUser.password);
            }
            writer.Close();
        }
        public bool CheckIfAllFilled()
        {
            if ((ControlableUser.contactMail != null || ControlableUser.id != null || ControlableUser.ID_number != null || ControlableUser.name != null || ControlableUser.surname != null || ControlableUser.Adress != null || ControlableUser.password != null || ControlableUser.age != null) && (ControlableUser.contactMail.Length > 1  || ControlableUser.id.Length > 1 || ControlableUser.ID_number.Length > 1 || ControlableUser.name.Length > 1 || ControlableUser.surname.Length > 1 || ControlableUser.Adress.Length > 1 || ControlableUser.password.Length > 1 || ControlableUser.age.Length > 1))
            {
                return true;
            }
            else
            { return false; }
        }
    }
}
