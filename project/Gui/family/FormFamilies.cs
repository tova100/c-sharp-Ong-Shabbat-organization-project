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

    public partial class FormFamilies : Form
    {
     
        public FormState state;
        private List<FamilyDto> family = FamilyBll.GetAll();

        public FormFamilies()
        {
            InitializeComponent();
            dataGridView1family.DataSource = FamilyBll.GetAll().Select(x => new { x.FamilyName,
                x.Familyid,
                x.Street, x.Phone, x.CityId, 
                newcity = CityBll.searhcById(Convert.ToInt32(x.CityId)).Name,
                x.Apartment_number,
                x.KashroutId,
               newcashrot = KashrutBll.searhcByIdKashrout(x.KashroutId).Name,
                 x.NumberOfPeople, x.CookerId,
               newcook=CookereBll.searhcByIdCooker(x.CookerId).FullName
            }).ToList();
            



        }
        public void ClearPakadim()
        {
            textBox1numapar.Text = null;
            textBoxfullnameFamilyadd.Text = null;
            textBoxidFamily.Text = null;
            textBoxphonaddFam.Text= null; 
            comboBox1city.SelectedIndex = -1;    
            comboBox2cashrut.SelectedIndex = -1;
            numchildren.Value = 0;
            textBoxadresaddFam.Text = null;
            btnCooker.Text = "בחירת מבשלת";

        }

        private void btnaddFamily_Click(object sender, EventArgs e)
        {
            state = FormState.Add;

            paneladdFamily.Visible = true;


        }

        private void btnupdateFamily_Click(object sender, EventArgs e)
        {
            state = FormState.Update;

            paneladdFamily.Visible = false;


            if (dataGridView1family.SelectedRows.Count <= 0)
            {
                MessageBox.Show("בחר לקוח ");
            }

            else
            {

                {
                    state = FormState.Update;
                    paneladdFamily.Visible = true;

                    FamilyDto f = RowToObject(dataGridView1family.SelectedRows[0]);

                    ObjectToForm(f);

                }

            }
        }

        private void ObjectToForm(FamilyDto f)
        {
            textBoxfullnameFamilyadd.Text = f.FamilyName;
            textBox1numapar.Text = f.Apartment_number;
            comboBox1city.SelectedValue = f.CityId;
            textBoxphonaddFam.Text = f.Phone;
            textBoxadresaddFam.Text = f.Street;
            numchildren.Value = f.NumberOfPeople.Value;
            comboBox2cashrut.SelectedValue = f.KashroutId;
            textBoxidFamily.Text = f.Familyid.ToString();
        }

        private void btnokaddFamily_Click(object sender, EventArgs e)
        {
            FamilyDto f = FormToObject(out bool hasErrors);
            if (!hasErrors)
            {
                if (state == FormState.Add)
                {
                    FamilyBll.Add(f);
                   
                    MessageBox.Show("הנתונים נקלטו בהצלחה", "קליטת נתונים");
                    dataGridView1family.DataSource = FamilyBll.GetAll();
                    paneladdFamily.Visible = false;
                }
                else
                {
                    FamilyBll.update(f);
                   
                    MessageBox.Show("הנתונים נקלטו בהצלחה", "קליטת נתונים");
                    dataGridView1family.DataSource = FamilyBll.GetAll();
                    paneladdFamily.Visible = false;
                }
            }
            ClearPakadim();
            dataGridView1family.Show();
          
        }

        private FamilyDto FormToObject(out bool hasErrors)
        {
            FamilyDto f = new FamilyDto();
            hasErrors = false;
            errorProvider1.Clear();

            if (state == FormState.Update)
                f.Familyid = Convert.ToInt32(textBoxidFamily.Text);
            //object namecity = comboBox1city.SelectedValue;
            //להחליף את העיר בגלל שהיא מחרוזת ובדאל צריך שזה יהיה בקוד זה ההמרה וכן כדי שיהיה גישה טובה למשתמש להקיש את העיר באמת 
            //CityDto city = CityBll.GetAll().FirstOrDefault(item => namecity.ToString() == item.Name.ToString());
            // object namekashrut = comboBox2cashrut.SelectedValue;
            //להחליף את העיר בגלל שהיא מחרוזת ובדאל צריך שזה יהיה בקוד זה ההמרה וכן כדי שיהיה גישה טובה למשתמש להקיש את העיר באמת 
            //KashrutDto c = KashrutBll.GetAll().FirstOrDefault(item => namekashrut.ToString() == item.Name.ToString());
            //כשרות

            f.KashroutId = (int)comboBox2cashrut.SelectedValue;

            //עיר

            f.CityId = (int)comboBox1city.SelectedValue;

            //מס דירה
            try
            {
                f.Apartment_number = textBox1numapar.Text;
            }
            catch (Exception ex)
            {
                hasErrors = true;
                errorProvider1.SetError(textBox1numapar, ex.Message);
            }
            //שם משפחה
            try
            {
                f.FamilyName = textBoxfullnameFamilyadd.Text;
            }
            catch (Exception ex)
            {
                hasErrors = true;
                errorProvider1.SetError(textBoxfullnameFamilyadd, ex.Message);
            }
            //פלאפון
            try
            {
                f.Phone = textBoxphonaddFam.Text;
            }
            catch (Exception ex)
            {
                hasErrors = true;
                errorProvider1.SetError(textBoxphonaddFam, ex.Message);
            }
            //כתובת
            try
            {
                f.Street = textBoxadresaddFam.Text;
            }
            catch (Exception ex)
            {
                hasErrors = true;
                errorProvider1.SetError(textBoxadresaddFam, ex.Message);
            }
            //מס נפשות
            try
            {
                f.NumberOfPeople = (int?)numchildren.Value;
            }
            catch (Exception ex)
            {
                hasErrors = true;
                errorProvider1.SetError(numchildren, ex.Message);
            }
            //try
            //{
            //    if (CookereBll.GetAll().FirstOrDefault(x => x.Street == f.Street && x.CityId == f.CityId && x.KashroutId == f.KashroutId) != null)
            //        f.CookerId = CookereBll.GetAll().FirstOrDefault(x => x.Street == f.Street && x.CityId == f.CityId && x.KashroutId == f.KashroutId).CookerId;
            //    else
            //        throw new Exception("אין מבשלת  מתאימה לבקשתך  ");
            //}
            //catch (Exception ex)
            //{

            //    errorProvider1.SetError(comboBox1city, ex.Message);
            //    hasErrors = true;
            //}
            //קוד מבשלת
            try { 
            if (btnCooker.Text != "בחירת מבשלת")
                f.CookerId = btnCooker.Text;

        }
            catch (Exception ex)
            {

                errorProvider1.SetError(btnCooker, ex.Message);
                hasErrors = true;
            }
            
            return f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            paneladdFamily.Visible = false;
            FamilyDto f = new FamilyDto()
            {

                FamilyName = textBoxfullnameFamilyadd.Text,
                Phone = textBoxphonaddFam.Text,
                CookerId = comboBox2cashrut.Text,
                Street = textBoxadresaddFam.Text,
                NumberOfPeople = numchildren.TabIndex,
                //KashroutId = comboBox2cashrut.TabIndex,
                Familyid = comboBox2cashrut.TabIndex,
            };


            FamilyBll.update(f);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paneladdFamily.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnnotokFamily_Click(object sender, EventArgs e)
        {
            paneladdFamily.Visible = false;
            ClearPakadim();


        }

        private void labeltitelFamily_Click(object sender, EventArgs e)
        {

        }

        //private void btnsearch_Click(object sender, EventArgs e)
        //{
        //    dataGridView1family.DataSource = FamilyBll.GetAll().Where(p => p.Phone.StartsWith(textBoxphonFamily.Text)).ToList();
        //}

        private void FormFamilies_Load(object sender, EventArgs e)
        {
            // int newfamilyid = -1;

        //    dataGridView1.DataSource = FamilyBll.GetAll();
            RefreshCitiesComboBox();

            RefreshKashrutComboBox();

        }

        private void RefreshKashrutComboBox()
        {
            comboBox2cashrut.DataSource = KashrutBll.GetAll();
            comboBox2cashrut.DisplayMember = "Name";
            comboBox2cashrut.ValueMember = "KashroutId";
        }

        private void RefreshCitiesComboBox()
        {
            comboBox1city.DataSource = CityBll.GetAll();
            comboBox1city.DisplayMember = "Name";
            comboBox1city.ValueMember = "CitiesId";
        }

        private void listViewFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        //private void paneladdFamily_Paint(object sender, PaintEventArgs e)
        //{

        //}


        private void numchildren_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1numapar_TextChanged(object sender, EventArgs e)
        {

        }

        //private void button2_Click_1(object sender, EventArgs e)
        //{
        //    dataGridView1family.DataSource = FamilyBll.GetAll().Where(p => p.FamilyName.StartsWith(searchFamilyname.Text)).ToList();
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            panelsearchfamaly.Visible = false;
        }

        //private void btndeleteFamily_Click(object sender, EventArgs e)
        //{
        //    FamilyDto f = new FamilyDto();

        //    FamilyBll.delete(f.Familyid);
        //}

        //help
        private FamilyDto RowToObject(DataGridViewRow row)
        {
            //row - מכיל את כל שורה שנלחצה

            return new FamilyDto()
            {

                FamilyName = row.Cells["Colnamefamily"].Value.ToString(),
                NumberOfPeople = (int)row.Cells["Colnumpeople"].Value,
                KashroutId = (int)row.Cells["Colkashrut"].Value,
                CityId = (int)row.Cells["Colcity"].Value,
                Apartment_number = row.Cells["Colapartment"].Value.ToString(),
                Phone = row.Cells["colPhone"].Value.ToString(),
                Street = row.Cells["Colstreet"].Value.ToString(),
                Familyid = (int)row.Cells["Colidfamily"].Value,
            };
        }

        private void btndeleteFamily_Click(object sender, EventArgs e)
        {

            if (dataGridView1family.SelectedRows.Count == 0)
                MessageBox.Show("בחר לקוח למחיקה");
            else
            {
                if (MessageBox.Show(" ?האם ברצונך למחוק לקוח זה", "אישור מחיקה",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                {
                    FamilyDto f = RowToObject(dataGridView1family.SelectedRows[0]);
                    FamilyBll.Delete(f);
                    RefreshProductsList();
                }
            }
        }
        //פונקציה שמרעננת את הנתונים 
        private void RefreshProductsList()
        {
            family = FamilyBll.GetAll();
            dataGridView1family.DataSource = family;
        }


        private void button4searsch_Click(object sender, EventArgs e)
        {
            panelsearchfamaly.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1cashrut.Visible = true;
        }

        private void buttonsearchcook_Click(object sender, EventArgs e)
        {
            KashrutDto k = new KashrutDto();
            { 
            try   
            {
                k.Name = cashrut.Text;

            }
            catch
            {
                MessageBox.Show("רק אותיות עברית");
                    this.Close();
                    
            }
          }  
            KashrutBll.Addc(k);
            RefreshKashrutComboBox();

            MessageBox.Show("הנתונים נקלטו בהצלחה", "קליטת נתונים");
            panel1cashrut.Visible = false;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridViewcook.Visible = true;
            
           
                try
            {
                if (comboBox1city.SelectedValue != null && comboBox2cashrut.SelectedValue!=null)
                    dataGridViewcook.DataSource = CookereBll.GetByCityAndKashrout((int)comboBox1city.SelectedValue, ((int)comboBox2cashrut.SelectedValue));
                if (dataGridViewcook.SelectedRows.Count == 0)
                    MessageBox.Show(" בחר מבשלת  ");

                //.Select(x => new { x.DriverId, x.Lastname, x.Firstname, x.Phone, x.CityId, שם_עיר = CityBll.searhcById(x.CityId).Name }).ToList();
            }
            catch
            {
                MessageBox.Show(" בחרי עיר וכן כשרות ");
            }
        }

        

        private void dataGridViewcook_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewcook.SelectedRows.Count == 0)
                MessageBox.Show("אין מבשלת לבקשתך ");
            else
            {
                string newcook = (dataGridViewcook.SelectedRows[0].Cells["cookid"].Value.ToString());
                btnCooker.Text = newcook;

            }
        }

        private void button4home_Click(object sender, EventArgs e)
        {
            this.Close();
            basicForm bas = new basicForm();
            bas.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (comboBox2search.SelectedItem.ToString() == "חיפוש לפי שם")
                dataGridView1family.DataSource = FamilyBll.GetAll().Where(p => p.FamilyName.StartsWith(textBox1searchdriver.Text)).ToList();
         
            if (comboBox2search.SelectedItem.ToString() == "חיפוש לפי פלאפון")
                dataGridView1family.DataSource = FamilyBll.GetAll().Where(p => p.Phone.StartsWith(textBox1searchdriver.Text)).ToList();
         panelsearchfamaly.Visible = false;
        } 
    }
}