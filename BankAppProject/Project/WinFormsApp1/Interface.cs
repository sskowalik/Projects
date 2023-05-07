using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
            CreateLabels();

        }
        Creator creator = new Creator();
        Transfer transfer = new Transfer();
        Money money = new Money();
        Money userMoney = new Money();
        Money user1Money = new Money();
        Money user2Money = new Money();
        User RealUser = new User();
        User user = new User();
        User user1 = new User();
        User user2 = new User();
        public int moneyToSend = 0;
        public int moneyToReceive = 0; 
        Account account = new Account();
        Date date = new Date();

        public void CreateLabels()
        {
                date.SetDate();
                user = creator.CreateUser(1);
                user1 = creator.CreateUser(2);
                user2 = creator.CreateUser(3);
                Random random = new Random();
                userMoney.amountOfMoney = random.Next(1, 10000);
                user1Money.amountOfMoney = random.Next(1, 10000);
                user2Money.amountOfMoney = random.Next(1, 10000);
                money.amountOfMoney = 100;
                label11.Text = money.amountOfMoney + "$";
                RealUser.RefreshRealUser();
                label9.Text = user.name + " " + user.surname + "\nAge: " + user.age + "\n" + user.Adress + "\n" + user.id + " " + user.ID_number + "\n" + user.contactMail + "\nAccount Balance: " + userMoney.amountOfMoney + "$";
                label7.Text = user1.name + " " + user1.surname + "\nAge: " + user1.age + "\n" + user1.Adress + "\n" + user1.id + " " + user1.ID_number + "\n" + user1.contactMail + "\nAccount Balance: " + user1Money.amountOfMoney + "$";
                label8.Text = user2.name + " " + user2.surname + "\nAge: " + user2.age + "\n" + user2.Adress + "\n" + user2.id + " " + user2.ID_number + "\n" + user2.contactMail + "\nAccount Balance: " + user2Money.amountOfMoney + "$";
                label6.Text = RealUser.name + " " + RealUser.surname + "\nAge: " + RealUser.age + "\n" + RealUser.Adress + "\n" + RealUser.id + " " + RealUser.ID_number + "\n" + RealUser.contactMail;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(label17, "You have to choose one of your contacts and enter the amount of money!");
                ToolTip1.SetToolTip(label18, "You have to choose one of your contacts and enter the amount of money!");
                transfer = new Transfer(RealUser, money);
        }
        public void RefreshLabels()
        {
            RealUser.RefreshRealUser();
            label11.Text = money.amountOfMoney + "$";
            label9.Text = user.name + " " + user.surname + "\nAge: " + user.age + "\n" + user.Adress + "\n" + user.id + " " + user.ID_number + "\n" + user.contactMail + "\nAccount Balance: " + userMoney.amountOfMoney + "$";
            label7.Text = user1.name + " " + user1.surname + "\nAge: " + user1.age + "\n" + user1.Adress + "\n" + user1.id + " " + user1.ID_number + "\n" + user1.contactMail + "\nAccount Balance: " + user1Money.amountOfMoney + "$";
            label8.Text = user2.name + " " + user2.surname + "\nAge: " + user2.age + "\n" + user2.Adress + "\n" + user2.id + " " + user2.ID_number + "\n" + user2.contactMail + "\nAccount Balance: " + user2Money.amountOfMoney + "$";
            label6.Text = RealUser.name + " " + RealUser.surname + "\nAge: " + RealUser.age + "\n" + RealUser.Adress + "\n" + RealUser.id + " " + RealUser.ID_number + "\n" + RealUser.contactMail;
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(label17, "You have to choose one of your contacts and enter the amount of money!");
            ToolTip1.SetToolTip(label18, "You have to choose one of your contacts and enter the amount of money!");
            transfer = new Transfer(RealUser, money);
            ListsToTable();

        }
        private void Interface_Load(object sender, EventArgs e)
        {
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void label1_Click_1(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
           
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
        public void SetTransfers()
        {

        }
        private bool userClicked;
        private bool user1Clicked;
        private bool user2Clicked;
        private void button1_Click(object sender, EventArgs e)
        {
            if(userClicked)
            {
                transfer.RunTransfer(money, userMoney, moneyToSend);
                var x = MessageBox.Show("You have made a transfer to: " + user.name);
                account.AddToLists(RealUser.name, user.name, date.GetDate(), moneyToSend.ToString());
                RefreshLabels();
            }
            if(user1Clicked) 
            {
                transfer.RunTransfer(money, user1Money, moneyToSend);
                var x = MessageBox.Show("You have made a transfer to: " + user1.name);
                account.AddToLists(RealUser.name, user1.name, date.GetDate(), moneyToSend.ToString());
                RefreshLabels();
            }
            if (user2Clicked)
            {
                transfer.RunTransfer(money, user2Money, moneyToSend);
                var x = MessageBox.Show("You have made a transfer to: " + user2.name);
                account.AddToLists(RealUser.name, user2.name, date.GetDate(), moneyToSend.ToString());
                RefreshLabels();
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = Convert.ToInt32(money.amountOfMoney);
            numericUpDown1.Minimum = 1;
            SetValue(Convert.ToInt32(numericUpDown1.Value));
        }
        public void SetValue(int x)
        {
            moneyToSend = x;
        }
        public void SetValueToReceive(int x)
        {
            moneyToReceive = x;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                userClicked = true; 
            }
            else
            {
                userClicked = false;

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                user1Clicked = true;
            }
            else
            {
                user1Clicked = false;

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                user2Clicked = true;
            }
            else
            {
                user2Clicked = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (userClicked)
            {
                transfer.RunTransfer(userMoney, money, moneyToReceive);
                var x = MessageBox.Show("You get transfer from: " + user.name);
                account.AddToLists(user.name, RealUser.name, date.GetDate(), moneyToReceive.ToString());
                RefreshLabels();
            }
            if (user1Clicked)
            {
                transfer.RunTransfer(user1Money, money, moneyToReceive);
                var x = MessageBox.Show("You get transfer from:" + user1.name);
                account.AddToLists(user1.name, RealUser.name, date.GetDate(), moneyToReceive.ToString());
                RefreshLabels();

            }
            if (user2Clicked)
            {
                transfer.RunTransfer(user2Money, money, moneyToReceive);
                var x = MessageBox.Show("You get transfer from: " + user2.name);
                account.AddToLists(user2.name, RealUser.name, date.GetDate(), moneyToReceive.ToString());
                RefreshLabels();

            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.Maximum = 9999999;
            numericUpDown2.Minimum = 1;
            SetValueToReceive(Convert.ToInt32(numericUpDown2.Value));
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label22_Click(object sender, EventArgs e)
        {
            
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }
        int iter = 0;

        public void ListsToTable()
        {
            label22.Text = label22.Text + "\n" + account.sender[iter];
            label23.Text = label23.Text + "\n" + account.receiver[iter];
            label24.Text = label24.Text + "\n" + account.date[iter];
            label25.Text = label25.Text + "\n" + account.amount[iter] +"$";
            iter++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            if (comboBox1.Text=="Car Loan")
            {
                CarLoan carLoan = new CarLoan(car, money);
                CarGUI carGUI = new CarGUI();
                carGUI.Show();
                carLoan.TakeLoan(money, Convert.ToInt32(numericUpDown3.Value));
                numericUpDown3.Refresh();
                account.AddToLists("BANK (Car Loan)", RealUser.name, date.GetDate(), numericUpDown3.Value.ToString());
                RefreshLabels();

            }

            if (comboBox1.Text == "Student Loan")
            {
                StudentLoan studentLoan = new StudentLoan(RealUser, money);
                account.AddToLists("BANK (Student Loan)", RealUser.name, date.GetDate(), numericUpDown3.Value.ToString());
                numericUpDown3.Refresh();
                studentLoan.TakeLoan(money, Convert.ToInt32(numericUpDown3.Value));
                RefreshLabels();


            }
            if (comboBox1.Text == "Mortgage")
            {
                HouseGUI houseGUI = new HouseGUI();
                houseGUI.Show();
                Mortgage mortgage = new Mortgage();
                mortgage.TakeLoan(money, Convert.ToInt32(numericUpDown3.Value));
                numericUpDown3.Refresh();
                account.AddToLists("BANK (Mortgage)", RealUser.name, date.GetDate(), numericUpDown3.Value.ToString());
                RefreshLabels();


            }

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown3.Maximum = Convert.ToInt32(money.amountOfMoney);
            numericUpDown3.Minimum = 1;
            SetValue(Convert.ToInt32(numericUpDown1.Value));
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
