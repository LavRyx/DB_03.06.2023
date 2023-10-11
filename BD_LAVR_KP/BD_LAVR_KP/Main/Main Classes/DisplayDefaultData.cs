using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_LAVR_KP.Main.Main_Classes
{
    internal class DisplayDefaultData
    {
        private SqlConnection connection = new SqlConnection(ConnectionStr.dbString);
        private SqlDataAdapter adapter;
        private SqlCommand cmd;
        DataGridView dataGrid;
        public string selectedTable;



        public DisplayDefaultData(DataGridView dataGrid)
        {
            this.dataGrid = dataGrid;

        }

        public void DisplayData()
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select * from " + selectedTable, connection);
            adapter.Fill(dt);
            dataGrid.DataSource = dt;
            connection.Close();
        }

        public DataTable Types()
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select * from types_of_str", connection);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }





    }
}
