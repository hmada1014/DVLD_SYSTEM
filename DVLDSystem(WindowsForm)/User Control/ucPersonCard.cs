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

        public string ID
        {
            get { return lblID.Text.ToString(); }
            set { lblID.Text = value; }
        }
        public string Name
        {
            get { return lblName.Text.ToString();}
            set { lblName.Text = value; }
        }
        public string NotionalNo
        {
            get { return lblName.Text.ToString(); }
            set { lblName.Text = value; }
        }
        public string Gendor
        {
            get { return lblGendor.Text.ToString(); }
            set { lblGendor.Text = value; }
        }
        public string Email
        {
            get { return lblEmail.Text.ToString(); }
            set { lblEmail.Text = value; }
        }
        public string Address
        {
            get { return lblAddress.Text.ToString(); }
            set { lblAddress.Text = value; }
        }
        public string DateOfBirth
        {
            get { return lblDateOfBirth.Text.ToString(); }
            set { lblDateOfBirth.Text = value; }
        }
        public string Phone
        {
            get { return lblPhone.Text.ToString(); }
            set { lblPhone.Text = value; }
        }
        public string Country
        {
            get { return lblCountry.Text.ToString(); }
            set { lblCountry.Text = value; }
        }
        public string Image
        {
            set {pbImage.ImageLocation = value;}
        }
        public Color CardbackgroundColor
        {
            set { this.BackColor = value; }
        }
    }
}
