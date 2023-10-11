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
    internal class Filter
    {
        public SqlConnection connection = new SqlConnection(ConnectionStr.dbString);
        SqlDataAdapter adapter;

        public void ClientIsks(DataGridView dataGrid)
        {
            connection.Open();
            DataTable dataTable = new DataTable();
            adapter = new SqlDataAdapter("SELECT c.ID_Client, c.LastName, c.Surname, COUNT(i.ID_isk) AS TotalIsks\r\nFROM Clients c\r\nLEFT JOIN isks i ON c.ID_Client = i.ID_Client\r\nGROUP BY c.ID_Client, c.LastName, c.Surname;", connection);
            adapter.Fill(dataTable);
            dataGrid.DataSource = dataTable;
            connection.Close();
        }

        public void CompanyPolises(DataGridView dataGrid)
        {
            connection.Open();
            DataTable dataTable = new DataTable();
            adapter = new SqlDataAdapter("SELECT cmp.ID_Company, cmp.Company_Name, COUNT(p.ID_Polis) AS TotalPolises\r\nFROM Companies cmp\r\nLEFT JOIN polises p ON cmp.ID_Company = p.ID_Company\r\nGROUP BY cmp.ID_Company, cmp.Company_Name;", connection);
            adapter.Fill(dataTable);
            dataGrid.DataSource = dataTable;
            connection.Close();
        }

        public void Isktypes(DataGridView dataGrid)
        {
            connection.Open();
            DataTable dataTable = new DataTable();
            adapter = new SqlDataAdapter("SELECT t.ID_Types, t.TypeName, COUNT(i.ID_isk) AS TotalIsks\r\nFROM types_of_str t\r\nLEFT JOIN isks i ON t.ID_Types = i.ID_Type\r\nGROUP BY t.ID_Types, t.TypeName;", connection);
            adapter.Fill(dataTable);
            dataGrid.DataSource = dataTable;
            connection.Close();
        }

        public void IskSum(DataGridView dataGrid)
        {
            connection.Open();
            DataTable dataTable = new DataTable();
            adapter = new SqlDataAdapter("SELECT c.ID_Client, c.LastName, c.Surname, SUM(i.Sum_of_isk) AS TotalSum, COUNT(i.ID_isk) AS TotalIsks\r\nFROM Clients c\r\nLEFT JOIN isks i ON c.ID_Client = i.ID_Client\r\nWHERE c.ID_Client = i.ID_Client\r\nGROUP BY c.ID_Client, c.LastName, c.Surname;", connection);
            adapter.Fill(dataTable);
            dataGrid.DataSource = dataTable;
            connection.Close();
        }

        public void CompanyIsks(DataGridView dataGrid)
        {
            connection.Open();
            DataTable dataTable = new DataTable();
            adapter = new SqlDataAdapter("SELECT cmp.ID_Company, cmp.Company_Name, SUM(i.Sum_of_isk) AS TotalSum\r\nFROM Companies cmp\r\nLEFT JOIN isks i ON cmp.ID_Company = i.ID_Company\r\nGROUP BY cmp.ID_Company, cmp.Company_Name;", connection);
            adapter.Fill(dataTable);
            dataGrid.DataSource = dataTable;
            connection.Close();
        }
        public void ClientIskType(DataGridView dataGrid, string TypeName)
        {
            connection.Open();
            DataTable dataTable = new DataTable();
            adapter = new SqlDataAdapter("SELECT c.ID_Client, c.LastName, c.Surname, COUNT(i.ID_isk) AS TotalIsks\r\nFROM Clients c\r\nJOIN isks i ON c.ID_Client = i.ID_Client\r\nJOIN types_of_str t ON i.ID_Type = t.ID_Types\r\nWHERE t.TypeName = '" + TypeName +"' \r\n GROUP BY c.ID_Client, c.LastName, c.Surname;", connection);
            adapter.Fill(dataTable);
            dataGrid.DataSource = dataTable;
            connection.Close();
        }

        public void ClientCompanyPolis(DataGridView dataGrid)
        {
            connection.Open();
            DataTable dataTable = new DataTable();
            adapter = new SqlDataAdapter("SELECT c.ID_Client, c.LastName, c.Surname, cmp.Company_Name FROM Clients c JOIN polises p ON c.ID_Client = p.ID_Client JOIN Companies cmp ON p.ID_Company = cmp.ID_Company; ", connection);
            adapter.Fill(dataTable);
            dataGrid.DataSource = dataTable;
            connection.Close();
        }
    }
}
