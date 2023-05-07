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
    public partial class CarGUI : Form
    {
        public CarGUI()
        {
            InitializeComponent();
        }
        Car car = new Car();

        public Car returnCar()
        {
            car.price = textBox1.Text;
            car.carDealer = textBox2.Text;
            car.typeOfEngine= textBox3.Text;
            car.kmDriven = textBox4.Text;
            car.color = textBox5.Text;
            car.model = textBox5.Text;
            return car;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void CarGUI_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            returnCar();
            if (car.CheckIfFilled()) 
            {
                var x = MessageBox.Show("Car choosen:\nPrice: " + car.price + " " + car.typeOfEngine + "\nCar Dealer: " + car.carDealer + "\nKM: " + car.kmDriven + "\n" + car.model + " " + car.color);
                Close();
            }
            else { var x = MessageBox.Show("You have to fill all data!"); }
            
        }
        
    }
}
