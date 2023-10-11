using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_LAVR_KP.Main.Main_Classes
{
    internal class ChangeData : Interfaces.IChange
    {
        SqlCommand cmd;
        private SqlConnection connection = new SqlConnection(ConnectionStr.dbString);

        public void ChangeRow(string name, string adress, string director, string INN, string companyid)
        {
            if (name != "" && adress != "" && director != "" && INN != "" && companyid != "")
            {
                cmd = new SqlCommand("update companies set Company_name = @name, " +
                    "Adress = @adress, Director = @director, INN = @INN where ID_Company = @id", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@id", companyid);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@adress", adress);
                cmd.Parameters.AddWithValue("@director", director);
                cmd.Parameters.AddWithValue("@INN", INN);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Компания обновлена");
            }
            else
            {
                MessageBox.Show("Введите данные");
            }
        }

        public void ChangeRow(string Surname, string Lastname, string Adress, string Phone, string Email, string clientID)
        {
            if (Surname != "" && Lastname != "" && Adress != "" && Phone != "" && Email != "" && clientID != "")
            {
                cmd = new SqlCommand("update clients set Surname = @surname, " +
                    "Lastname = @lastname, Adress = @Adress, Phone = @phone, Email = @email where ID_Client = @clientID", connection);
                connection.Open();

                cmd.Parameters.AddWithValue("@id", clientID);
                cmd.Parameters.AddWithValue("@surname", Surname);
                cmd.Parameters.AddWithValue("@lastname", Lastname);
                cmd.Parameters.AddWithValue("@adress", Adress);
                cmd.Parameters.AddWithValue("@phone", Phone);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Клиент обновлен");
            }
            else
            {
                MessageBox.Show("Введите данные");
            }
        }

        public void ChangeRow(string Isk_num, string Date_of_Isk, string Sum_of_Isk, string ID_Polis, string ID_Client, string ID_Type, string ID_Company, string iskID)
        {
            if (Isk_num != "" && Date_of_Isk != "" && Sum_of_Isk != "" && ID_Polis != "" && ID_Type != "" && ID_Company != "" && iskID != "")
            {
                cmd = new SqlCommand("update isks set Isk_num = @isk_num, " +
                    "Date_of_Isk = @date_of_isk, Sum_of_Isk = @sum_of_isk, ID_Polis = @id_polis, ID_Client = @id_client, ID_Type = @id_type, Id_Company = @id_company where ID_Client = @clientID", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@isk_id", iskID);
                cmd.Parameters.AddWithValue("@isk_num", Isk_num);
                cmd.Parameters.AddWithValue("@date_of_isk", Date_of_Isk);
                cmd.Parameters.AddWithValue("@sum_of_isk", Sum_of_Isk);
                cmd.Parameters.AddWithValue("@id_polis", ID_Polis);
                cmd.Parameters.AddWithValue("@id_client", ID_Client);
                cmd.Parameters.AddWithValue("@id_type", ID_Type);
                cmd.Parameters.AddWithValue("@id_company", ID_Company);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Иск обновлен");
            }
            else
            {
                MessageBox.Show("Введите данные");
            }
        }

        public void ChangeRow(string ID_Client, string ID_Type, string ID_Company, string Number, string Date_of_Str, string Srok, string polisID)
        {
            if (ID_Client != "" && ID_Type != "" && ID_Company != "" && Number != "" && Date_of_Str != "" && Srok != "" && polisID != "")
            {
                cmd = new SqlCommand("update polises set Isk_num = @id_client, " +
                    "Date_of_Isk = @id_type, Sum_of_Isk = @id_company, ID_Polis = @number, ID_Client = @date_of_str, ID_Type = @srok where ID_Polis = @polisID", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@polis_ID", polisID);
                cmd.Parameters.AddWithValue("@id_client", ID_Client);
                cmd.Parameters.AddWithValue("@id_type", ID_Type);
                cmd.Parameters.AddWithValue("@id_company", ID_Company);
                cmd.Parameters.AddWithValue("@number", Number);
                cmd.Parameters.AddWithValue("@date_of_str", Date_of_Str);
                cmd.Parameters.AddWithValue("@srok", Srok);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Полис обновлен");
            }
            else
            {
                MessageBox.Show("Введите данные");
            }
        } 

        public void ChangeRow(string TypeName, string Tariff, string typeID)
        {
            if (TypeName != "" && Tariff != "" && typeID != "")
            {
                cmd = new SqlCommand("update types_of_str set TypeName = @typename, " +
                    "Tariff = @tariff where ID_types = @typeID", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@typeID", typeID);
                cmd.Parameters.AddWithValue("@typename", TypeName);
                cmd.Parameters.AddWithValue("@tariff", Tariff);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Тип страхования обновлен");
            }
            else
            {
                MessageBox.Show("Введите данные");
            }
        }
    }
}
