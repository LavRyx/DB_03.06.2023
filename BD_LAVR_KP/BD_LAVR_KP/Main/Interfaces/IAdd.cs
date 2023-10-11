using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_LAVR_KP.Main.Interfaces
{
    internal interface IAdd
    {

        void AddRow(string name, string adress, string director, string INN);
        void AddRow(string Surname, string Lastname, string Adress, string Phone, string Email);
        void AddRow(string Isk_num, string Date_of_Isk, string Sum_of_Isk, string ID_Polis, string ID_Client, string ID_Type, string ID_Company);
        void AddRow(string ID_Client, string ID_Type, string ID_Company, string Number, string Date_of_Str, string Srok);
        void AddRow(string TypeName, string Tariff);


    }
}
