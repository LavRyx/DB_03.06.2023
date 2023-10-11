using BD_LAVR_KP.GUI.GUI_Classes;
using BD_LAVR_KP.Main.Main_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_LAVR_KP.GUI.Forms
{
    public partial class MainForm : Template
    {
        DisplayDefaultData display;
        AddData add = new AddData();
        ChangeData change = new ChangeData();
        DeleteData delData = new DeleteData();
        Filter filter = new Filter();
        ReportService report = new ReportService();
        public MainForm()
        {
            InitializeComponent();
            

        }

        protected override void button_Close_Click(object sender, EventArgs e)
        {
            animationComponent2.CloseForm(2000);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            animationComponent1.ShowForm(1000);
            display = new DisplayDefaultData(dataGridView);
            display.selectedTable = SelectedTable(0);
            display.DisplayData();


            DataTable load = display.Types();
            foreach (DataRow row in load.Rows)
            {
                comboBox_types.Items.Add(row["TypeName"].ToString());
            }
        }


        


        private void customTabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage page = customTabControl1.TabPages[e.Index];
            Color col = e.Index == 0 ? Color.Lavender : Color.Lavender;
            e.Graphics.FillRectangle(new SolidBrush(col), e.Bounds);

            Rectangle paddedBounds = e.Bounds;
            int yOffset = (e.State == DrawItemState.Selected) ? -2 : 1;
            paddedBounds.Offset(1, yOffset);
            TextRenderer.DrawText(e.Graphics, page.Text, Font, paddedBounds, page.ForeColor);
        }

        private void customTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(customTabControl1.SelectedIndex != 5)
            {
                display.selectedTable = SelectedTable(customTabControl1.SelectedIndex);
                display.DisplayData();
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            }
            
        }


        private void button_AddClient_Click(object sender, EventArgs e)
        {
            add.AddRow(textBox_Surname.Text, textBox_LastName.Text, textBox_Adress.Text, textBox_Phone.Text, textBox_Email.Text);
            display.selectedTable = SelectedTable(0);
            display.DisplayData();

        }
        private void button_CompanyAdd_Click(object sender, EventArgs e)
        {
            add.AddRow(textBox_CompanyName.Text, textBox_CompanyAdress.Text, textBox_CompanyDirector.Text, textBox_CompanyINN.Text);
            display.selectedTable = SelectedTable(1);
            display.DisplayData();
        }
        private void button_TypesAdd_Click(object sender, EventArgs e)
        {
            add.AddRow(textBox_TypesType.Text, textBox_TypesTariff.Text);
            display.selectedTable = SelectedTable(2);
            display.DisplayData();

        }
        private void button_IskAdd_Click(object sender, EventArgs e)
        {
            add.AddRow(textBox_IskNumber.Text, textBox_IskDate.Text, textBox_IskSum.Text,
                textBox_IskPolis.Text, textBox_IskClient.Text, textBox_IskType.Text, textBox_IskCompany.Text);
            display.selectedTable = SelectedTable(3);
            display.DisplayData();
        }
        private void button_PoliseAdd_Click(object sender, EventArgs e)
        {
            add.AddRow(textBox_PoliseClient.Text, textBox_PoliseType.Text, textBox_PoliseCompany.Text,
                textBox_PoliseNumber.Text, textBox_PoliseDate.Text, textBox_PoliseSrok.Text);
            display.selectedTable = SelectedTable(4);
            display.DisplayData();
        }




        private void button_ChangeClient_Click(object sender, EventArgs e)
        {
            change.ChangeRow(textBox_CompanyName.Text, textBox_CompanyAdress.Text, textBox_CompanyDirector.Text, textBox_CompanyINN.Text, dataGridView.CurrentRow.Cells[0].Value.ToString());
            display.selectedTable = SelectedTable(0);
            display.DisplayData();
        }
        private void button_CompanyChange_Click(object sender, EventArgs e)
        {
            change.ChangeRow(textBox_CompanyName.Text, textBox_CompanyAdress.Text, textBox_CompanyDirector.Text, textBox_CompanyINN.Text, dataGridView.CurrentRow.Cells[0].Value.ToString());
            display.selectedTable = SelectedTable(1);
            display.DisplayData();
        }

        private void button_TypesChange_Click(object sender, EventArgs e)
        {
            change.ChangeRow(textBox_TypesType.Text, textBox_TypesTariff.Text, dataGridView.CurrentRow.Cells[0].Value.ToString());
            display.selectedTable = SelectedTable(2);
            display.DisplayData();
        }
        private void button_IskChange_Click(object sender, EventArgs e)
        {
            change.ChangeRow(textBox_IskNumber.Text, textBox_IskDate.Text, textBox_IskSum.Text,
                textBox_IskPolis.Text, textBox_IskClient.Text, textBox_IskType.Text, textBox_IskCompany.Text, dataGridView.CurrentRow.Cells[0].Value.ToString());
            display.selectedTable = SelectedTable(3);
            display.DisplayData();
        }
        private void button_PoliseChange_Click(object sender, EventArgs e)
        {
            change.ChangeRow(textBox_PoliseClient.Text, textBox_PoliseType.Text, textBox_PoliseCompany.Text,
                textBox_PoliseNumber.Text, textBox_PoliseDate.Text, textBox_PoliseSrok.Text, dataGridView.CurrentRow.Cells[0].Value.ToString());
            display.selectedTable = SelectedTable(4);
            display.DisplayData();
        }



        public string SelectedTable(int selectedPage)
        {
            switch (selectedPage)
            {
                case 0: return "clients";
                case 1: return "companies";
                case 2: return "types_of_str";
                case 3: return "isks";
                case 4: return "polises";
            }
            return "0";
        }





        private void button_DeleteClient_Click(object sender, EventArgs e)
        {
            delData.DelData(dataGridView.CurrentRow.Cells[0].Value.ToString(), "clients");
            display.selectedTable = SelectedTable(0);
            display.DisplayData();
        }

        private void button_CompanyDelete_Click(object sender, EventArgs e)
        {
            delData.DelData(dataGridView.CurrentRow.Cells[0].Value.ToString(), "companies");
            display.selectedTable = SelectedTable(1);
            display.DisplayData();
        }

        private void button_TypesDelete_Click(object sender, EventArgs e)
        {
            delData.DelData(dataGridView.CurrentRow.Cells[0].Value.ToString(), "types_of_str");
            display.selectedTable = SelectedTable(2);
            display.DisplayData();
        }

        private void buttin_IskDelete_Click(object sender, EventArgs e)
        {
            delData.DelData(dataGridView.CurrentRow.Cells[0].Value.ToString(), "isks");
            display.selectedTable = SelectedTable(3);
            display.DisplayData();
        }

        private void button_PoliseDelete_Click(object sender, EventArgs e)
        {
            delData.DelData(dataGridView.CurrentRow.Cells[0].Value.ToString(), "polises");
            display.selectedTable = SelectedTable(4);
            display.DisplayData();
        }





        private void button_IskClient_Click(object sender, EventArgs e)
        {
            filter.ClientIsks(dataGridView);
        }

        private void button_PolisCompany_Click(object sender, EventArgs e)
        {
            filter.CompanyPolises(dataGridView);
        }

        private void button_TypeIsk_Click(object sender, EventArgs e)
        {
            filter.Isktypes(dataGridView);
        }

        private void button_SumIsk_Click(object sender, EventArgs e)
        {
            filter.IskSum(dataGridView);
        }

        private void button_IskCompany_Click(object sender, EventArgs e)
        {
            filter.CompanyIsks(dataGridView);
        }

        private void button_IskType_Click(object sender, EventArgs e)
        {
            filter.ClientIskType(dataGridView, comboBox_types.Text);
        }

        private void button_ClientsCompaniesPolis_Click(object sender, EventArgs e)
        {
            filter.ClientCompanyPolis(dataGridView);
        }




        private void button_Excel_Click(object sender, EventArgs e)
        {
            report.ExportExcel(dataGridView);
        }
        private void buttonWord_Click(object sender, EventArgs e)
        {
            report.ExportWord(dataGridView);
        }
    }

        

        
    
}
