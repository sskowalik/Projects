using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel.Design;

namespace WinFormsApp1
{
    public partial class BankApplication : Form
    {
        public BankApplication()
        {
            InitializeComponent();
            CreateLabel();
        }
        LoginData loginData = new LoginData();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public void CreateLabel()
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(label3, "Your Name is your login to bank app!");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (loginData.login_given ==null || loginData.password_given == null || loginData.CheckIfDataCorrect() == false || loginData.login_given.Length < 1  || loginData.password_given.Length <1)
            {
                var x = MessageBox.Show("Incorrect Login Data! If you didn't create your own account, do it now!");

         

            }
            else
            {
                var x = MessageBox.Show("Correct Login Data! \nWait a second...");
                Interface @interface = new Interface();
                @interface.ShowDialog();

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loginData.login_given= textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Register reg = new Register();
            reg.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            loginData.password_given = textBox2.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}