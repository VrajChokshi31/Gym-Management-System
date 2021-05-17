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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            string connectionString = @"Server=localhost;Database=master;Trusted_Connection=True;";
            SqlConnection conn = new SqlConnection(connectionString);
         
            SqlCommand CmdSql = new SqlCommand("UPDATE [Table] set active=0 WHERE DATEDIFF(day, GETDATE(), join_date) > (select days from dbo.plantable where [plan] = [Table].[plan])", conn);
            conn.Open();
            CmdSql.ExecuteNonQuery();
            conn.Close();

        }
        Search srch = new Search();
        Registeration Register = new Registeration();
        Fees pay = new Fees();
        Delete del = new Delete();

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.gymDataSet.Table);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Main_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            this.Hide();           //Hide the main form before showing the secondary
            Register.ShowDialog();     //Show secondary form, code execution stop until frm2 is closed
            this.Show();
        }

        private void btn_scrh_Click(object sender, EventArgs e)
        {
            this.Hide();           //Hide the main form before showing the secondary
            srch.ShowDialog();     //Show secondary form, code execution stop until frm2 is closed
            this.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programe ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();           //Hide the main form before showing the secondary
            pay.ShowDialog();     //Show secondary form, code execution stop until frm2 is closed
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();           //Hide the main form before showing the secondary
            del.ShowDialog();     //Show secondary form, code execution stop until frm2 is closed
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            equip ep = new equip();
            ep.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
          //  Form3 f3 = new Form3();
          //  f3.ShowDialog();
        }
    }
}
