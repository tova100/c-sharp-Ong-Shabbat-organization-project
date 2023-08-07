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
    public partial class VolonteerForm : Form
    {
        public VolonteerForm()
        {
            InitializeComponent();
        }

        private void buttondivres_Click(object sender, EventArgs e)
        {
            DriversForm driver = new DriversForm();
            driver.Show();
        }

        private void buttoncook_Click(object sender, EventArgs e)
        {
            CookerFrom cookerFrom = new CookerFrom();
            cookerFrom.Show();
        }
    }
}
