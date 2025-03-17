using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace DVLDSystem_WindowsForm_.User_Control
{
    public partial class ucPersonCard : UserControl
    {

        
        public ucPersonCard()
        {
            InitializeComponent();
        }


        [Browsable(true)]
        [Category("Misc")]
        [Description("this ID Person")]
        public string ID
        {
            get { return lblID.Text.ToString(); }
            set { lblID.Text = value; }
        }

        [Browsable(true)]
        [Category("Misc")]
        [Description("this ID Person Name")]
        public string PersonName
        {
            get { return lblName.Text.ToString(); }
            set { lblName.Text = value; }
        }

        [Browsable(true)]
        [Category("Misc")]
        [Description("this ID Notional No")]
        public string NotionalNo
        {
            get { return lblNationalNo.Text.ToString(); }
            set { lblNationalNo.Text = value; }
        }

        [Browsable(true)]
        [Category("Misc")]
        [Description("this Gendor Person")]
        public string Gendor
        {
            get { return lblGendor.Text.ToString(); }
            set { lblGendor.Text = value; }
        }

        [Browsable(true)]
        [Category("Misc")]
        [Description("this Email Person")]
        public string Email
        {
            get { return lblEmail.Text.ToString(); }
            set { lblEmail.Text = value; }
        }

        [Browsable(true)]
        [Category("Misc")]
        [Description("this Address Person")]
        public string Address
        {
            get { return lblAddress.Text.ToString(); }
            set { lblAddress.Text = value; }
        }

        [Browsable(true)]
        [Category("Misc")]
        [Description("this DateOfBirth Person")]
        public string DateOfBirth
        {
            get { return lblDateOfBirth.Text.ToString(); }
            set { lblDateOfBirth.Text = value; }
        }


        [Browsable(true)]
        [Category("Misc")]
        [Description("this Phone Person")]
        public string Phone
        {
            get { return lblPhone.Text.ToString(); }
            set { lblPhone.Text = value; }
        }


        [Browsable(true)]
        [Category("Misc")]
        [Description("this Country Person")]
        public string Country
        {
            get { return lblCountry.Text.ToString(); }
            set { lblCountry.Text = value; }
        }

        [Browsable(true)]
        [Category("Misc")]
        [Description("this ID Person")]
        public  string pbImageLocation
        {
            set { pbImage.ImageLocation = value; }
        }


        [Browsable(true)]
        [Category("Misc")]
        [Description("this Picture Person")]
        public Image Picture
        {
            get { return pbImage.BackgroundImage; }
            set { pbImage.BackgroundImage = value; Invalidate(); } // Refresh when image is set
        }


        [Browsable(true)]
        [Category("Misc")]
        [Description("this PictureBackgroundLayout Person")]
        public ImageLayout PictureBackgroundLayout
        {
            get { return pbImage.BackgroundImageLayout; }
            set { pbImage.BackgroundImageLayout = value; Invalidate(); }
        }
    }
}
