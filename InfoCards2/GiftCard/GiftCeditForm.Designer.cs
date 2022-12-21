
namespace Assignment
{
    partial class GiftCeditForm
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
            this.expMo = new System.Windows.Forms.TextBox();
            this.expYr = new System.Windows.Forms.TextBox();
            this.ammount = new System.Windows.Forms.TextBox();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.fromAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddFrom = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.currencyAdd = new System.Windows.Forms.TextBox();
            this.btnAddCurrency = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CardName
            // 
            this.CardName.Location = new System.Drawing.Point(135, 35);
            this.CardName.Name = "CardName";
            this.CardName.Size = new System.Drawing.Size(300, 20);
            this.CardName.TabIndex = 0;
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(135, 71);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(300, 20);
            this.Code.TabIndex = 1;
            // 
            // expMo
            // 
            this.expMo.Location = new System.Drawing.Point(135, 106);
            this.expMo.Name = "expMo";
            this.expMo.Size = new System.Drawing.Size(141, 20);
            this.expMo.TabIndex = 2;
            // 
            // expYr
            // 
            this.expYr.Location = new System.Drawing.Point(300, 106);
            this.expYr.Name = "expYr";
            this.expYr.Size = new System.Drawing.Size(135, 20);
            this.expYr.TabIndex = 3;
            // 
            // ammount
            // 
            this.ammount.Location = new System.Drawing.Point(135, 153);
            this.ammount.Name = "ammount";
            this.ammount.Size = new System.Drawing.Size(65, 20);
            this.ammount.TabIndex = 4;
            // 
            // cbCurrency
            // 
            this.cbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Items.AddRange(new object[] {
            "Pounds",
            "Euros",
            "Dollars"});
            this.cbCurrency.Location = new System.Drawing.Point(224, 153);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(84, 21);
            this.cbCurrency.TabIndex = 5;
            // 
            // cbFrom
            // 
            this.cbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {
            "Amazon",
            "Google Play",
            "Ebay",
            "PlayStation Store",
            "Xbox"});
            this.cbFrom.Location = new System.Drawing.Point(135, 194);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(173, 21);
            this.cbFrom.TabIndex = 8;
            // 
            // fromAdd
            // 
            this.fromAdd.Location = new System.Drawing.Point(314, 195);
            this.fromAdd.Name = "fromAdd";
            this.fromAdd.Size = new System.Drawing.Size(90, 20);
            this.fromAdd.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Gift Card Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Gift Card Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Expiration Month/Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ammount/Currency";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Gift Card For";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(125, 249);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(273, 249);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddFrom
            // 
            this.btnAddFrom.Location = new System.Drawing.Point(410, 193);
            this.btnAddFrom.Name = "btnAddFrom";
            this.btnAddFrom.Size = new System.Drawing.Size(25, 23);
            this.btnAddFrom.TabIndex = 10;
            this.btnAddFrom.Text = "+";
            this.btnAddFrom.UseVisualStyleBackColor = true;
            this.btnAddFrom.Click += new System.EventHandler(this.btnAddFrom_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "/";
            // 
            // currencyAdd
            // 
            this.currencyAdd.Location = new System.Drawing.Point(314, 153);
            this.currencyAdd.Name = "currencyAdd";
            this.currencyAdd.Size = new System.Drawing.Size(90, 20);
            this.currencyAdd.TabIndex = 6;
            // 
            // btnAddCurrency
            // 
            this.btnAddCurrency.Location = new System.Drawing.Point(410, 151);
            this.btnAddCurrency.Name = "btnAddCurrency";
            this.btnAddCurrency.Size = new System.Drawing.Size(25, 23);
            this.btnAddCurrency.TabIndex = 7;
            this.btnAddCurrency.Text = "+";
            this.btnAddCurrency.UseVisualStyleBackColor = true;
            this.btnAddCurrency.Click += new System.EventHandler(this.btnAddCurrency_Click);
            // 
            // GiftCeditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 296);
            this.Controls.Add(this.btnAddCurrency);
            this.Controls.Add(this.currencyAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAddFrom);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromAdd);
            this.Controls.Add(this.cbFrom);
            this.Controls.Add(this.cbCurrency);
            this.Controls.Add(this.ammount);
            this.Controls.Add(this.expYr);
            this.Controls.Add(this.expMo);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.CardName);
            this.Name = "GiftCeditForm";
            this.Text = "Gift Card Edit";
            this.Load += new System.EventHandler(this.GiftCeditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CardName;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.TextBox expMo;
        private System.Windows.Forms.TextBox expYr;
        private System.Windows.Forms.TextBox ammount;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.TextBox fromAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox currencyAdd;
        private System.Windows.Forms.Button btnAddCurrency;
    }
}