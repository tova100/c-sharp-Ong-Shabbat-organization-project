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
    public partial class CookerFrom : Form
    {
        public FormState state;
        private List<CookereDto> cook = CookereBll.GetAll();

        public CookerFrom()
        {
            InitializeComponent();
            dataGridViewcook.DataSource = CookereBll.GetAll().Select(x => new {
                x.CookerId,
                x.Firstname,
                x.Lastname,
                x.FullName,
                x.Phone,
                x.KashroutId,
                newcashrot = KashrutBll.searhcByIdKashrout(x.KashroutId).Name,
           //     כשרות =KashrutBll.searhcByIdKashrout(x.KashroutId),
                x.CityId,
                newcity = CityBll.searhcById(x.CityId).Name,
                x.Street,
                x.Apartment_number,
                x.driverId,
                newdriver=DriversBll.searhcByIdDriver(x.driverId).Firstname,
                x.KindOfFood

            }).ToList();
        }

        private void welcome_TextChanged(object sender, EventArgs e)
        {

        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            panel3cook.Visible = true;
            label10cook.Text = "הוספת מבשלת ";


        }
    
        public void ClearPakadim()
        {
            textBox1kindoffood.Text = null;
            textBox1lastcook.Text=null;
            textBox1numapartment.Text = null;
            textBoxadresaddcook.Text = null;
            textBoxfullnameaddcook.Text = null;
            textBoxidcookadd.Text = null;
            textBoxphonaddcook.Text=null;
            comboBox1city.SelectedIndex = -1;
            comboBox2cashrut.SelectedIndex =-1;
       

        }
        private void DriverForm_Load(object sender, EventArgs e)
        {
            //dataGridViewcook.DataSource = CookereBll.GetAll();
            RefreshCitiesComboBox();
            RefreshKashrutComboBox();


        }
        private void RefreshCitiesComboBox()
        {
            comboBox1city.DataSource = CityBll.GetAll();
            comboBox1city.DisplayMember = "Name";
            comboBox1city.ValueMember = "CitiesId";
        }
        private void RefreshKashrutComboBox()
        {
            comboBox2cashrut.DataSource = KashrutBll.GetAll();
            comboBox2cashrut.DisplayMember = "Name";
            comboBox2cashrut.ValueMember = "KashroutId";
        }
        private void DeleteDriver_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Searchvolanteer_Click(object sender, EventArgs e)
        {

        }


        private void btnupdate_Click(object sender, EventArgs e)
        {

            label10cook.Text = "עידכון מבשלת ";
            panel3cook.Visible = false;


            if (dataGridViewcook.SelectedRows.Count <= 0)
            {
                MessageBox.Show("בחר לקוח ");
            }

            else
            {
                {
                    state = FormState.Update;
                    panel3cook.Visible = true;

                    CookereDto c = RowToObject(dataGridViewcook.SelectedRows[0]);

                    ObjectToForm(c);
                }
            }
        }
        private void ObjectToForm(CookereDto c)

        {
            label10cook.Text = "עידכון משפחה";
            panel3cook.Visible = true;

            CookereDto f = RowToObject(dataGridViewcook.SelectedRows[0]);

            textBoxadresaddcook.Text = f.Street;
            textBox1lastcook.Text = f.Lastname;
            comboBox1city.SelectedValue = f.CityId;

            textBoxidcookadd.Text = f.CookerId;
            textBox1numapartment.Text = f.Apartment_number;
            comboBox2cashrut.SelectedValue = f.KashroutId;
            textBoxphonaddcook.Text = f.Phone;
            textBox1kindoffood.Text = f.KindOfFood;
            textBoxfullnameaddcook.Text = f.Firstname;


        }



        private CookereDto RowToObject(DataGridViewRow row)
        {
            //row - מכיל את כל שורה שנלחצה

            return new CookereDto()
            {

                CookerId = row.Cells["Colcookid"].Value.ToString(),
                Firstname = row.Cells["Colfirstname"].Value.ToString(),
                Lastname = row.Cells["Collastname"].Value.ToString(),
                Apartment_number = row.Cells["Colapartment"].Value.ToString(),
                KashroutId = (int)row.Cells["Colkashrutid"].Value,
                CityId = (int)row.Cells["Cocity"].Value,
                Phone = row.Cells["colPhone"].Value.ToString(),
                KindOfFood = Convert.ToString(row.Cells["Colkindof"].Value),
                //  driverId= row.Cells["Coldriverid"].Value.ToString(),
                Street = row.Cells["ColSteet"].Value.ToString(),
                FullName = Convert.ToString(row.Cells["Colfullname"].Value),
            };
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxcashrutaddcook_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2cashrut_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnokaddFamily_Click(object sender, EventArgs e)
        {
            panel3cook.Visible = false;
            CookereDto f = new CookereDto();
            {
                //  object namecity = comboBox1city.SelectedValue;
                //להחליף את העיר בגלל שהיא מחרוזת ובדאל צריך שזה יהיה בקוד זה ההמרה וכן כדי שיהיה גישה טובה למשתמש להקיש את העיר באמת 
                // CityDto city = CityBll.GetAll().FirstOrDefault(item => namecity.ToString() == item.Name.ToString());
                f.CityId = (int)comboBox1city.SelectedValue;
                f.Firstname = textBoxfullnameaddcook.Text;
                f.Lastname = textBox1lastcook.Text;
                f.CookerId = textBoxidcookadd.Text;
                f.Phone = textBoxphonaddcook.Text;
                f.Street = textBoxadresaddcook.Text;
                f.KashroutId = (int)comboBox2cashrut.SelectedValue;
                f.Apartment_number = (textBox1numapartment.Text);
                f.KindOfFood = textBox1kindoffood.Text;
                //קוד נהג
            };
            if (state == FormState.Add)
            {
                CookereBll.Addc(f);
                dataGridViewcook.DataSource = CookereBll.GetAll();
            }
            else
            {
                CookereBll.Updatec(f);
                dataGridViewcook.DataSource = CookereBll.GetAll();
            }

        }

        private void btnnotokFamily_Click(object sender, EventArgs e)
        {
            panel3cook.Visible = false;
        }

        private void label10Add_Click(object sender, EventArgs e)
        {

        }
        private void buttonsearch_Click(object sender, EventArgs e)
        {
            panelsearchcook.Visible = true;
        }
        private void button1cashrut_Click(object sender, EventArgs e)
        {
            panel1cashrut.Visible = true;
        }
        private void textBox1numapartment_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonsearch_Clickc(object sender, EventArgs e)
        {
            panelsearchcook.Visible = true;
        }
        //private void buttonsearchcook_Click(object sender, EventArgs e)
        //{
        //    KashrutDto k = new KashrutDto();
        //    k.Name = buttonsearchcook.Text;
        //    KashrutBll.Addc(k);
        //    MessageBox.Show("הנתונים נקלטו בהצלחה", "קליטת נתונים");
        //    panel1cashrut.Visible = false;
        //}


        private void button1cashrutadd_Click(object sender, EventArgs e)
        {
            panel1cashrut.Visible = true;
        }

        private void panel1cashrut_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    dataGridViewcook.DataSource = CookereBll.GetAll().Where(p => p.Lastname.StartsWith(searchlastname.Text)).ToList();
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    dataGridViewcook.DataSource = FamilyBll.GetAll().Where(p => p.Phone.StartsWith(textBoxphonFamily.Text)).ToList();


        //}

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1addcity.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1cashrut.Visible = true;
        }

        private void btnokaddcook_Click(object sender, EventArgs e)
        {
            CookereDto c = FormToObject(out bool hasErrors);
            if (!hasErrors)
            {
                if (state == FormState.Add)
                {
                    CookereBll.Addc(c);

                    MessageBox.Show("הנתונים נקלטו בהצלחה", "קליטת נתונים");
                    dataGridViewcook.DataSource = CookereBll.GetAll();
                }
                else
                {
                    CookereBll.Updatec(c);

                    MessageBox.Show("הנתונים נקלטו בהצלחה", "קליטת נתונים");
                    dataGridViewcook.DataSource = CookereBll.GetAll();
                }
                panel3cook.Visible = false;
            }
            //dataGridViewcook.DataSource = CookereBll.GetAll().Select(x => new { x.CookerId, x.Firstname, x.Lastname, x.FullName,x.Phone,x.KashroutId,x.CityId,
            //    x.Street,x.driverId x., עיר = CityBll.searhcById(x.CityId).Name }).ToList();
           ClearPakadim();
        }

        private CookereDto FormToObject(out bool hasErrors)
        {
            CookereDto c = new CookereDto();
            hasErrors = false;
            errorProvider1.Clear();

            if (state == FormState.Update)
                c.CookerId = (textBoxidcookadd.Text);

            // object namecity = comboBox1city.SelectedValue;
            //להחליף את העיר בגלל שהיא מחרוזת ובדאל צריך שזה יהיה בקוד זה ההמרה וכן כדי שיהיה גישה טובה למשתמש להקיש את העיר באמת 
            //  CityDto c1 = CityBll.GetAll().FirstOrDefault(item => namecity.ToString() == item.Name.ToString());
            //d.CityId=(int)c.CitiesId;
            // c.CityId = int.Parse(c1.CitiesId);

            //כשרות
            c.KashroutId = (int)comboBox2cashrut.SelectedValue;

            //עיר
            c.CityId = (int)comboBox1city.SelectedValue;
            //מס דירה
            //שם פרטי
            try
            {
                c.Firstname = textBoxfullnameaddcook.Text;
            }
            catch (Exception ex)
            {
                hasErrors = true;
                errorProvider1.SetError(textBoxfullnameaddcook, ex.Message);
            }
            //פלאפון
            try
            {
                c.Phone = textBoxphonaddcook.Text;
            }
            catch (Exception ex)
            {
                hasErrors = true;
                errorProvider1.SetError(textBoxphonaddcook, ex.Message);
            }
            //סוג אוכל
            try
            {
                c.KindOfFood = textBox1kindoffood.Text;
            }
            catch (Exception ex)
            {
                hasErrors = true;
                errorProvider1.SetError(textBox1kindoffood, ex.Message);
            }
            //שם משפחה
            try
            {
                c.Lastname = textBox1lastcook.Text;
            }
            catch (Exception ex)
            {
                hasErrors = true;
                errorProvider1.SetError(textBox1lastcook, ex.Message);
            }
            //כתובת
            try
            {
                c.Street = textBoxadresaddcook.Text;
            }
            catch (Exception ex)
            {
                hasErrors = true;
                errorProvider1.SetError(textBoxadresaddcook, ex.Message);
            }
            //מס דירה
            try
            {
                c.Apartment_number = (textBox1numapartment.Text);
            }
            catch (Exception ex)
            {
                hasErrors = true;
                errorProvider1.SetError(textBox1numapartment, ex.Message);
            }
            //קוד מבשל
            try
            {
                c.CookerId = (textBoxidcookadd.Text);
            }
            catch (Exception ex)
            {
                hasErrors = true;
                errorProvider1.SetError(textBoxidcookadd, ex.Message);
            }
            //עיר
            try
            {
                //if (DriversBll.GetAll().FirstOrDefault(x => x.CityId == c.CityId) != null)
                //    c.driverId = DriversBll.GetAll().FirstOrDefault(x => x.CityId == c.CityId).DriverId;
                //else
                //    throw new Exception("אין נהג בעיר ");

                if (btnDriver.Text != "בחירת נהג")
                    c.driverId = btnDriver.Text;
             

            }
            catch (Exception ex)
            {

                errorProvider1.SetError(btnDriver, ex.Message);
                hasErrors = true;
            }
            
             //   c.FullName = textBoxfullnameaddcook +" "+textBox1lastcook;
      
            
            dataGridView1.Visible = false;

            return c;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel1cashrut.Visible = true;
        }

        private void button2addcity_Click(object sender, EventArgs e)
        {
            panel1addcity.Visible = true;
        }

        private void button1cityadd_Click(object sender, EventArgs e)
        {
            CityDto c = new CityDto();
            c.Name = textBox1city.Text;
            CityBll.Addc(c);
            RefreshCitiesComboBox();
            MessageBox.Show("הנתונים נקלטו בהצלחה", "קליטת נתונים");
            panel1addcity.Visible = false;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            panelsearchcook.Visible = true;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            if (dataGridViewcook.SelectedRows.Count == 0)
                MessageBox.Show("בחר לקוח למחיקה");
            else
            {
                if (MessageBox.Show(" ?האם ברצונך למחוק לקוח זה", "אישור מחיקה",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                {
                    CookereDto f = RowToObject(dataGridViewcook.SelectedRows[0]);
                    CookereBll.Delete(f);
                    RefreshProductsList();
                }
            }
        }
        //פונקציה שמרעננת את הנתונים 
        private void RefreshProductsList()
        {
            cook = CookereBll.GetAll();
            dataGridViewcook.DataSource = cook;
        }

        //private void button2searchcook_Click(object sender, EventArgs e)
        //{
        //    dataGridViewcook.DataSource = CookereBll.GetAll().Where(p => p.Lastname.StartsWith(searchlastname.Text)).ToList();

        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
     //       dataGridViewcook.DataSource = CookereBll.GetAll().Where(p => p.Phone.StartsWith(textBoxphonFamily.Text)).ToList();

        }

        private void button2caaa_Click(object sender, EventArgs e)
        {

            KashrutDto c = new KashrutDto();
            c.Name = cashrut.Text;
            KashrutBll.Addc(c);
            RefreshKashrutComboBox();
            MessageBox.Show("הנתונים נקלטו בהצלחה", "קליטת נתונים");
            panel1cashrut.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1cashrut.Visible = false;

        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            panel1addcity.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            try
            {
                if (comboBox1city.SelectedValue != null)
                    dataGridView1.DataSource = DriversBll.GetByCity((int)comboBox1city.SelectedValue);
                if (dataGridView1.SelectedRows.Count == 0)
                    MessageBox.Show("בחר נהג");

                //.Select(x => new { x.DriverId, x.Lastname, x.Firstname, x.Phone, x.CityId, שם_עיר = CityBll.searhcById(x.CityId).Name }).ToList();
            }
            catch
            {
                MessageBox.Show("בחרי עיר");
            }
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                MessageBox.Show("בחר נהג ");
            else
            {
                string driverId = dataGridView1.SelectedRows[0].Cells["Driverid"].Value.ToString();
                btnDriver.Text = driverId;


            }
        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (comboBox1.SelectedItem.ToString() == "חיפוש לפי שם ")
        //        state = FormState.SearchById;
        //}

        private void button6_Click_1(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() =="חיפוש לפי שם")
                dataGridViewcook.DataSource = CookereBll.GetAll().Where(p => p.Firstname.StartsWith(textBox1search.Text)).ToList();

            if (comboBox1.SelectedItem.ToString() == "חיפוש לפי קוד")
                dataGridViewcook.DataSource = CookereBll.GetAll().Where(p => p.CookerId.StartsWith(textBox1search.Text)).ToList();

            if (comboBox1.SelectedItem.ToString() == "חיפוש לפי פלאפון")
                dataGridViewcook.DataSource = CookereBll.GetAll().Where(p => p.Phone.StartsWith(textBox1search.Text)).ToList();
            panelsearchcook.Visible = false;
        }

        private void button4home_Click(object sender, EventArgs e)
        {
            this.Close();
            basicForm bas=new basicForm();
            bas.Show();   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelsearchcook.Visible = false;
        }

        private void btnnotokFamily_Click_1(object sender, EventArgs e)
        {
            ClearPakadim();
            panel3cook.Visible=false;
        }
    }


}




