using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_LAVR_KP.Main.Main_Classes
{
    internal class DeleteData
    {
        SqlCommand cmd;
        private SqlConnection connection = new SqlConnection(ConnectionStr.dbString);

        string ID_name(string table)
        {
            if (table == "companies") return "ID_Company";
            if (table == "clients") return "ID_Client";
            if (table == "isks") return "ID_Isk";
            if (table == "polises") return "ID_Polis";
            if (table == "types_of_str") return "ID_types";
            return "0";
        }
        public void DelData(string id, string table)
        {
            if (id != "")
            {
                cmd = new SqlCommand("delete from " + table + " where " + ID_name(table) + " = @id", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Запись удалена");
            }
            else
            {
                MessageBox.Show("Не выбрана запись");
            }
        }
    }
}
