
namespace Gui
{
    partial class VolonteerForm
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
            this.buttoncook = new System.Windows.Forms.Button();
            this.buttondivres = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttoncook
            // 
            this.buttoncook.AutoSize = true;
            this.buttoncook.BackColor = System.Drawing.Color.LightSalmon;
            this.buttoncook.Location = new System.Drawing.Point(288, 245);
            this.buttoncook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttoncook.Name = "buttoncook";
            this.buttoncook.Size = new System.Drawing.Size(83, 28);
            this.buttoncook.TabIndex = 0;
            this.buttoncook.Text = "מבשלות ";
            this.buttoncook.UseVisualStyleBackColor = false;
            this.buttoncook.Click += new System.EventHandler(this.buttoncook_Click);
            // 
            // buttondivres
            // 
            this.buttondivres.AutoSize = true;
            this.buttondivres.BackColor = System.Drawing.Color.LightSalmon;
            this.buttondivres.Location = new System.Drawing.Point(423, 245);
            this.buttondivres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttondivres.Name = "buttondivres";
            this.buttondivres.Size = new System.Drawing.Size(75, 28);
            this.buttondivres.TabIndex = 0;
            this.buttondivres.Text = "נהגים ";
            this.buttondivres.UseVisualStyleBackColor = false;
            this.buttondivres.Click += new System.EventHandler(this.buttondivres_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ברוך הבא מתנדב/ת";
            // 
            // VolonteerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttondivres);
            this.Controls.Add(this.buttoncook);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VolonteerForm";
            this.Text = "VolonteerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoncook;
        private System.Windows.Forms.Button buttondivres;
        private System.Windows.Forms.Label label2;
    }
}