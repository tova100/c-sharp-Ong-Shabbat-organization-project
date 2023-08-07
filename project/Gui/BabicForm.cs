using Bll;
using Dto;
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
    public partial class basicForm : Form
    {
        public basicForm()
        {
            InitializeComponent();
        }

        private void BabicForm_Load(object sender, EventArgs e)
        {
           // CookereBll.Addc(new CookereDto() {})
        }

        private void ניהולמשפחותToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormFamilies FormFamilies = new FormFamilies();
            FormFamilies.Show();
        }

        private void ניהולמתנדביםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VolonteerForm volanteer = new VolonteerForm();
            volanteer.Show();

        }
      
       

        private void menuStripbase_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
                FormHome formHome=new FormHome();
                     formHome.Show();    
        }

     

        private void תרומותToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
             FormDonors FormDonors = new FormDonors();
            FormDonors.Show();
        }

        private void ניהולנהגיםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DriversForm driversForm = new DriversForm();
            driversForm.Show();
        }
    }
}
