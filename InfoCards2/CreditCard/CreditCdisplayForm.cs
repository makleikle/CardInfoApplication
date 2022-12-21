using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class CreditCdisplayForm : Form
    {
        private CreditCard dummyCard; //Placeholder object

        public CreditCard DummyCard
        {
            get { return dummyCard; }
            set { dummyCard = value; }
        }
        public CreditCdisplayForm()
        {
            InitializeComponent();
        }
        
        private void CCardEForm_Load(object sender, EventArgs e)
        {
            //check for expired card and pulling the object attributes
            string datenowY = DateTime.Today.ToString("yyyy");
            string datenowM = DateTime.Today.ToString("MM");
            int intYrnow = Int32.Parse(datenowY);
            int intMonow = Int32.Parse(datenowM);
            FName.Text = DummyCard.FullName;
            CCnum.Text = DummyCard.CardCode;
            EXdate.Text = (DummyCard.ExpMonth + "/" + DummyCard.ExpYear);
            int intExpMo = Int32.Parse(DummyCard.ExpMonth);
            int intExpYr = Int32.Parse(DummyCard.ExpYear);
            if (intYrnow > intExpYr)
            {
                isexpired.Visible = true;   //Expired Label
            }
            else if (intYrnow == intExpYr)
            {
                if (intMonow > intExpMo)
                {
                    isexpired.Visible = true;
                }
                else
                {
                    isexpired.Visible = false;
                }
            }
            else
            {
                isexpired.Visible = false;
            }

            CVV.Text = DummyCard.Cvv;
            CName.Text = DummyCard.Name;
        }
    }
}
