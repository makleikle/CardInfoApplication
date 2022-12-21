using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Assignment
{
    public partial class GiftCeditForm : Form
    {
        Regex noVert = new Regex(@"[|]"); //Regular expression for |
        private GiftCard _dummycard;      //Placeholder for object in form

        public GiftCard DummyCard
        {
            get { return _dummycard; }
            set { _dummycard = value; }
        }

        public GiftCeditForm()
        {
            InitializeComponent();
        }

        private void GiftCeditForm_Load(object sender, EventArgs e)
        {
            //bind object attributes to the textboxes
            CardName.Text = DummyCard.Name;
            Code.Text = DummyCard.Code;
            expMo.Text = DummyCard.ExpMo;
            expYr.Text = DummyCard.ExpYr;
            ammount.Text = DummyCard.Ammount;

            if (!string.IsNullOrEmpty(DummyCard.From))  //checks to see if the object attribute is empty to assing or not to
                cbFrom.Items.Add(DummyCard.From);       //cbFrom is From (from what company is the GiftCard) ComboBox
            cbFrom.Text = DummyCard.From;

            if (!string.IsNullOrEmpty(DummyCard.From))      //checks to see if the object attribute is empty to assing or not to
                cbCurrency.Items.Add(DummyCard.Currency);   //cbCurrency is the currency ComboBox
            cbCurrency.Text = DummyCard.Currency;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //check to see if card is expired
            string datenowY = DateTime.Today.ToString("yyyy");
            string datenowM = DateTime.Today.ToString("MM");
            Regex reg = new Regex(@"[^\d]"); //Regex that returns true for anything other than numbers
            //check for non-numbers in month year and ammount
            bool isValid = reg.IsMatch(expMo.Text) || reg.IsMatch(expYr.Text) || reg.IsMatch(ammount.Text);
            //check for | in Name and Code (cant be in the other ones because reg REGEX is going to match it)
            bool noVer = noVert.IsMatch(CardName.Text) || noVert.IsMatch(Code.Text);
            if (!noVer)
            {
                if (!isValid && !(string.IsNullOrEmpty(expMo.Text)) && !(string.IsNullOrEmpty(expYr.Text)) && !(string.IsNullOrEmpty(ammount.Text)))
                {
                    bool dateValid = false; //check for expired gift card
                    int intYrnow = Int32.Parse(datenowY);
                    int intMonow = Int32.Parse(datenowM);
                    int intExpMo = Int32.Parse(expMo.Text);
                    int intExpYr = Int32.Parse(expYr.Text);
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
                    //check for
                    //empty fields
                    //month range from 1-12
                    //year range current to 9999
                    if (string.IsNullOrEmpty(CardName.Text) || string.IsNullOrEmpty(Code.Text) || intExpMo < 1 || intExpMo > 12 || intExpYr > 9999 || !dateValid)
                    {
                        if (string.IsNullOrEmpty(CardName.Text) || string.IsNullOrEmpty(Code.Text) || string.IsNullOrEmpty(ammount.Text))
                            MessageBox.Show("All fields except Currency and Gift Card For must be filled", "Fild Not Valid");
                        else if (intExpMo > 12 || intExpMo < 1)
                            MessageBox.Show("Expiration Month can only range between 1-12", "Fild Not Valid");
                        else if (intExpYr > 9999)
                            MessageBox.Show("Expiration Year can range between current year and 9999", "Fild Not Valid");
                        else if (!dateValid)
                            MessageBox.Show("Gift Card is expired", "Expired Card");
                    }
                    else
                    {
                        //passed checks return attrubutes to the object
                        _dummycard.Name = CardName.Text;
                        _dummycard.Code = Code.Text;
                        _dummycard.ExpMo = expMo.Text;
                        _dummycard.ExpYr = expYr.Text;
                        _dummycard.Ammount = ammount.Text;
                        _dummycard.From = cbFrom.Text;
                        _dummycard.Currency = cbCurrency.Text;
                        this.DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                else { MessageBox.Show("Expiration Date and ammount can only be numbers and must be filled", "Fild Not Valid"); }
            }
            else { MessageBox.Show("Vertical slash | is an invalid character", "Invalid input"); }
        }

        private void btnAddCurrency_Click(object sender, EventArgs e)
        {
            //check for | in currencyAdd textbox
            bool noVert = this.noVert.IsMatch(cbCurrency.Text);
            if (!noVert)
            {
                cbCurrency.Items.Add(currencyAdd.Text);                 //adds custom currency
                cbCurrency.SelectedIndex = cbCurrency.Items.Count - 1;  //selects custom currency
            }
            else
                MessageBox.Show("Vertical slash is invalid character", "Invalid input");
        }

        private void btnAddFrom_Click(object sender, EventArgs e)
        {
            //check for | in fromAdd textbox
            bool noVert = this.noVert.IsMatch(cbFrom.Text);
            if (!noVert)
            {
                cbFrom.Items.Add(fromAdd.Text);                 //adds custom from
                cbFrom.SelectedIndex = cbFrom.Items.Count - 1;  //selects custom from
            }
            else
                MessageBox.Show("Vertical slash is invalid character", "Invalid input");
        }
    }
}
