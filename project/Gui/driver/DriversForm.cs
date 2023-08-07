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
    public partial class DriversForm : Form
    {
        public FormState State;
        private List<DriversDto> driver = DriversBll.GetAll();
        public DriversForm()
        {
            InitializeComponent();
            dataGridView1driver.DataSource = DriversBll.GetAll().Select(x => new
            {
                x.DriverId,
                x.Lastname,
                x.Firstname,
                x.Phone,
                x.CityId,
                newcity = CityBll.searhcById(x.CityId).Name
            }).ToList();

        }

        //private void btnaddDrivers_Click(object sender, EventArgs e)
        //{
        //    panelAddDrivers.Visible = true;
        //    label4add.Text = "הופסה משפחה";


        //}

        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{

        //}

        //private void DriversForm_Load(object sender, EventArgs e)
        //{
        //    dataGridView1.DataSource = DriversBll.GetAll();
        //}

        //private void btnokaddDrivers_Click(object sender, EventArgs e)
        //{
        //    panelAddDrivers.Visible = false;
        //    DriversDto d = new DriversDto()
        //    {

        //        CityId = (int?)comboBox1city.SelectedValue,
        //        Firstname = textBoxfirstneaddDrivers.Text,
        //        Phone = textBoxphonaddDrivers.Text,
        //        DriverId = textBoxaddidDrivers.Text,
        //        Lastname = textBox4lastnadddriver.Text,


        //    };
        //    if (label4add.Text == "הופסה משפחה")
        //    {
        //        DriversBll.Add(d);
        //        dataGridView1.DataSource = DriversBll.GetAll();
        //    }
        //    else
        //    {
        //        DriversBll.update(d);
        //        dataGridView1.DataSource = DriversBll.GetAll();

        //    }
        //    dataGridView1.DataSource = DriversBll.GetAll();
        //}

        //private void btnotokDrivers_Click(object sender, EventArgs e)
        //{
        //    panelAddDrivers.Visible = false;
        //}

        //private void label6_Click(object sender, EventArgs e)
        //{

        //}

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        //private void welcomeDrivers_Click(object sender, EventArgs e)
        //{

        //}

        //private void labeaddnameDrivers_Click(object sender, EventArgs e)
        //{

        //}

        //private void labelidaddDrivers_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnsearchDrivers_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnupdateDrivers_Click(object sender, EventArgs e)
        //{

        //    panelAddDrivers.Visible = true;
        //    label4add.Text = "עידכן משפחה";

        //}

        //private void textBoxaddidDrivers_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void comboBox1city_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    comboBox1city.DataSource = KashrutBll.GetAll();
        //}

        //private void buttonsearch_Click(object sender, EventArgs e)
        //{

        //}

        //private void button2_Click(object sender, EventArgs e)
        //{

        //}

        private void btnaddDrivers_Click(object sender, EventArgs e)
        {
            panelAddDrivers.Visible = true;
            label4add.Text = "הופסה משפחה";


        }


        //private void buttonsearch_Click(object sender, EventArgs e)
        //{
        //    // buttonsearch.Visible = false;

        //    try
        //    {
        //        dataGridView1driver.DataSource = DriversBll.GetAll().Where(p => p.DriverId.StartsWith(textBox5.Text)).ToList();
        //    }
        //    catch { }
        //}
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DriversForm_Load(object sender, EventArgs e)
        {
            RefreshCitiesComboBox();



        }
        private void RefreshCitiesComboBox()
        {
            comboBox1city.DataSource = CityBll.GetAll();
            comboBox1city.DisplayMember = "Name";
            comboBox1city.ValueMember = "CitiesId";
        }


        private void btnokaddDrivers_Click(object sender, EventArgs e)
        {
            panelAddDrivers.Visible = false;
            DriversDto d = new DriversDto();
            //  object namecity = comboBox1city.SelectedValue;
            //להחליף את העיר בגלל שהיא מחרוזת ובדאל צריך שזה יהיה בקוד זה ההמרה וכן כדי שיהיה גישה טובה למשתמש להקיש את העיר באמת 
            // CityDto c = CityBll.GetAll().FirstOrDefault(item => namecity.ToString() == item.Name.ToString());
            //d.CityId=(int)c.CitiesId;
            d.CityId = (int)comboBox1city.SelectedValue;
            //d.CityId = int.Parse(c.CitiesId);
            d.Firstname = textBoxfirstneaddDrivers.Text;
            d.Phone = textBoxphonaddDrivers.Text;
            d.DriverId = textBoxaddidDrivers.Text;
            d.Lastname = textBox4lastnadddriver.Text;
            //{

            //   CityId = (int?)comboBox1city.SelectedValue,
            //    Firstname = textBoxfirstneaddDrivers.Text,
            //    Phone = textBoxphonaddDrivers.Text,
            //    DriverId = textBoxaddidDrivers.Text,
            //    Lastname = textBox4lastnadddriver.Text,


            //};
            if (State==FormState.Add)
            {
                DriversBll.Add(d);
                dataGridView1driver.DataSource = DriversBll.GetAll();
            }
            else
            {
                DriversBll.update(d);
                dataGridView1driver.DataSource = DriversBll.GetAll();

            }
            dataGridView1driver.DataSource = DriversBll.GetAll();
        }

        private void btnotokDrivers_Click(object sender, EventArgs e)
        {
            panelAddDrivers.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void welcomeDrivers_Click(object sender, EventArgs e)
        {

        }

        private void labeaddnameDrivers_Click(object sender, EventArgs e)
        {

        }

        private void labelidaddDrivers_Click(object sender, EventArgs e)
        {

        }

        private void btnsearchDrivers_Click(object sender, EventArgs e)
        {
            panel2search.Visible = true;
        }

        private void btnupdateDrivers_Click(object sender, EventArgs e)
        {

            panelAddDrivers.Visible = true;
            label4add.Text = "עדכון משפחה";

        }

        private void textBoxaddidDrivers_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1city_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btndeleteDrivers_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count == 0)
            //    MessageBox.Show("בחר מוצר למחיקה");
            //else
            //{
            //    if (MessageBox.Show("?האם ברצונך למחוק מוצר זה", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) == DialogResult.Yes)
            //    {
            //        DriversDto driver = RowToObject(dataGridView1.SelectedRows[0]);
            //        DriversBll.Delete(driver.DriverId);
            //        //RefreshProductsList();
            //    }
            //}

        }


        private void button6_Click(object sender, EventArgs e)
        {
            panelAddDrivers.Visible = true;
            State = FormState.Add;


        }

        private void button4_Click(object sender, EventArgs e)
        {

            panelAddDrivers.Visible = false;

            if (dataGridView1driver.SelectedRows.Count <= 0)
            {
                MessageBox.Show("בחר לקוח ");
            }

            else
            {
                {
                    State = FormState.Update;
                    panelAddDrivers.Visible = true;

                    DriversDto c = RowToObject(dataGridView1driver.SelectedRows[0]);

                    ObjectToForm(c);
                }



            }
        }

        private void ObjectToForm(DriversDto c)
        {
            label4add.Text = "עדכון נהג";
            panelAddDrivers.Visible = true;

            //  state = FormState.Edit;
            DriversDto d = RowToObject(dataGridView1driver.SelectedRows[0]);
            textBoxaddidDrivers.Text = d.DriverId.ToString();
            textBoxfirstneaddDrivers.Text = d.Firstname.ToString();
            textBox4lastnadddriver.Text = d.Lastname.ToString();
            comboBox1city.SelectedValue = d.CityId;
            textBoxphonaddDrivers.Text = d.Phone.ToString();
        }

        private void btnotokDrivers_Click_1(object sender, EventArgs e)
        {
            panelAddDrivers.Visible = false;
        }

        //helpp
        // from data grid row to object
        // העברת נתונים משורה בטבלה לאוביקט
        private DriversDto RowToObject(DataGridViewRow row)
        {
            // row - מכיל את כל שורה שנלחצה


            return new DriversDto()
            {

                DriverId = row.Cells["Driverid"].Value.ToString(),
                Firstname = row.Cells["fname"].Value.ToString(),
                Lastname = row.Cells["lname"].Value.ToString(),
                CityId = (int)row.Cells["ColCityId"].Value,

                Phone = row.Cells["colPhone"].Value.ToString(),
            };
        }

        private void RefreshProductsList()
        {
            driver = DriversBll.GetAll();
            dataGridView1driver.DataSource = driver;
        }


        private DriversDto FormToObject(out bool hasErrors)
        {
            DriversDto d = new DriversDto();
            hasErrors = false;
            errorProvider1.Clear();

            if (State == FormState.Update)
                  d.DriverId = (textBoxaddidDrivers.Text);
                //שם פרטי 
            try
            {
             d.Firstname = textBoxfirstneaddDrivers.Text;
            }
            catch (Exception ex)
            {
                hasErrors = true;
                errorProvider1.SetError(textBoxfirstneaddDrivers, ex.Message);
            }


            //שם משפחה
            try
            {
             d.Lastname = textBox4lastnadddriver.Text;
            }
            catch (Exception ex)
            {
                hasErrors = true;
                errorProvider1.SetError(textBox4lastnadddriver, ex.Message);
            }
          
            //טלפון
            try
            {
                d.Phone = textBoxphonaddDrivers.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBoxphonaddDrivers, ex.Message);
                hasErrors = true;
            }
            //קוד נהג
            try
            {
                d.DriverId = (textBoxaddidDrivers.Text);
            }
            catch (Exception ex)
            {
                hasErrors = true;
                errorProvider1.SetError(textBoxaddidDrivers, ex.Message);
            }
            //תעודת זהות
            //try
            //{
            //    d.DriverId = textBoxaddidDrivers.Text;
            //}
            //catch (Exception ex)
            //{
            //    hasErrors = true;
            //    errorProvider1.SetError(textBoxaddidDrivers, ex.Message);
               
            //}
            //עיר
            d.CityId = (int)comboBox1city.SelectedValue;
            return d;
        }
        //private void button3_Click(object sender, EventArgs e)
        //{
        //    //bool flag = true;
        //    //errorProvider1.Clear();

        //    DriversDto d = FormToObject(out bool hasError);

        //    if (!hasError)
        //    {
        //        try
        //        {
        //            if (label4add.Text == "הוספת נהג חדש ")
        //            {
        //                DriversBll.Add(d);
        //                MessageBox.Show("הנתונים נקלטו בהצלחה", "קליטת נתונים");
        //                dataGridView1driver.DataSource = DriversBll.GetAll();
        //            }
        //            else
        //            {
        //                DriversBll.update(d);
        //                MessageBox.Show("הנתונים עודכנו בהצלחה", "עדכון נתונים");
        //                dataGridView1driver.DataSource = DriversBll.GetAll();
        //            }
        //            panelAddDrivers.Visible = false;
        //        }
        //        catch
        //        {
        //            MessageBox.Show("שגיאה בשמירת הנתונים");
        //        }
        //        return d;

        //    }
        //}

        private void button3_Click_1(object sender, EventArgs e)
        {


            if (dataGridView1driver.SelectedRows.Count == 0)
                MessageBox.Show("בחר לקוח למחיקה");
            else
            {
                if (MessageBox.Show(" ?האם ברצונך למחוק לקוח זה", "אישור מחיקה",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                {
                    DriversDto d = RowToObject(dataGridView1driver.SelectedRows[0]);
                    DriversBll.Delete(d);
                    RefreshProductsList();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2search.Visible = true;
        }

        private void panel2search_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btnokaddDrivers_Click_1(object sender, EventArgs e)
        {
            //panelAddDrivers.Visible = false;
            //DriversDto d = new DriversDto();
            DriversDto d = FormToObject(out bool hasErrors);
            if (!hasErrors)
           
            //object namecity = comboBox1city.SelectedValue;
            //להחליף את העיר בגלל שהיא מחרוזת ובדאל צריך שזה יהיה בקוד זה ההמרה וכן כדי שיהיה גישה טובה למשתמש להקיש את העיר באמת 
            //  CityDto c = CityBll.GetAll().FirstOrDefault(item => namecity.ToString() == item.Name.ToString());
            //d.CityId=(int)c.CitiesId;

            //{

            //   CityId = (int?)comboBox1city.SelectedValue,
            //    Firstname = textBoxfirstneaddDrivers.Text,
            //    Phone = textBoxphonaddDrivers.Text,
            //    DriverId = textBoxaddidDrivers.Text,
            //    Lastname = textBox4lastnadddriver.Text,


            //};
            if (State==FormState.Add)
            {
                DriversBll.Add(d);
                MessageBox.Show("הנתונים נקלטו בהצלחה", "קליטת נתונים");
                    // dataGridView1driver.DataSource = DriversBll.GetAll();
                    dataGridView1driver.DataSource = DriversBll.GetAll().Select(x => new
                    {
                        x.DriverId,
                        x.Lastname,
                        x.Firstname,
                        x.Phone,
                        x.CityId,
                        newcity = CityBll.searhcById(x.CityId).Name
                    }).ToList();

                }
            else
            {
                DriversBll.update(d);
                    // dataGridView1driver.DataSource = DriversBll.GetAll();
                    dataGridView1driver.DataSource = DriversBll.GetAll().Select(x => new
                    {
                        x.DriverId,
                        x.Lastname,
                        x.Firstname,
                        x.Phone,
                        x.CityId,
                        newcity = CityBll.searhcById(x.CityId).Name
                    }).ToList();

                }
            //MessageBox.Show("שגיאה בשמירת הנתונים");

            // dataGridView1driver.DataSource = DriversBll.GetAll().Select(x => new { x.DriverId, x.Lastname, x.Firstname, x.Phone, x.CityId, עיר = CityBll.searhcById(x.CityId).Name }).ToList();
            ClearPakadim();
            panelAddDrivers.Visible = false;
        }

        //private void FormToObject(DriversDto d)
        //{
        //    d.CityId = (int)comboBox1city.SelectedValue;

        //    d.Firstname = textBoxfirstneaddDrivers.Text;
        //    d.Phone = textBoxphonaddDrivers.Text;
        //    d.DriverId = textBoxaddidDrivers.Text;
        //    d.Lastname = textBox4lastnadddriver.Text;
        //    return d;
        //}

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
      public void ClearPakadim()
        {
            textBox4lastnadddriver.Text = null;
            textBoxaddidDrivers.Text = null;
            textBoxfirstneaddDrivers.Text= null;
            comboBox1city.SelectedIndex = -1;
            textBoxphonaddDrivers.Text= null;   


        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2search.Visible = false;

        }

        //private void button7_Click(object sender, EventArgs e)
        //{
        //    dataGridView1driver.DataSource = DriversBll.GetAll().Where(p => p.Firstname.StartsWith(textBox6n.Text)).ToList();
        //}

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1driver.DataSource = DriversBll.GetAll();

        }

        private void btnotokDrivers_Click_2(object sender, EventArgs e)
        {
            
            panelAddDrivers.Visible = false;
            ClearPakadim();
        }

        private void panelAddDrivers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelsearchcook_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (comboBox2search.SelectedItem.ToString() == "חיפוש לפי שם")
                dataGridView1driver.DataSource = DriversBll.GetAll().Where(p => p.Firstname.StartsWith(textBox1searchdriver.Text)).ToList();

            if (comboBox2search.SelectedItem.ToString() == "חיפוש לפי קוד")
                dataGridView1driver.DataSource = DriversBll.GetAll().Where(p => p.DriverId.StartsWith(textBox1searchdriver.Text)).ToList();

            if (comboBox2search.SelectedItem.ToString() == "חיפוש לפי פלאפון")
                dataGridView1driver.DataSource = DriversBll.GetAll().Where(p => p.Phone.StartsWith(textBox1searchdriver.Text)).ToList();
          panel2search.Visible = false;
}

            private void button4home_Click(object sender, EventArgs e)
        {
            this.Close();
            basicForm bas = new basicForm();
            bas.Show();
        }

        private void textBox1searchdriver_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelAddDrivers_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}









