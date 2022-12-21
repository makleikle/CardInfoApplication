using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Assignment
{
    public partial class ImageEditForm : Form
    {
        //initialize components
        Bitmap image;
        private bool flag;
        string b64image = string.Empty; //base64image string

        private B64Image _dummyimage; //placeholder for the object in class

        public B64Image DummyImage
        {
            get { return _dummyimage; }
            set { _dummyimage = value; }
        }
        public ImageEditForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG"; //filters for supported image formats
            dialog.CheckFileExists = true;                                      
            dialog.Multiselect = false;                                         //disabling multiselect
            if (dialog.ShowDialog() == DialogResult.OK)                         //image to base64 string
            {
                flag = true;
                image = new Bitmap(dialog.FileName);
                pictureBox.Image = (Image)image;
                byte[] imageArr = System.IO.File.ReadAllBytes(dialog.FileName);
                b64image = Convert.ToBase64String(imageArr);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Regex vert = new Regex(@"[|]"); //check for |
            bool novert = vert.IsMatch(Picname.Text);
            if (!novert)
            {
                if (string.IsNullOrEmpty(Picname.Text) || (string.IsNullOrEmpty(b64image) && string.IsNullOrEmpty(_dummyimage.Image))) //checks for non filled fields
                {
                    string dummyimage = _dummyimage.Image;
                    if (string.IsNullOrEmpty(Picname.Text) && (string.IsNullOrEmpty(b64image) && string.IsNullOrEmpty(dummyimage)))
                        MessageBox.Show("All fields must be filled", "Invalid Fields");
                    else if (string.IsNullOrEmpty(Picname.Text))
                        MessageBox.Show("Name Text Box must be filled", "Invalid Fields");
                    else if (string.IsNullOrEmpty(b64image) && string.IsNullOrEmpty(dummyimage))
                        MessageBox.Show("No picture detected", "Invalid Fields");
                }
                else
                {
                    //after passing the checks returns the attributes to the objects
                    _dummyimage.Name = Picname.Text;   
                    _dummyimage.Mode = cbMode.Text;
                    if (flag == true)  //checking if user is editing the picture or loading a new one
                        _dummyimage.Image = b64image;
                    this.DialogResult = DialogResult.OK;    //saves the attributes
                    Close();
                }
            }
            else
                MessageBox.Show("Vertical slash | is an invalid character", "Invalid input");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void cbMode_SelectedIndexChanged(object sender, EventArgs e) // adjasting picutrebox size mode
        {
            switch (cbMode.Text) //switch to change PictureBox Mode
            {
                case "Normal":
                    pictureBox.SizeMode = PictureBoxSizeMode.Normal;
                    break;
                case "Strech Image":
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Center Image":
                    pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case "Zoom":
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                default:
                    pictureBox.SizeMode = PictureBoxSizeMode.Normal;
                    break;
            }
        }

        private void ImageEditForm_Load(object sender, EventArgs e)
        {
            flag = false;                   
            Picname.Text = DummyImage.Name;
            if (!string.IsNullOrEmpty(DummyImage.Image)) //check for empty string in Image attribute to prevent exeptions when making a new object
            {
                // base64 string to image
                byte[] imArr = Convert.FromBase64String(DummyImage.Image);
                Image image;
                using (MemoryStream ms = new MemoryStream(imArr))
                {
                    image = Image.FromStream(ms);
                }
                pictureBox.Image = image;
            }
            switch (DummyImage.Mode) // loading picturebox sizemode
            {
                case "Normal":
                    pictureBox.SizeMode = PictureBoxSizeMode.Normal;
                    cbMode.SelectedIndex = 0;
                    break;
                case "Strech Image":
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    cbMode.SelectedIndex = 1;
                    break;
                case "Center Image":
                    pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                    cbMode.SelectedIndex = 2;
                    break;
                case "Zoom":
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    cbMode.SelectedIndex = 3;
                    break;
                default:
                    pictureBox.SizeMode = PictureBoxSizeMode.Normal;
                    cbMode.SelectedIndex = 0;
                    break;
            }

        }
    }
}
