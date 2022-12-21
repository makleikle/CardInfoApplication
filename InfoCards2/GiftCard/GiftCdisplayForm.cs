using System;
using System.Windows.Forms;

namespace Assignment
{
    public partial class GiftCdisplayForm : Form
    {
        private GiftCard _dummycard;    //placeholder for the object in form

        public GiftCard DummyCard
        {
            get { return _dummycard; }
            set { _dummycard = value; }
        }
        public GiftCdisplayForm()
        {
            InitializeComponent();
        }

        private void GiftCdisplayForm_Load(object sender, EventArgs e)
        {
            //check for expired card and load object attributes in form
            string datenowY = DateTime.Today.ToString("yyyy");
            string datenowM = DateTime.Today.ToString("MM");
            int intYrnow = Int32.Parse(datenowY);
            int intMonow = Int32.Parse(datenowM);
            CardName.Text = DummyCard.Name;
            Code.Text = DummyCard.Code;
            expDate.Text = DummyCard.ExpMo + "/" + DummyCard.ExpYr;
            int intExpMo = Int32.Parse(DummyCard.ExpMo);
            int intExpYr = Int32.Parse(DummyCard.ExpYr);
            if (intYrnow > intExpYr)
            {
                isExpired.Visible = true;
            }
            else if (intYrnow == intExpYr)
            {
                if (intMonow > intExpMo)
                {
                    isExpired.Visible = true;
                }
                else
                {
                    isExpired.Visible = false;
                }
            }
            else
            {
                isExpired.Visible = false;
            }
            ammountCurr.Text = DummyCard.Ammount + " " + DummyCard.Currency;
            from.Text = DummyCard.From;
        }
    }
}
