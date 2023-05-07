using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class HouseGUI : Form
    {
        public HouseGUI()
        {
            InitializeComponent();
        }
        House house= new House();

        public House returnHouse()
        {
            house.price= Convert.ToInt32(textBox1.Text);
            house.buildingPlotWidth = Convert.ToInt32(textBox2.Text);
            house.buildingPlotLength = Convert.ToInt32(textBox3.Text);
            house.BuildingPermitNumber = textBox4.Text;

            return house;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            returnHouse();
            if (textBox1.Text != "" && textBox2.Text !="" && textBox3.Text != "" && textBox4.Text != "")
            {
                var x = MessageBox.Show("House parameters:\nPrice: " + house.price + " " + +house.buildingPlotWidth + " x " + house.buildingPlotLength + "\n" + house.BuildingPermitNumber);
                Close();
            }
            else { var x = MessageBox.Show("You have to fill all data!"); }
        }
    }
}
