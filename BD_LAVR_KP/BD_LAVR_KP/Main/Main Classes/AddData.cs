using BD_LAVR_KP.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_LAVR_KP.Main.Main_Classes
{
    internal class AddData : IAdd
    {
        SqlCommand cmd;
        private SqlConnection connection = new SqlConnection(ConnectionStr.dbString);
        public void AddRow(string name, string adress, string director, string INN)
        {
            if (name != "" && adress != "" && director != "" && INN != "")
            {
                cmd = new SqlCommand("insert into companies (Company_Name, Adress, Director, INN) " +
                    "values(@name, @adress, @director, @INN)", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@adress", adress);
                cmd.Parameters.AddWithValue("@director", director);
                cmd.Parameters.AddWithValue("@INN", INN);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Компания добавлена");
            }
            else
            {
                MessageBox.Show("Введите данные");
            }
        }

        public void AddRow(string Surname, string Lastname, string Adress, string Phone, string Email)
        {
            if (Surname != "" && Lastname != "" && Adress != "" && Phone != "" && Email != "")
            {
                cmd = new SqlCommand("insert into clients (Surname, Lastname, Adress, Phone, Email) " +
                    "values(@surname, @lastname, @adress, @phone, @email)", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@surname", Surname);
                cmd.Parameters.AddWithValue("@lastname", Lastname);
                cmd.Parameters.AddWithValue("@adress", Adress);
                cmd.Parameters.AddWithValue("@phone", Phone);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Клиент добавлен");
            }
            else
            {
                MessageBox.Show("Введите данные");
            }
        }

        public void AddRow(string Isk_num, string Date_of_Isk, string Sum_of_Isk, string ID_Polis, string ID_Client, string ID_Type, string ID_Company)
        {
            if (Isk_num != "" && Date_of_Isk != "" && Sum_of_Isk != "" && ID_Polis != "" && ID_Type != "" && ID_Company != "")
            {
                cmd = new SqlCommand("insert into isks (Isk_num, Date_of_Isk, Sum_of_Isk, ID_Polis, ID_Client, ID_Type, ID_Company) " +
                    "values(@isk_num, @date_of_isk, @sum_of_isk, @id_polis, @id_client, @id_type, id_company)", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@isk_num", Isk_num);
                cmd.Parameters.AddWithValue("@date_of_isk", Date_of_Isk);
                cmd.Parameters.AddWithValue("@sum_of_isk", Sum_of_Isk);
                cmd.Parameters.AddWithValue("@id_polis", ID_Polis);
                cmd.Parameters.AddWithValue("@id_client", ID_Client);
                cmd.Parameters.AddWithValue("@id_type", ID_Type);
                cmd.Parameters.AddWithValue("@id_company", ID_Company);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Иск добавлен");
            }
            else
            {
                MessageBox.Show("Введите данные");
            }
        }

        public void AddRow(string ID_Client, string ID_Type, string ID_Company, string Number, string Date_of_Str, string Srok)
        {
            if (ID_Client != "" && ID_Type != "" && ID_Company != "" && Number != "" && Date_of_Str != "" && Srok != "")
            {
                cmd = new SqlCommand("insert into polises (ID_Client, ID_Type, ID_Company, Number, Date_Of_Str, Srok) " +
                    "values(@id_client, @id_type, @id_company, @number, @date_of_str, @srok)", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@id_client", ID_Client);
                cmd.Parameters.AddWithValue("@id_type", ID_Type);
                cmd.Parameters.AddWithValue("@id_company", ID_Company);
                cmd.Parameters.AddWithValue("@number", Number);
                cmd.Parameters.AddWithValue("@date_of_str", Date_of_Str);
                cmd.Parameters.AddWithValue("@srok", Srok);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Полис добавлен");
            }
            else
            {
                MessageBox.Show("Введите данные");
            }
        }

        public void AddRow(string TypeName, string Tariff)
        {
            if (TypeName != "" && Tariff != "")
            {
                cmd = new SqlCommand("insert into types_of_str (TypeName, Tariff) " +
                    "values(@typename, @tariff)", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@typename", TypeName);
                cmd.Parameters.AddWithValue("@tariff", Tariff);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Тип страхования добавлен");
            }
            else
            {
                MessageBox.Show("Введите данные");
            }
        }

    }
}
