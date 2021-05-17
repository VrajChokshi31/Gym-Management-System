using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Gym
{
    public partial class Registeration : Form
    {
        public Registeration()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_rej_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost;Database=master;Trusted_Connection=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            if (txt_name.Text != "" & txt_address.Text != "" & combo_gndr.Text != "" & txt_age.Text != "" & txt_phn.Text != "" )
            {
                int i = comboBox3.SelectedIndex + 1;
                int j = 0;
                SqlCommand CmdSql = new SqlCommand("select [slot " + i + "] as k from mentortable where Mentor = '" + comboBox1.Text + "' ", conn);
                conn.Open();
                SqlDataReader read = CmdSql.ExecuteReader();
                
                if(read.Read())
                     j = Convert.ToInt32(read["k"]);
                conn.Close();
                if(j>3)
                {
                    MessageBox.Show("slot already full");
                    return;

                }
                j++;
                
                CmdSql = new SqlCommand("update  mentortable set [slot " + i + "] = " + j + " where Mentor = '" + comboBox1.Text + "' ", conn);
                conn.Open();
                CmdSql.ExecuteNonQuery();
                conn.Close();
                CmdSql = new SqlCommand("select count(*) from [Table]",conn);
                conn.Open();
                int auto = 0;
                read = CmdSql.ExecuteReader();
                if (read.Read())
                {
                    auto = Convert.ToInt32(read.GetValue(0));
                }
                auto++;
                conn.Close();
                CmdSql = new SqlCommand("INSERT INTO [Table] (active,join_date,Name, Address, Gender, Age, Phone, ID, total_price, mentor,[plan]) VALUES (@active,@join_date, @Name, @Address, @Gender, @Age, @Phone, @ID, @price, @mentor, @plan)", conn);
                
                conn.Open();
                CmdSql.Parameters.AddWithValue("@Name", txt_name.Text);
                CmdSql.Parameters.AddWithValue("@Address", txt_address.Text);
                CmdSql.Parameters.AddWithValue("@Gender", combo_gndr.Text);
                CmdSql.Parameters.AddWithValue("@mentor", comboBox1.Text);
                CmdSql.Parameters.AddWithValue("@active", 1);
                //SqlDataAdapter da = new SqlDataAdapter(CmdSql);

                //if(rad_male.Checked == true)

                //{

                //CmdSql.Parameters.AddWithValue("@Gender", rad_male.Text.ToString());

                //rad_fem.Checked = false;

                //CmdSql.ExecuteNonQuery();
                //}

                //else if (rad_fem.Checked == true)

                //{

                //    CmdSql.Parameters.AddWithValue("@Gender", rad_fem.Text.ToString());

                //    rad_male.Checked = false;

                //    CmdSql.ExecuteNonQuery();

                //}
                int p = 0;
                if(comboBox2.SelectedIndex == 0)
                {
                    p = 5000;
                    CmdSql.Parameters.AddWithValue("@price", "5000");
                }
                else if(comboBox2.SelectedIndex == 1)
                {
                    p = 1000;
                    CmdSql.Parameters.AddWithValue("@price", "1000");
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    p = 500;
                    CmdSql.Parameters.AddWithValue("@price", "500");
                }
                else if (comboBox2.SelectedIndex == 3)
                {
                    p = 100;
                    CmdSql.Parameters.AddWithValue("@price", "100");
                }
               
                try
                {
                    Convert.ToInt64(txt_phn.Text);
                    if(txt_phn.Text.Length != 10)
                    {
                        MessageBox.Show("Please enter valid phone number");
                        conn.Close();
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter valid phone number");
                    conn.Close();
                    return;
                }
                try
                {
                    Convert.ToInt32(txt_age.Text);
                    if (Convert.ToInt32(txt_age.Text) < 18 || Convert.ToInt32(txt_age.Text) > 65)
                    {
                        MessageBox.Show("Please enter valid age");
                        conn.Close();
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter valid age");
                    conn.Close();
                    return;
                }
                CmdSql.Parameters.AddWithValue("@plan", comboBox2.Text);
                CmdSql.Parameters.AddWithValue("@Age", txt_age.Text);
                CmdSql.Parameters.AddWithValue("@Phone", txt_phn.Text);
                CmdSql.Parameters.AddWithValue("@ID",auto);
                CmdSql.Parameters.AddWithValue("@join_date",DateTime.Now);
                CmdSql.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Registration Successfull\nSubscription Fees: "+p);
                
            }
            else { MessageBox.Show("please enter all the values"); }
            
        }

        private void radiobox_Enter(object sender, EventArgs e)
        {
           
        }
        
    }
}
