using BD_LAVR_KP.GUI.GUI_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using BD_LAVR_KP.Main.Main_Classes;

namespace BD_LAVR_KP.GUI.Forms
{
    public partial class LoginForm : BD_LAVR_KP.Template
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            animationComponent1.ShowForm(1000);
            textBox_ServerName.Text = "26.54.31.38, 33678";
            textBox_DBname.Text = "KP_DB_Lavr";
        }

        protected override void button_Close_Click(object sender, EventArgs e)
        {
            animationComponent1.CloseForm(2000);
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            if(textBox_ServerName.Text == "" || textBox_DBname.Text == "" || textBox_Login.Text == ""  || textBox_Password.Text == "")
                MessageBox.Show("Ошибка! Проверте данные авторизации!");
            else
            {
                try
                {
                    ConnectionStr.dbString = "Data Source= " + textBox_ServerName.Text + "; Initial Catalog= " + textBox_DBname.Text
                    + "; User ID = " + textBox_Login.Text + "; Password = " + textBox_Password.Text + ";";

                    Thread myThread1 = new Thread(openNewForm);
                    myThread1.Start();
                    Thread.Sleep(1300);
                    this.Hide();
                }

                catch
                {
                    MessageBox.Show("Ошибка! Проверте данные авторизации!");
                }
            }
            
            
        }

        private void openNewForm()
        {
            
            MainForm form = new MainForm();
            form.ShowDialog();
        }


    }
}
