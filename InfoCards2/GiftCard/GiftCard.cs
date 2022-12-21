using System;
using System.Windows.Forms;

namespace Assignment
{
    public class GiftCard : IInfoCard
    {
        //Initialize forms and strings
        GiftCeditForm editForm = null; 
        GiftCdisplayForm displayForm = null;
        private string _name;
        private string _code;
        private string _ammount;    //ammount of currency
        private string _expmo;
        private string _expyr;
        private string _from;       //where is that giftcard for
        private string _currency;   //type of currency

        //getters and setters
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }
        public string Ammount
        {
            get { return _ammount; }
            set { _ammount = value; }
        }

        public string ExpYr
        {
            get { return _expyr; }
            set { _expyr = value; }
        }
        public string ExpMo
        {
            get { return _expmo; }
            set { _expmo = value; }
        }
        public string From  
        {
            get { return _from; }
            set { _from = value; }
        }
        public string Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }

        //initialize object attributes
        public GiftCard()
        {
            Name = string.Empty;
            Code = string.Empty;
            Ammount = string.Empty;
            ExpYr = string.Empty;
            ExpMo = string.Empty;
            From = string.Empty;
            Currency = string.Empty;
        }

        //splitting string from txt file
        public GiftCard(string savedData)
        {
            string[] strArr = savedData.Split('|');
            Name = strArr[1];
            Code = strArr[2];
            Ammount = strArr[3];
            ExpYr = strArr[4];
            ExpMo = strArr[5];
            From = strArr[6];
            Currency = strArr[7];
        }

        //setting category to CreditCard
        public string Category => "GiftCard";

        public void CloseDisplay()
        {
            if (displayForm != null)
            {
                this.displayForm.Close();
                this.displayForm.Dispose();
                displayForm = null;
            }
        }

        public void DisplayData(Panel displayPanel)
        {
            displayForm = new GiftCdisplayForm();
            displayForm.DummyCard = this;
            displayForm.TopLevel = false;
            displayPanel.Controls.Add(displayForm);
            displayForm.FormBorderStyle = FormBorderStyle.None; //removes borders from the gift card display form
            displayForm.Dock = DockStyle.Fill;
            displayForm.Show();
        }

        public bool EditData()
        {
            bool edited = false;            //flag to retrun in case values have been saved
            editForm = new GiftCeditForm();
            editForm.DummyCard = this;      //DummyCard Placeholder for the object in form
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                Name = editForm.DummyCard.Name;
                Code = editForm.DummyCard.Code;
                Ammount = editForm.DummyCard.Ammount;
                ExpMo = editForm.DummyCard.ExpMo;
                ExpYr = editForm.DummyCard.ExpYr;
                Currency = editForm.DummyCard.Currency;
                From = editForm.DummyCard.From;
                edited = true;
            }
            return edited;
        }

        public string GetDataAsString()
        {
            string dataAsString = (Category + "|" + Name + "|" + Code + "|" + Ammount + "|" + ExpYr + "|" + ExpMo + "|" + From + "|" + Currency);
            return dataAsString;
        }
    }
}
