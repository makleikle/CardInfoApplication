
namespace Assignment
{
    partial class CreditCdisplayForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FName = new System.Windows.Forms.TextBox();
            this.CName = new System.Windows.Forms.TextBox();
            this.CVV = new System.Windows.Forms.TextBox();
            this.EXdate = new System.Windows.Forms.TextBox();
            this.CCnum = new System.Windows.Forms.TextBox();
            this.isexpired = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Credit Card Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Credit Card Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Expiration Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CVV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Full Name";
            // 
            // FName
            // 
            this.FName.Location = new System.Drawing.Point(117, 147);
            this.FName.Name = "FName";
            this.FName.ReadOnly = true;
            this.FName.Size = new System.Drawing.Size(170, 20);
            this.FName.TabIndex = 4;
            // 
            // CName
            // 
            this.CName.Location = new System.Drawing.Point(117, 40);
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            this.CName.Size = new System.Drawing.Size(181, 20);
            this.CName.TabIndex = 0;
            // 
            // CVV
            // 
            this.CVV.Location = new System.Drawing.Point(117, 118);
            this.CVV.Name = "CVV";
            this.CVV.ReadOnly = true;
            this.CVV.Size = new System.Drawing.Size(100, 20);
            this.CVV.TabIndex = 3;
            // 
            // EXdate
            // 
            this.EXdate.Location = new System.Drawing.Point(117, 92);
            this.EXdate.Name = "EXdate";
            this.EXdate.ReadOnly = true;
            this.EXdate.Size = new System.Drawing.Size(100, 20);
            this.EXdate.TabIndex = 2;
            // 
            // CCnum
            // 
            this.CCnum.Location = new System.Drawing.Point(117, 66);
            this.CCnum.Name = "CCnum";
            this.CCnum.ReadOnly = true;
            this.CCnum.Size = new System.Drawing.Size(170, 20);
            this.CCnum.TabIndex = 1;
            // 
            // isexpired
            // 
            this.isexpired.AutoSize = true;
            this.isexpired.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.isexpired.ForeColor = System.Drawing.Color.Red;
            this.isexpired.Location = new System.Drawing.Point(127, 9);
            this.isexpired.Name = "isexpired";
            this.isexpired.Size = new System.Drawing.Size(55, 17);
            this.isexpired.TabIndex = 10;
            this.isexpired.Text = "Expired";
            // 
            // CCdisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 177);
            this.Controls.Add(this.isexpired);
            this.Controls.Add(this.CCnum);
            this.Controls.Add(this.EXdate);
            this.Controls.Add(this.CVV);
            this.Controls.Add(this.CName);
            this.Controls.Add(this.FName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CCdisplayForm";
            this.Text = "Credit Card Info";
            this.Load += new System.EventHandler(this.CCardEForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FName;
        private System.Windows.Forms.TextBox CName;
        private System.Windows.Forms.TextBox CVV;
        private System.Windows.Forms.TextBox EXdate;
        private System.Windows.Forms.TextBox CCnum;
        private System.Windows.Forms.Label isexpired;
    }
}