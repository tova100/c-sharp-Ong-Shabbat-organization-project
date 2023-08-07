namespace Gui
{
    partial class basicForm
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
            this.menuStripbase = new System.Windows.Forms.MenuStrip();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ניהולמשפחותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ניהולמתנדביםToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.תרומותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripbase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripbase
            // 
            this.menuStripbase.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripbase.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripbase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem,
            this.ניהולמשפחותToolStripMenuItem,
            this.ניהולמתנדביםToolStripMenuItem,
            this.תרומותToolStripMenuItem});
            this.menuStripbase.Location = new System.Drawing.Point(0, 0);
            this.menuStripbase.Name = "menuStripbase";
            this.menuStripbase.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStripbase.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStripbase.Size = new System.Drawing.Size(1114, 24);
            this.menuStripbase.TabIndex = 1;
            this.menuStripbase.Text = "menuStripbase";
            this.menuStripbase.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripbase_ItemClicked);
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.fToolStripMenuItem.Text = "דף הבית ";
            this.fToolStripMenuItem.Click += new System.EventHandler(this.fToolStripMenuItem_Click);
            // 
            // ניהולמשפחותToolStripMenuItem
            // 
            this.ניהולמשפחותToolStripMenuItem.Name = "ניהולמשפחותToolStripMenuItem";
            this.ניהולמשפחותToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.ניהולמשפחותToolStripMenuItem.Text = "ניהול משפחות ";
            this.ניהולמשפחותToolStripMenuItem.Click += new System.EventHandler(this.ניהולמשפחותToolStripMenuItem_Click);
            // 
            // ניהולמתנדביםToolStripMenuItem
            // 
            this.ניהולמתנדביםToolStripMenuItem.Name = "ניהולמתנדביםToolStripMenuItem";
            this.ניהולמתנדביםToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.ניהולמתנדביםToolStripMenuItem.Text = "ניהול מתנדבים ";
            this.ניהולמתנדביםToolStripMenuItem.Click += new System.EventHandler(this.ניהולמתנדביםToolStripMenuItem_Click);
            // 
            // תרומותToolStripMenuItem
            // 
            this.תרומותToolStripMenuItem.Name = "תרומותToolStripMenuItem";
            this.תרומותToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.תרומותToolStripMenuItem.Text = "תרומות ";
            this.תרומותToolStripMenuItem.Click += new System.EventHandler(this.תרומותToolStripMenuItem_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(384, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "נשמח לעמוד לשירותכם לכל פניה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(279, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(499, 84);
            this.label2.TabIndex = 4;
            this.label2.Text = "עונג שבת\r\nOneg Shabbat organization\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "ברוכים הבאים לארגון עונג שבת";
            // 
            // basicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1114, 610);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStripbase);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "basicForm";
            this.Text = "BabicForm";
            this.Load += new System.EventHandler(this.BabicForm_Load);
            this.menuStripbase.ResumeLayout(false);
            this.menuStripbase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripbase;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ניהולמשפחותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ניהולמתנדביםToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem תרומותToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}