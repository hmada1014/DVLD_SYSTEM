using DVLDSystem_BusinessLayer_;
using DVLDSystem_WindowsForm_.People;
using DVLDSystem_WindowsForm_.Properties;
using DVLDSystem_WindowsForm_.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDSystem_WindowsForm_
{
    public partial class frmSelectePerson : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);

        public event DataBackEventHandler DataBack;

        public event Action<int> OnPersonIDSelected;

        protected virtual void PersonIDSelected(int PersonID)
        {
            Action<int> Handler = OnPersonIDSelected;

            if (Handler != null)
            {
                Handler(PersonID);
            }
        }

        private clsPerson _Person;
        public frmSelectePerson()
        {
            InitializeComponent();
        }

        private void FillComboBox()
        {
            cbFinder.Items.Add("Person ID");
            cbFinder.Items.Add("National No");
            cbFinder.SelectedIndex = 0;
        }
        private void frmSelectePerson_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }
        private clsPerson FindPerson()
        {
            switch (cbFinder.Text)
            {
                case "Person ID":
                    if (!int.TryParse(txtSearchAPerson.Text.Trim(), out int search))
                    {
                        search = -1;
                    }
                    _Person = clsPerson.Find(search);
                    break;
                case "National No":
                    _Person = clsPerson.Find(txtSearchAPerson.Text.Trim());
                    break;
            }
            return _Person;
        }
        private void FillPersonCard(clsPerson person)
        {
            if (person != null)
            {
                ucPersonCard3.ID = person.PersonID.ToString();
                ucPersonCard3.NotionalNo = person.NationalNo.ToString();
                ucPersonCard3.PersonName = (person.FirstName.ToString() + " " + person.SecondName.ToString() + " " + person.ThirdName.ToString() + " " + person.LastName.ToString()).ToString();
                ucPersonCard3.Gendor = (person.Gender == 0) ? "Male" : "Female";
                ucPersonCard3.Email = person.Email.ToString();
                ucPersonCard3.Address = person.Address.ToString();
                ucPersonCard3.DateOfBirth = person.DateOfBirth.ToString();
                ucPersonCard3.Phone = person.Phone.ToString();
                ucPersonCard3.Country = clsCountry.Find(person.NationalityCountryID).CountryName.ToString();
                if (person.ImagePath != null && person.ImagePath != "")
                {
                    Image img = Image.FromFile(person.ImagePath);
                    if (img != null)
                    {
                        ucPersonCard3.Picture = ResizeImage(img, img.Width, img.Height);
                        ucPersonCard3.PictureBackgroundLayout = ImageLayout.Zoom;
                    }

                }
                else
                {
                    ucPersonCard3.Picture = (person.Gender == 0) ? Resources.person_man : Resources.person_woman;
                    ucPersonCard3.PictureBackgroundLayout = ImageLayout.Zoom;
                } 
            }
            else
            {
                MessageBox.Show("Person you search for not Exists", "Person Not Found");
                ucPersonCard3.ID = "???";
                ucPersonCard3.PersonName = "Empty Name";
                ucPersonCard3.NotionalNo = "????";
                ucPersonCard3.Gendor = "???";
                ucPersonCard3.Email = "???";
                ucPersonCard3.Address = "???";
                ucPersonCard3.DateOfBirth = "???";
                ucPersonCard3.Phone = "???";
                ucPersonCard3.Country = "???";
                ucPersonCard3.Picture = Resources.Account;
                ucPersonCard3.PictureBackgroundLayout = ImageLayout.Zoom;
            }

        }
        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            _Person = FindPerson();
            FillPersonCard(_Person);
        }
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPeople AddnewPerson = new frmAddEditPeople(-1);
            AddnewPerson.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_Person != null)
            {
                MessageBox.Show($"{_Person.PersonID}", "Person Selected");
                this.DataBack?.Invoke(this, _Person.PersonID); 
            }
            else
            {
                MessageBox.Show($" 0 ", "Person Selected");
                this.DataBack?.Invoke(this, 0);
            }

            this.Close();
        }

        private Image ResizeImage(Image img, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, width, height);
            }
            return bmp;
        }
    }
}
