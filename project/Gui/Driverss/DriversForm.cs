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
    public partial class DriversForm : Form
    {
        public DriversForm()
        {
            InitializeComponent();
        }

        private void btnaddDrivers_Click(object sender, EventArgs e)
        {
            panelAddDrivers.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void DriversForm_Load(object sender, EventArgs e)
        {

        }

        private void btnokaddDrivers_Click(object sender, EventArgs e)
        {
            panelAddDrivers.Visible = false;
        }

        private void btnotokDrivers_Click(object sender, EventArgs e)
        {
            panelAddDrivers.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
