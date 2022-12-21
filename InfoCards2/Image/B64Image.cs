using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class B64Image : IInfoCard
    {
        //initialize forms and strings
        ImageEditForm editForm = null;
        ImageDisplayForm displayForm = null;

        private string _name;
        private string _image;
        private string _mode; //picurebox Mode

        //getters and setters
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }

        public string Mode
        {
            get { return _mode; }
            set { _mode = value; }
        }

        public B64Image()
        {
            Name = string.Empty;
            Image = string.Empty;
            Mode = string.Empty;
        }

        //splits saved data
        public B64Image(string savedData)
        {
            string[] strArr = savedData.Split('|');
            Name = strArr[1];
            Image = strArr[2];
            Mode = strArr[3];
        }
        //sets cattegory as Image
        public string Category => "Image";

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
            displayForm = new ImageDisplayForm();
            displayForm.DummyImage = this;                       //dummyimage placeholder in form
            displayForm.TopLevel = false;
            displayPanel.Controls.Add(displayForm);
            displayForm.FormBorderStyle = FormBorderStyle.None; //removes borders from the form
            displayForm.Dock = DockStyle.Fill;
            displayForm.Show();
        }

        public bool EditData()
        {
            bool edited = false;    //flag to return if the values were saved
            editForm = new ImageEditForm();
            editForm.DummyImage = this;
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                Name = editForm.DummyImage.Name;
                Image = editForm.DummyImage.Image;
                Mode = editForm.DummyImage.Mode;
                edited = true;
            }
            return edited;
        }

        public string GetDataAsString()
        {
            string dataAsString = (Category + "|" + Name + "|" + Image + "|" + Mode);
            return dataAsString;
        }
    }
}
