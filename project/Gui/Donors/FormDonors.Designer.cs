
namespace Gui
{
    partial class FormDonors
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
            this.textBoxfirstname = new System.Windows.Forms.TextBox();
            this.textBoxlastname = new System.Windows.Forms.TextBox();
            this.textBoxadress = new System.Windows.Forms.TextBox();
            this.lablefirstname = new System.Windows.Forms.Label();
            this.labellastname = new System.Windows.Forms.Label();
            this.labeadrees = new System.Windows.Forms.Label();
            this.labelamount = new System.Windows.Forms.Label();
            this.numberamount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberamount)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxfirstname
            // 
            this.textBoxfirstname.Location = new System.Drawing.Point(250, 89);
            this.textBoxfirstname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxfirstname.Name = "textBoxfirstname";
            this.textBoxfirstname.Size = new System.Drawing.Size(76, 20);
            this.textBoxfirstname.TabIndex = 0;
            // 
            // textBoxlastname
            // 
            this.textBoxlastname.Location = new System.Drawing.Point(252, 115);
            this.textBoxlastname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxlastname.Name = "textBoxlastname";
            this.textBoxlastname.Size = new System.Drawing.Size(76, 20);
            this.textBoxlastname.TabIndex = 0;
            // 
            // textBoxadress
            // 
            this.textBoxadress.Location = new System.Drawing.Point(252, 147);
            this.textBoxadress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxadress.Name = "textBoxadress";
            this.textBoxadress.Size = new System.Drawing.Size(76, 20);
            this.textBoxadress.TabIndex = 0;
            // 
            // lablefirstname
            // 
            this.lablefirstname.AutoSize = true;
            this.lablefirstname.Location = new System.Drawing.Point(342, 91);
            this.lablefirstname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lablefirstname.Name = "lablefirstname";
            this.lablefirstname.Size = new System.Drawing.Size(54, 13);
            this.lablefirstname.TabIndex = 1;
            this.lablefirstname.Text = "שם פרטי:";
            // 
            // labellastname
            // 
            this.labellastname.AutoSize = true;
            this.labellastname.Location = new System.Drawing.Point(332, 118);
            this.labellastname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labellastname.Name = "labellastname";
            this.labellastname.Size = new System.Drawing.Size(66, 13);
            this.labellastname.TabIndex = 1;
            this.labellastname.Text = "שם משפחה:";
            // 
            // labeadrees
            // 
            this.labeadrees.AutoSize = true;
            this.labeadrees.Location = new System.Drawing.Point(352, 151);
            this.labeadrees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeadrees.Name = "labeadrees";
            this.labeadrees.Size = new System.Drawing.Size(43, 13);
            this.labeadrees.TabIndex = 1;
            this.labeadrees.Text = "כתובת:";
            // 
            // labelamount
            // 
            this.labelamount.AutoSize = true;
            this.labelamount.Location = new System.Drawing.Point(332, 185);
            this.labelamount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelamount.Name = "labelamount";
            this.labelamount.Size = new System.Drawing.Size(78, 13);
            this.labelamount.TabIndex = 1;
            this.labelamount.Text = "סכום התרומה ";
            // 
            // numberamount
            // 
            this.numberamount.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberamount.Location = new System.Drawing.Point(250, 185);
            this.numberamount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numberamount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numberamount.Name = "numberamount";
            this.numberamount.Size = new System.Drawing.Size(68, 20);
            this.numberamount.TabIndex = 2;
            this.numberamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberamount.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numberamount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "שלום תורם יקר";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "מס כרטיס:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonok
            // 
            this.buttonok.AutoSize = true;
            this.buttonok.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonok.Location = new System.Drawing.Point(252, 253);
            this.buttonok.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonok.Name = "buttonok";
            this.buttonok.Size = new System.Drawing.Size(116, 23);
            this.buttonok.TabIndex = 4;
            this.buttonok.Text = "לאישור התרומה ";
            this.buttonok.UseVisualStyleBackColor = false;
            this.buttonok.Click += new System.EventHandler(this.buttonok_Click);
            // 
            // FormDonors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberamount);
            this.Controls.Add(this.labelamount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labeadrees);
            this.Controls.Add(this.labellastname);
            this.Controls.Add(this.lablefirstname);
            this.Controls.Add(this.textBoxadress);
            this.Controls.Add(this.textBoxlastname);
            this.Controls.Add(this.textBoxfirstname);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDonors";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "FormDonors";
            this.Load += new System.EventHandler(this.FormDonors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberamount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxfirstname;
        private System.Windows.Forms.TextBox textBoxlastname;
        private System.Windows.Forms.TextBox textBoxadress;
        private System.Windows.Forms.Label lablefirstname;
        private System.Windows.Forms.Label labellastname;
        private System.Windows.Forms.Label labeadrees;
        private System.Windows.Forms.Label labelamount;
        private System.Windows.Forms.NumericUpDown numberamount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonok;
    }
}