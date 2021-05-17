using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main_Gym
{
    class MySqlDataAdapter
    {
        public System.Data.SqlClient.SqlCommand SelectCommand { get; set; }

        internal void Fill(System.Data.DataTable dbdataset)
        {
            throw new NotImplementedException();
        }

        internal void Update(System.Data.DataTable dbdataset)
        {
            throw new NotImplementedException();
        }
    }
}
