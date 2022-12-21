
namespace Assignment
{
    partial class CreditCeditForm
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
            this.FName = new System.Windows.Forms.TextBox();
            this.CCnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.CVV = new System.Windows.Forms.TextBox();
            this.ExpMo = new System.Windows.Forms.TextBox();
            this.ExpYr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FName
            // 
            this.FName.Location = new System.Drawing.Point(141, 220);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(193, 20);
            this.FName.TabIndex = 5;
            // 
            // CCnum
            // 
            this.CCnum.Location = new System.Drawing.Point(141, 91);
            this.CCnum.Name = "CCnum";
            this.CCnum.Size = new System.Drawing.Size(193, 20);
            this.CCnum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Credit Card Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Credit Card Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Expiration Month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Expiration Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "CVV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Full Name";
            // 
            // CName
            // 
            this.CName.Location = new System.Drawing.Point(141, 50);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(193, 20);
            this.CName.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(80, 293);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(304, 293);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CVV
            // 
            this.CVV.Location = new System.Drawing.Point(141, 179);
            this.CVV.Name = "CVV";
            this.CVV.Size = new System.Drawing.Size(100, 20);
            this.CVV.TabIndex = 4;
            // 
            // ExpMo
            // 
            this.ExpMo.Location = new System.Drawing.Point(141, 138);
            this.ExpMo.Name = "ExpMo";
            this.ExpMo.Size = new System.Drawing.Size(100, 20);
            this.ExpMo.TabIndex = 2;
            // 
            // ExpYr
            // 
            this.ExpYr.Location = new System.Drawing.Point(340, 138);
            this.ExpYr.Name = "ExpYr";
            this.ExpYr.Size = new System.Drawing.Size(100, 20);
            this.ExpYr.TabIndex = 3;
            // 
            // CCeditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 347);
            this.Controls.Add(this.ExpYr);
            this.Controls.Add(this.ExpMo);
            this.Controls.Add(this.CVV);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.CName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CCnum);
            this.Controls.Add(this.FName);
            this.Name = "CCeditForm";
            this.Text = "Credit Card Edit";
            this.Load += new System.EventHandler(this.CCardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FName;
        private System.Windows.Forms.TextBox CCnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox CVV;
        private System.Windows.Forms.TextBox ExpMo;
        private System.Windows.Forms.TextBox ExpYr;
    }
}