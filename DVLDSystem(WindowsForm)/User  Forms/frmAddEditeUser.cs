using DVLDSystem_BusinessLayer_;
using DVLDSystem_WindowsForm_.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDSystem_WindowsForm_.User
{
    public partial class frmAddEditeUser : Form
    {
       private enum enMode { Add = 1, Update = 2 }
       private enMode _Mode = enMode.Add;

       private int _ID;
       private clsUser  _CurrenUser;
        public frmAddEditeUser(int id)
        {
            InitializeComponent();

            
            _ID = id;

            if (_ID==-1)
            {
                _Mode = enMode.Add;
            }
            else
            {
                _Mode = enMode.Update;  
            }
        }

        private void _LoadData()
        {
            if (_Mode==enMode.Add)
            {
                clsUser user1 = new clsUser();
                lblTitleHeader.Text = "Add New User";
                return;
            }

            _CurrenUser = clsUser.Find(_ID);

            if (_CurrenUser == null)
            {
                MessageBox.Show("this page will colse becuese no User found ", "Error User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (_Mode==enMode.Update)
            {
                lblTitleHeader.Text = "Update ID : " + _CurrenUser.UserID.ToString();
                clsPerson person = clsPerson.Find(_CurrenUser.PersonID);
                FillPersonCard(person);
                FillUserInfo(_CurrenUser);
            }
        }


        private void frmAddEditeUser_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
        private void btnSelectePerson_Click(object sender, EventArgs e)
        {
            frmSelectePerson selectePerson = new frmSelectePerson();
            selectePerson.DataBack += PersonCard;
            selectePerson.ShowDialog();
        }

        private void FillPersonCard(clsPerson person)
        {
            if (person != null)
            {
                ucPersonCard4.ID = person.PersonID.ToString();
                ucPersonCard4.PersonName = person.FullName;
                ucPersonCard4.NotionalNo = person.NationalNo;
                ucPersonCard4.Gendor = (person.Gender == 0) ? "Male" : "Female";
                ucPersonCard4.Email = person.Email;
                ucPersonCard4.Address = person.Address;
                ucPersonCard4.DateOfBirth = person.DateOfBirth.ToString();
                ucPersonCard4.Phone = person.Phone;
                ucPersonCard4.Country = clsCountry.Find(person.NationalityCountryID).CountryName;
                if (person.ImagePath != null && person.ImagePath != "")
                {
                    Image img = Image.FromFile(person.ImagePath);
                    if (img != null)
                    {
                        ucPersonCard4.Picture = ResizeImage(img, img.Width, img.Height);
                        ucPersonCard4.PictureBackgroundLayout = ImageLayout.Zoom;
                    }

                }
                else
                {
                    ucPersonCard4.Picture = (person.Gender == 0) ? Resources.person_man : Resources.person_woman;
                    ucPersonCard4.PictureBackgroundLayout = ImageLayout.Zoom;
                }
                lblPersonID.Text = person.PersonID.ToString();
            }
            else
            {
                ucPersonCard4.ID = "???";
                ucPersonCard4.PersonName = "Empty Name";
                ucPersonCard4.NotionalNo = "????";
                ucPersonCard4.Gendor = "???";
                ucPersonCard4.Email = "???";
                ucPersonCard4.Address = "???";
                ucPersonCard4.DateOfBirth = "???";
                ucPersonCard4.Phone = "???";
                ucPersonCard4.Country = "???";
                ucPersonCard4.Picture = Resources.Account;
                ucPersonCard4.PictureBackgroundLayout = ImageLayout.Zoom;
                lblPersonID.Text = "???";
            }
        }
        private void FillUserInfo(clsUser user)
        {
            lblUserID.Text = user.UserID.ToString();
            txtUsername.Text = user.UserName.ToString();
            txtPassword.Text = user.Password.ToString();
            ToggleSwitchISActive.Checked = user.IsActive;

            if (user.Permission != 0 )
            {
                if (IsAllChecked((user.Permission == -1)))
                    return;
                if(user.Permission == 1)
                    cbApplication.Checked = true;
                if (user.Permission == 2)
                    cbPeople.Checked = true;
                if(user.Permission==4)
                    cbDrivers.Checked = true;
                if(user.Permission ==8)
                    cbUsers.Checked = true;
            }
        }

        private bool IsAllChecked(bool all)
        {
            cbAllPermission.Checked = true;
            cbApplication.Checked = true;
            cbPeople.Checked = true;
            cbDrivers.Checked = true;
            cbUsers.Checked = true;
            return all;
        }

        private void PersonCard(object sender , int Personid)
        {
            clsPerson person = clsPerson.Find(Personid);
            FillPersonCard(person);
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
