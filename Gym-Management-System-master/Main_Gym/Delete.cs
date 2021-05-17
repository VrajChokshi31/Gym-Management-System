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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }
        
        private void btn_del_Click(object sender, EventArgs e)
        {

            System.Data.SqlClient.SqlConnection sqlConnection1 =
     new System.Data.SqlClient.SqlConnection(@"Server=localhost;Database=master;Trusted_Connection=True;");
            SqlCommand cmdd = new SqlCommand("select mentor from [Table] where ID='" + txt_delid.Text + "'", sqlConnection1);
            cmdd.Connection = sqlConnection1;

            sqlConnection1.Open();
            string s = cmdd.ExecuteScalar().ToString();
            sqlConnection1.Close();
            cmdd = new SqlCommand("select slot from [Table] where ID='" + txt_delid.Text + "'", sqlConnection1);
            cmdd.Connection = sqlConnection1;

            sqlConnection1.Open();
            string s1 = cmdd.ExecuteScalar().ToString();
            sqlConnection1.Close();
            cmdd = new SqlCommand("update dbo.mentortable set [slot " + Convert.ToInt32(s1) + "] = [slot " + Convert.ToInt32(s1) + "] - 1 where mentor='" + s + "'", sqlConnection1);
            cmdd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmdd.ExecuteNonQuery();
            sqlConnection1.Close();
            cmdd = new SqlCommand("update [Table] set active = 0 where ID='" + txt_delid.Text + "'", sqlConnection1);
            cmdd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmdd.ExecuteNonQuery();
            sqlConnection1.Close();
            
            MessageBox.Show("record deleted");

        }
    }
}
