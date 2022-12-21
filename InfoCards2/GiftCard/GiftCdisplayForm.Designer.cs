
namespace Assignment
{
    partial class GiftCdisplayForm
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
            this.CardName = new System.Windows.Forms.TextBox();
            this.Code = new System.Windows.Forms.TextBox();
            this.expDate = new System.Windows.Forms.TextBox();
            this.ammountCurr = new System.Windows.Forms.TextBox();
            this.from = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.isExpired = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GCname
            // 
            this.CardName.Location = new System.Drawing.Point(97, 35);
            this.CardName.Name = "GCname";
            this.CardName.ReadOnly = true;
            this.CardName.Size = new System.Drawing.Size(187, 20);
            this.CardName.TabIndex = 0;
            // 
            // GCcode
            // 
            this.Code.Location = new System.Drawing.Point(97, 61);
            this.Code.Name = "GCcode";
            this.Code.ReadOnly = true;
            this.Code.Size = new System.Drawing.Size(187, 20);
            this.Code.TabIndex = 1;
            // 
            // expDate
            // 
            this.expDate.Location = new System.Drawing.Point(97, 88);
            this.expDate.Name = "expDate";
            this.expDate.ReadOnly = true;
            this.expDate.Size = new System.Drawing.Size(187, 20);
            this.expDate.TabIndex = 2;
            // 
            // ammountCurr
            // 
            this.ammountCurr.Location = new System.Drawing.Point(97, 116);
            this.ammountCurr.Name = "ammountCurr";
            this.ammountCurr.ReadOnly = true;
            this.ammountCurr.Size = new System.Drawing.Size(187, 20);
            this.ammountCurr.TabIndex = 3;
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(97, 142);
            this.from.Name = "from";
            this.from.ReadOnly = true;
            this.from.Size = new System.Drawing.Size(187, 20);
            this.from.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gift Card Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gift Card Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Expiration Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ammount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gift Card For";
            // 
            // expired
            // 
            this.isExpired.AutoSize = true;
            this.isExpired.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.isExpired.ForeColor = System.Drawing.Color.Red;
            this.isExpired.Location = new System.Drawing.Point(128, 9);
            this.isExpired.Name = "expired";
            this.isExpired.Size = new System.Drawing.Size(55, 17);
            this.isExpired.TabIndex = 10;
            this.isExpired.Text = "Expired";
            // 
            // GiftCdisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 174);
            this.Controls.Add(this.isExpired);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.from);
            this.Controls.Add(this.ammountCurr);
            this.Controls.Add(this.expDate);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.CardName);
            this.Name = "GiftCdisplayForm";
            this.Text = "Gift Card Display";
            this.Load += new System.EventHandler(this.GiftCdisplayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CardName;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.TextBox expDate;
        private System.Windows.Forms.TextBox ammountCurr;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label isExpired;
    }
}