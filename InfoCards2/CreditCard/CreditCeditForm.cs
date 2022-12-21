using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Assignment
{
    public partial class CreditCeditForm : Form
    {
        public CreditCeditForm()
        {
            InitializeComponent();
        }

        private CreditCard dummyCard; //Object placeholder

        public CreditCard DummyCard
        {
            get { return dummyCard; }
            set { dummyCard = value; }
        }

        private void CCardForm_Load(object sender, EventArgs e)
        {   
            //Loading object attributes in the form
            FName.Text = DummyCard.FullName;
            CName.Text = DummyCard.Name;
            CCnum.Text = DummyCard.CardCode;
            CVV.Text = DummyCard.Cvv;
            ExpMo.Text = DummyCard.ExpMonth;
            ExpYr.Text = DummyCard.ExpYear;
        }




        private void btnSave_Click(object sender, EventArgs e)
        {
            string datenowY = DateTime.Today.ToString("yyyy");  //getting current year and month
            string datenowM = DateTime.Today.ToString("MM");
            Regex vert = new Regex(@"[|]");                     //returns true when | is macthed
            Regex reg = new Regex(@"[^\d]");                    //returns true for everything other than numbers
            bool isNValid = reg.IsMatch(ExpMo.Text) || reg.IsMatch(ExpYr.Text) || reg.IsMatch(CVV.Text) || reg.IsMatch(CCnum.Text); //check for non-numbers
            bool noVert = vert.IsMatch(FName.Text) || vert.IsMatch(CName.Text); //check for | 
            if (!noVert)
            {
                if (!isNValid && !(string.IsNullOrEmpty(ExpMo.Text)) && !(string.IsNullOrEmpty(ExpYr.Text)))
                {
                    bool dateValid = false;
                    int intYrnow = Int32.Parse(datenowY);   //cheking if card is expired
                    int intMonow = Int32.Parse(datenowM);
                    int intExpMo = Int32.Parse(ExpMo.Text);
                    int intExpYr = Int32.Parse(ExpYr.Text);
                    if (intYrnow > intExpYr)
                    { dateValid = false; }
                    else if (intYrnow == intExpYr)
                    {
                        if (intMonow > intExpMo)
                        { 
                            dateValid = false; 
                        } 
                        else
                        {
                            dateValid = true;
                        }
                    }
                    else
                    {
                        dateValid = true;
                    }
                    //check for:
                    //non filled fields
                    //containing only numbers for cvv to be 3 digits and card code to be 16 didits
                    //months to range from 1-12 and years from todays year up to 9999
                    //and if card is expired
                    if (string.IsNullOrEmpty(FName.Text) || string.IsNullOrEmpty(CName.Text) || string.IsNullOrEmpty(CCnum.Text) || string.IsNullOrEmpty(CVV.Text) || string.IsNullOrEmpty(ExpMo.Text) || string.IsNullOrEmpty(ExpYr.Text) || CVV.Text.Length != 3 || CCnum.Text.Length != 16 || intExpMo > 12 || intExpMo < 1 || intExpYr > 9999|| !dateValid)
                    {
                        if (string.IsNullOrEmpty(FName.Text) || string.IsNullOrEmpty(CName.Text) || string.IsNullOrEmpty(CCnum.Text) || string.IsNullOrEmpty(CVV.Text) || string.IsNullOrEmpty(ExpMo.Text) || string.IsNullOrEmpty(ExpYr.Text))
                            MessageBox.Show("All fields must be filled", "Fild Not Valid");
                        else if (CVV.Text.Length != 3)
                            MessageBox.Show("CCV can be a 3-digit number", "Fild Not Valid");
                        else if (CCnum.Text.Length != 16)
                            MessageBox.Show("Credit Card Number must be 16 digits long", "Fild Not Valid");
                        else if (intExpMo > 12 || intExpMo < 1)
                            MessageBox.Show("Expiration Month can only range between 1-12", "Fild Not Valid");
                        else if (intExpYr > 9999)
                            MessageBox.Show("Expiration Year can range between current year and 9999", "Fild Not Valid");
                        else if (!dateValid)
                            MessageBox.Show("Credit Card is expired", "Expired Card");

                    }
                    else
                    {
                        //if the inputs pass the checks return them to the objects attributs
                        dummyCard.FullName = FName.Text;
                        dummyCard.Name = CName.Text;
                        dummyCard.CardCode = CCnum.Text;
                        dummyCard.Cvv = CVV.Text;
                        dummyCard.ExpMonth = ExpMo.Text;
                        dummyCard.ExpYear = ExpYr.Text;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else { MessageBox.Show("Expiration Year and Month CCV and Credit Card number only be numbers and must be filled", "Fild Not Valid"); }
            }
            else { MessageBox.Show("Vertical slash | is an invalid character", "Invalid input"); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            {
                this.Dispose();
                this.Close();
            }
        }
    }
}

