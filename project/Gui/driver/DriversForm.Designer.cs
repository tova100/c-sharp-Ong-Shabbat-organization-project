
namespace Gui
{
    partial class DriversForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.welcomeDrivers = new System.Windows.Forms.Label();
            this.dataGridView1driver = new System.Windows.Forms.DataGridView();
            this.Driverid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newcity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelAddDrivers = new System.Windows.Forms.Panel();
            this.comboBox1city = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4add = new System.Windows.Forms.Label();
            this.textBoxphonaddDrivers = new System.Windows.Forms.TextBox();
            this.btnotokDrivers = new System.Windows.Forms.Button();
            this.btnokaddDrivers = new System.Windows.Forms.Button();
            this.textBoxaddidDrivers = new System.Windows.Forms.TextBox();
            this.textBox4lastnadddriver = new System.Windows.Forms.TextBox();
            this.textBoxfirstneaddDrivers = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2search = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox2search = new System.Windows.Forms.ComboBox();
            this.textBox1searchdriver = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button4home = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1driver)).BeginInit();
            this.panelAddDrivers.SuspendLayout();
            this.panel2search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // welcomeDrivers
            // 
            this.welcomeDrivers.AutoSize = true;
            this.welcomeDrivers.Location = new System.Drawing.Point(383, 9);
            this.welcomeDrivers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeDrivers.Name = "welcomeDrivers";
            this.welcomeDrivers.Size = new System.Drawing.Size(99, 13);
            this.welcomeDrivers.TabIndex = 10;
            this.welcomeDrivers.Text = "ברוך הבא נהג יקר";
            this.welcomeDrivers.Click += new System.EventHandler(this.welcomeDrivers_Click);
            // 
            // dataGridView1driver
            // 
            this.dataGridView1driver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1driver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Driverid,
            this.newcity,
            this.lname,
            this.fname,
            this.ColPhone,
            this.ColCityId});
            this.dataGridView1driver.Location = new System.Drawing.Point(271, 37);
            this.dataGridView1driver.Name = "dataGridView1driver";
            this.dataGridView1driver.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1driver.RowHeadersWidth = 51;
            this.dataGridView1driver.Size = new System.Drawing.Size(485, 314);
            this.dataGridView1driver.TabIndex = 26;
            // 
            // Driverid
            // 
            this.Driverid.DataPropertyName = "DriverId";
            this.Driverid.HeaderText = "קוד נהג";
            this.Driverid.MinimumWidth = 6;
            this.Driverid.Name = "Driverid";
            this.Driverid.ReadOnly = true;
            this.Driverid.Width = 125;
            // 
            // newcity
            // 
            this.newcity.DataPropertyName = "newcity";
            this.newcity.HeaderText = "שם עיר";
            this.newcity.Name = "newcity";
            // 
            // lname
            // 
            this.lname.DataPropertyName = "Lastname";
            this.lname.HeaderText = "שם משפחה";
            this.lname.MinimumWidth = 6;
            this.lname.Name = "lname";
            this.lname.Width = 125;
            // 
            // fname
            // 
            this.fname.DataPropertyName = "Firstname";
            this.fname.HeaderText = "שם פרטי";
            this.fname.MinimumWidth = 6;
            this.fname.Name = "fname";
            this.fname.Width = 125;
            // 
            // ColPhone
            // 
            this.ColPhone.DataPropertyName = "Phone";
            this.ColPhone.HeaderText = "פלאפון";
            this.ColPhone.MinimumWidth = 6;
            this.ColPhone.Name = "ColPhone";
            this.ColPhone.Width = 125;
            // 
            // ColCityId
            // 
            this.ColCityId.DataPropertyName = "CityId";
            this.ColCityId.HeaderText = "עיר";
            this.ColCityId.MinimumWidth = 6;
            this.ColCityId.Name = "ColCityId";
            this.ColCityId.Visible = false;
            this.ColCityId.Width = 125;
            // 
            // panelAddDrivers
            // 
            this.panelAddDrivers.Controls.Add(this.comboBox1city);
            this.panelAddDrivers.Controls.Add(this.label3);
            this.panelAddDrivers.Controls.Add(this.label4);
            this.panelAddDrivers.Controls.Add(this.label5);
            this.panelAddDrivers.Controls.Add(this.label6);
            this.panelAddDrivers.Controls.Add(this.label8);
            this.panelAddDrivers.Controls.Add(this.label4add);
            this.panelAddDrivers.Controls.Add(this.textBoxphonaddDrivers);
            this.panelAddDrivers.Controls.Add(this.btnotokDrivers);
            this.panelAddDrivers.Controls.Add(this.btnokaddDrivers);
            this.panelAddDrivers.Controls.Add(this.textBoxaddidDrivers);
            this.panelAddDrivers.Controls.Add(this.textBox4lastnadddriver);
            this.panelAddDrivers.Controls.Add(this.textBoxfirstneaddDrivers);
            this.panelAddDrivers.Location = new System.Drawing.Point(28, 28);
            this.panelAddDrivers.Margin = new System.Windows.Forms.Padding(2);
            this.panelAddDrivers.Name = "panelAddDrivers";
            this.panelAddDrivers.Size = new System.Drawing.Size(225, 230);
            this.panelAddDrivers.TabIndex = 25;
            this.panelAddDrivers.Visible = false;
            this.panelAddDrivers.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAddDrivers_Paint_1);
            // 
            // comboBox1city
            // 
            this.comboBox1city.FormattingEnabled = true;
            this.comboBox1city.Location = new System.Drawing.Point(38, 138);
            this.comboBox1city.Name = "comboBox1city";
            this.comboBox1city.Size = new System.Drawing.Size(100, 21);
            this.comboBox1city.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "קוד עיר :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "פלאפון ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "שם משפחה:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "תעודת זהות ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(152, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "שם פרטי:";
            // 
            // label4add
            // 
            this.label4add.AutoSize = true;
            this.label4add.Location = new System.Drawing.Point(48, 10);
            this.label4add.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4add.Name = "label4add";
            this.label4add.Size = new System.Drawing.Size(90, 13);
            this.label4add.TabIndex = 5;
            this.label4add.Text = "הוספת נהג חדש ";
            // 
            // textBoxphonaddDrivers
            // 
            this.textBoxphonaddDrivers.Location = new System.Drawing.Point(38, 113);
            this.textBoxphonaddDrivers.Name = "textBoxphonaddDrivers";
            this.textBoxphonaddDrivers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxphonaddDrivers.Size = new System.Drawing.Size(100, 20);
            this.textBoxphonaddDrivers.TabIndex = 0;
            // 
            // btnotokDrivers
            // 
            this.btnotokDrivers.AutoSize = true;
            this.btnotokDrivers.BackColor = System.Drawing.Color.LightSalmon;
            this.btnotokDrivers.Location = new System.Drawing.Point(17, 185);
            this.btnotokDrivers.Margin = new System.Windows.Forms.Padding(2);
            this.btnotokDrivers.Name = "btnotokDrivers";
            this.btnotokDrivers.Size = new System.Drawing.Size(81, 27);
            this.btnotokDrivers.TabIndex = 3;
            this.btnotokDrivers.Text = "ביטול ";
            this.btnotokDrivers.UseVisualStyleBackColor = false;
            this.btnotokDrivers.Click += new System.EventHandler(this.btnotokDrivers_Click_2);
            // 
            // btnokaddDrivers
            // 
            this.btnokaddDrivers.AutoSize = true;
            this.btnokaddDrivers.BackColor = System.Drawing.Color.LightSalmon;
            this.btnokaddDrivers.Location = new System.Drawing.Point(122, 185);
            this.btnokaddDrivers.Margin = new System.Windows.Forms.Padding(2);
            this.btnokaddDrivers.Name = "btnokaddDrivers";
            this.btnokaddDrivers.Size = new System.Drawing.Size(81, 27);
            this.btnokaddDrivers.TabIndex = 3;
            this.btnokaddDrivers.Text = "אישור";
            this.btnokaddDrivers.UseVisualStyleBackColor = false;
            this.btnokaddDrivers.Click += new System.EventHandler(this.btnokaddDrivers_Click_1);
            // 
            // textBoxaddidDrivers
            // 
            this.textBoxaddidDrivers.Location = new System.Drawing.Point(38, 35);
            this.textBoxaddidDrivers.Name = "textBoxaddidDrivers";
            this.textBoxaddidDrivers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxaddidDrivers.Size = new System.Drawing.Size(100, 20);
            this.textBoxaddidDrivers.TabIndex = 0;
            // 
            // textBox4lastnadddriver
            // 
            this.textBox4lastnadddriver.Location = new System.Drawing.Point(38, 89);
            this.textBox4lastnadddriver.Name = "textBox4lastnadddriver";
            this.textBox4lastnadddriver.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox4lastnadddriver.Size = new System.Drawing.Size(100, 20);
            this.textBox4lastnadddriver.TabIndex = 0;
            // 
            // textBoxfirstneaddDrivers
            // 
            this.textBoxfirstneaddDrivers.Location = new System.Drawing.Point(38, 63);
            this.textBoxfirstneaddDrivers.Name = "textBoxfirstneaddDrivers";
            this.textBoxfirstneaddDrivers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxfirstneaddDrivers.Size = new System.Drawing.Size(100, 20);
            this.textBoxfirstneaddDrivers.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.LightSalmon;
            this.button3.Location = new System.Drawing.Point(638, 362);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 25);
            this.button3.TabIndex = 22;
            this.button3.Text = "מחיקת נהג";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.LightSalmon;
            this.button4.Location = new System.Drawing.Point(420, 362);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 29);
            this.button4.TabIndex = 23;
            this.button4.Text = "עידכון נהג";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSalmon;
            this.button5.Location = new System.Drawing.Point(313, 364);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 27);
            this.button5.TabIndex = 18;
            this.button5.Text = "לחיפוש";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.BackColor = System.Drawing.Color.LightSalmon;
            this.button6.Location = new System.Drawing.Point(540, 363);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 27);
            this.button6.TabIndex = 24;
            this.button6.Text = "הוספת נהג";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(400, 10);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "ברוך הבא נהג יקר";
            // 
            // panel2search
            // 
            this.panel2search.Controls.Add(this.button12);
            this.panel2search.Controls.Add(this.button13);
            this.panel2search.Controls.Add(this.button2);
            this.panel2search.Controls.Add(this.label13);
            this.panel2search.Controls.Add(this.comboBox2search);
            this.panel2search.Controls.Add(this.textBox1searchdriver);
            this.panel2search.Location = new System.Drawing.Point(11, 280);
            this.panel2search.Margin = new System.Windows.Forms.Padding(2);
            this.panel2search.Name = "panel2search";
            this.panel2search.Size = new System.Drawing.Size(243, 125);
            this.panel2search.TabIndex = 20;
            this.panel2search.Visible = false;
            this.panel2search.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2search_Paint);
            // 
            // button12
            // 
            this.button12.AutoSize = true;
            this.button12.BackColor = System.Drawing.Color.LightSalmon;
            this.button12.Location = new System.Drawing.Point(17, 83);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(91, 23);
            this.button12.TabIndex = 34;
            this.button12.Text = "ביטול";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.LightSalmon;
            this.button13.Location = new System.Drawing.Point(113, 82);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(91, 24);
            this.button13.TabIndex = 37;
            this.button13.Text = "חיפוש";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-79, 317);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 14;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(100, 8);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "חיפוש נהג";
            // 
            // comboBox2search
            // 
            this.comboBox2search.FormattingEnabled = true;
            this.comboBox2search.Items.AddRange(new object[] {
            "חיפוש לפי קוד",
            "חיפוש לפי פלאפון",
            "חיפוש לפי שם"});
            this.comboBox2search.Location = new System.Drawing.Point(105, 50);
            this.comboBox2search.Name = "comboBox2search";
            this.comboBox2search.Size = new System.Drawing.Size(121, 21);
            this.comboBox2search.TabIndex = 35;
            this.comboBox2search.SelectedIndexChanged += new System.EventHandler(this.comboBox2search_SelectedIndexChanged);
            // 
            // textBox1searchdriver
            // 
            this.textBox1searchdriver.Location = new System.Drawing.Point(17, 51);
            this.textBox1searchdriver.Name = "textBox1searchdriver";
            this.textBox1searchdriver.Size = new System.Drawing.Size(84, 20);
            this.textBox1searchdriver.TabIndex = 36;
            this.textBox1searchdriver.TextChanged += new System.EventHandler(this.textBox1searchdriver_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(451, 137);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 19;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button4home
            // 
            this.button4home.AutoSize = true;
            this.button4home.BackColor = System.Drawing.Color.Yellow;
            this.button4home.Location = new System.Drawing.Point(313, 415);
            this.button4home.Name = "button4home";
            this.button4home.Size = new System.Drawing.Size(401, 28);
            this.button4home.TabIndex = 28;
            this.button4home.Text = "חזרה לדף הבית";
            this.button4home.UseVisualStyleBackColor = false;
            this.button4home.Click += new System.EventHandler(this.button4home_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(198, 432);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 19);
            this.button8.TabIndex = 27;
            this.button8.Text = "רענון";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // DriversForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(780, 455);
            this.Controls.Add(this.button4home);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.dataGridView1driver);
            this.Controls.Add(this.panelAddDrivers);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2search);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.welcomeDrivers);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DriversForm";
            this.Text = "DriversForm";
            this.Load += new System.EventHandler(this.DriversForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1driver)).EndInit();
            this.panelAddDrivers.ResumeLayout(false);
            this.panelAddDrivers.PerformLayout();
            this.panel2search.ResumeLayout(false);
            this.panel2search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label welcomeDrivers;
        private System.Windows.Forms.DataGridView dataGridView1driver;
        private System.Windows.Forms.Panel panelAddDrivers;
        private System.Windows.Forms.ComboBox comboBox1city;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4add;
        private System.Windows.Forms.TextBox textBoxphonaddDrivers;
        private System.Windows.Forms.Button btnotokDrivers;
        private System.Windows.Forms.Button btnokaddDrivers;
        private System.Windows.Forms.TextBox textBoxaddidDrivers;
        private System.Windows.Forms.TextBox textBox4lastnadddriver;
        private System.Windows.Forms.TextBox textBoxfirstneaddDrivers;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2search;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4home;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox textBox1searchdriver;
        private System.Windows.Forms.ComboBox comboBox2search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Driverid;
        private System.Windows.Forms.DataGridViewTextBoxColumn newcity;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCityId;
        private System.Windows.Forms.Button button8;
    }
}