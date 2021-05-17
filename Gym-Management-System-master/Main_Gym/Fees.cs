using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Main_Gym
{
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }

        private void btn_fee_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost;Database=master;Trusted_Connection=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            string month = comboBox_fee.Text;
                        SqlCommand CmdSql = new SqlCommand("UPDATE [Table] set [plan]='" + comboBox_fee.Text + "' WHERE Id='" + txt_feeid.Text + "'", conn);
                        conn.Open();
                        CmdSql.ExecuteNonQuery();
                        conn.Close();
            int p = 0;
            if (comboBox_fee.SelectedIndex == 0)
            {
                p = 5000;
                
            }
            else if (comboBox_fee.SelectedIndex == 1)
            {
                p = 1000;
                
            }
            else if (comboBox_fee.SelectedIndex == 2)
            {
                p = 500;
                
            }
            else if (comboBox_fee.SelectedIndex == 3)
            {
                p = 100;
                
            }
            CmdSql = new SqlCommand("UPDATE [Table] set total_price='" + p + "' WHERE Id='" + txt_feeid.Text + "'", conn);
            conn.Open();
            CmdSql.ExecuteNonQuery();
            conn.Close();
            CmdSql = new SqlCommand("UPDATE [Table] set join_date=str_to_date('" + DateTime.Now.ToString("dd/MM/yyyy") + "','%d/%m/%Y') WHERE Id='" + txt_feeid.Text + "'", conn);
            conn.Open();
            CmdSql.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(" Plan changed ", month, MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM [Table]";

            SqlConnection sqlConn = new SqlConnection(@"Server=localhost;Database=master;Trusted_Connection=True;");
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand(query, sqlConn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sqlConn.Close();
            
            //dataGridView1.DataSource = dt.DefaultView;

        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
