using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Gym
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Main abc = new Main();
        string username = "admin";

        string password = "pass";

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (txt_username.Text.Equals(username) && txt_pass.Text.Equals(password))
            {
                this.Hide();           //Hide the main form before showing the secondary
                abc.ShowDialog();     //Show secondary form, code execution stop until frm2 is closed
            }

            else
            {

                MessageBox.Show("Sorry, those details are incorrect.");

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
