using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui
{
    public partial class FormFamilies :Form
    {
        public FormFamilies()
        {
            InitializeComponent();
        }


        private void btnaddFamily_Click(object sender, EventArgs e)
        {
            paneladdFamily.Visible = true;


        }

        private void btnupdateFamily_Click(object sender, EventArgs e)
        {
            panelupdateFamily.Visible = true;
        }

        private void btnokaddFamily_Click(object sender, EventArgs e)
        {
            paneladdFamily.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelupdateFamily.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelupdateFamily.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnnotokFamily_Click(object sender, EventArgs e)
        {
            paneladdFamily.Visible = false;
        }

        private void labeltitelFamily_Click(object sender, EventArgs e)
        {

        }
    }
}
