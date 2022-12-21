using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class ImageDisplayForm : Form
    {

        private B64Image _dummyimage;   //Placeholder for object in form

        public B64Image DummyImage
        {
            get { return _dummyimage; }
            set { _dummyimage = value; }
        }
        public ImageDisplayForm()
        {
            InitializeComponent();
        }

        private void ImageDisplayForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DummyImage.Image))
            {
                //base64 string to image
                byte[] imArr = Convert.FromBase64String(DummyImage.Image);
                Image image;
                using (MemoryStream ms = new MemoryStream(imArr))
                {
                    image = Image.FromStream(ms);
                }
                picBox.Image = image;
                switch (DummyImage.Mode) //picturebox mode application
                {
                    case "Normal":
                        picBox.SizeMode = PictureBoxSizeMode.Normal;
                        break;
                    case "Strech Image":
                        picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case "Center Image":
                        picBox.SizeMode = PictureBoxSizeMode.CenterImage;
                        break;
                    case "Zoom":
                        picBox.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    default:
                        picBox.SizeMode = PictureBoxSizeMode.Normal;
                        break;
                }
            }
        }
    }
}
