using System.Windows.Forms;

namespace Assignment
{
    public class CreditCard : IInfoCard
    {
        //Initialize forms and strings
        CreditCeditForm editForm = null;
        CreditCdisplayForm displayForm = null;
        private string _fullName;   //name on credit card
        private string expMonth;    //expiration month
        private string expYear;     //expiration year
        private string cardCode;
        private string cvv;
        private string name;        //credit card name

        //getters and setters
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        public string ExpMonth
        {
            get { return expMonth; }
            set { expMonth = value; }
        }
        public string ExpYear
        {
            get { return expYear; }
            set { expYear = value; }
        }

        public string CardCode
        {
            get { return cardCode; }
            set { cardCode = value; }
        }

        public string Cvv
        {
            get { return cvv; }
            set { cvv = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //initialize object attributes
        public CreditCard()
        {
            Name = string.Empty;
            CardCode = string.Empty;
            ExpMonth = string.Empty;
            expMonth = string.Empty;
            FullName = string.Empty;
            CardCode = string.Empty;
            Cvv = string.Empty;
        }

        //splitting string from txt file
        public CreditCard(string savedData)
        {
            string[] strArr = savedData.Split('|');
            FullName = strArr[1];
            Name = strArr[2];
            CardCode = strArr[3];
            ExpMonth = strArr[4];
            ExpYear = strArr[5];
            Cvv = strArr[6];
        }

        //setting category to CreditCard
        public string Category => "CreditCard";

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
            displayForm = new CreditCdisplayForm();
            displayForm.DummyCard = this;
            displayForm.TopLevel = false;
            displayPanel.Controls.Add(displayForm);
            displayForm.FormBorderStyle = FormBorderStyle.None; //removes borders from the display form
            displayForm.Dock = DockStyle.Fill;
            displayForm.Show();
        }

        public bool EditData()
        {
            bool edited = false;            //flag to return if anything in the object has been saved
            editForm = new CreditCeditForm();
            editForm.DummyCard = this;      //DummyCard is a placeholder for the getters and setter in the forms
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                Name = editForm.DummyCard.Name;
                FullName = editForm.DummyCard.FullName;
                CardCode = editForm.DummyCard.CardCode;
                ExpMonth = editForm.DummyCard.ExpMonth;
                ExpYear = editForm.DummyCard.ExpYear;
                Cvv = editForm.DummyCard.Cvv;
                edited = true;
            }
            return edited;
        }

        public string GetDataAsString()
        {
            string dataAsString = (Category + "|" + FullName + "|" + Name + "|" + CardCode + "|" + ExpMonth + "|" + ExpYear + "|" + Cvv);
            return dataAsString;
        }
    }
}
