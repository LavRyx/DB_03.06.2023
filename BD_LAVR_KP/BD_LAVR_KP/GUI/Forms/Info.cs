using BD_LAVR_KP.GUI.GUI_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_LAVR_KP.GUI.Forms
{
    public partial class Info : Template
    {
        public Info()
        {
            InitializeComponent();
        }

        protected override void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
