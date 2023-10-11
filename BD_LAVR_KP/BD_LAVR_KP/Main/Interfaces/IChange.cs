using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_LAVR_KP.Main.Interfaces
{
    internal interface IChange
    {
        void ChangeRow(string name, string adress, string director, string INN, string companyid);
        void ChangeRow(string Surname, string Lastname, string Adress, string Phone, string Email, string clientID);
        void ChangeRow(string Isk_num, string Date_of_Isk, string Sum_of_Isk, string ID_Polis, string ID_Client, string ID_Type, string ID_Company, string iskID);
        void ChangeRow(string ID_Client, string ID_Type, string ID_Company, string Number, string Date_of_Str, string Srok, string polisID);
        void ChangeRow(string TypeName, string Tariff, string typeID);
    }
}
