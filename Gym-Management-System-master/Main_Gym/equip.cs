using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Gym
{
    public partial class equip : Form
    {
        public equip()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
            string connectionString = @"Server=localhost;Database=master;Trusted_Connection=True;";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            string tvt = null;
            string commandString = "Select equiprice from [Table] where ID='" + textBox1.Text + "'";
            SqlCommand sqlCmd = new SqlCommand(commandString, sqlCon);
            SqlDataReader read = sqlCmd.ExecuteReader();
            int p = 0;
            
            
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter a ID Please");
                return;
            }
           
            if (read.Read() && !read.IsDBNull(0))
            {
                p = Convert.ToInt32(read.GetValue(0));
            }
            else
            {
                p = 0;
            }

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    p += 100;
                    MessageBox.Show("Total Price : " + p,"Receipt",MessageBoxButtons.OK);
                    break;
                case 1:p += 200;
                    MessageBox.Show("Total Price : " + p, "Receipt", MessageBoxButtons.OK);
                    break;
                case 2:
                    p += 300;
                    MessageBox.Show("Total Price : " + p, "Receipt", MessageBoxButtons.OK);
                    break;
                case 3:
                    p += 400;
                    MessageBox.Show("Total Price : " + p, "Receipt", MessageBoxButtons.OK);
                    break;
                default:
                    MessageBox.Show("please enter correct value");
                    break;
        
            }
            sqlCon.Close();
            sqlCon.Open();
            commandString = "update [Table] set equiprice = " + p + "where ID='" + textBox1.Text + "'";
            sqlCmd = new SqlCommand(commandString, sqlCon);
            int f = sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            sqlCon.Open();
            commandString = "update [Table] set equipments = '" + comboBox1.Text + "' where ID='" + textBox1.Text + "'";
            sqlCmd = new SqlCommand(commandString, sqlCon);
            f = sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            if (f == 0)
            {
                Console.WriteLine("f = " + f);
            }
          

        }
    }
}
