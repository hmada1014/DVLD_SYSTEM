using DVLDSystem_BusinessLayer_;
using DVLDSystem_WindowsForm_.Properties;
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

namespace DVLDSystem_WindowsForm_.User
{
    public partial class frmAddEditeUser : Form
    {
        private enum enMode { Add = 1, Update = 2 }
        private enMode _Mode = enMode.Add;

        private int _ID;
        private int _PersonID;
        private clsUser _CurrenUser;
        public frmAddEditeUser(int id)
        {
            InitializeComponent();


            _ID = id;

            if (_ID == -1)
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
            if (_Mode == enMode.Add)
            {
                lblTitleHeader.Text = "Add New User";
                _CurrenUser  = new clsUser();
                return;
            }

            _CurrenUser = clsUser.Find(_ID);

            if (_CurrenUser == null)
            {
                MessageBox.Show("this page will colse becuese no User found ", "Error User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (_Mode == enMode.Update)
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
                if (!string.IsNullOrEmpty(person.ImagePath) && File.Exists(person.ImagePath))
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
                _PersonID = person.PersonID;
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
                _PersonID = 0;
            }
        }
        private void FillUserInfo(clsUser user)
        {
            lblUserID.Text = user.UserID.ToString();
            txtUsername.Text = user.UserName.ToString();
            txtPassword.Text = user.Password.ToString();
            ToggleSwitchISActive.Checked = user.IsActive;

            if (user.Permission != 0)
            {
                if (IsAllChecked((user.Permission == -1)))
                    return;
                if ((user.Permission & 1) == 1)
                    cbApplication.Checked = true;
                if ((user.Permission & 2)== 2)
                    cbPeople.Checked = true;
                if ((user.Permission&4) == 4)
                    cbDrivers.Checked = true;
                if ((user.Permission & 8 ) == 8)
                    cbUsers.Checked = true;
            }
        }
        private bool IsAllChecked(bool all)
        {
            cbAllPermission.Checked = all;
            cbApplication.Checked = all;
            cbPeople.Checked = all;
            cbDrivers.Checked = all;
            cbUsers.Checked = all;
            return all;
        }
        private void PersonCard(object sender, int Personid)
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
        private bool _ValidateForm()
        {
            bool isValid = true;

            if (_PersonID == 0)
            {
                ep.SetError(lblPersonID, "Choose a person");
                isValid = false;
            }
            else
            {
                ep.SetError(lblPersonID, string.Empty);

            }


            if (clsUser.IsUserExist(txtUsername.Text.Trim().ToLower()))
            {
                if (!clsUser.IsUserExist(txtUsername.Text.Trim().ToLower(), _CurrenUser.UserID.ToString(), ""))
                {
                    ep.SetError(txtUsername, "User is already exists.");
                    isValid = false;
                }
            }
            else
            {
                ep.SetError(txtUsername, string.Empty);

            }

            if ((cbAllPermission.Checked || cbApplication.Checked || cbPeople.Checked || cbDrivers.Checked
                || cbUsers.Checked) == false)
            {
                isValid = false;
                ep.SetError(groupBox1, "Require to choose one.");
            }
            else
            {
                ep.SetError(groupBox1, string.Empty);
            }

            return isValid;
        }
        private void txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox text = sender as TextBox;

            if (string.IsNullOrEmpty(text.Text))
            {
                e.Cancel = true;
                ep.SetError(text, "Require to fill.");
            }
            else
            {
                ep.SetError(text, string.Empty);
            }
        }
        private void cb_Validating(object sender, CancelEventArgs e)
        {
            
            if ((cbAllPermission.Checked || cbApplication.Checked || cbPeople.Checked || cbDrivers.Checked
                || cbUsers.Checked) == false)
            {
                e.Cancel = true;
                ep.SetError(groupBox1, "Require to choose one.");
            }
            else
            {
                ep.SetError(groupBox1, string.Empty);
            }
        }
        private int _GetUserPermission()
        {
            int Permission = 0;
            if (cbAllPermission.Checked)
                return -1;
            if (cbApplication.Checked)
                Permission += 1;
            if (cbPeople.Checked)
                Permission += 2;
            if (cbDrivers.Checked)
                Permission += 4;
            if (cbUsers.Checked)
                Permission += 8;
            

            return Permission;
        }
        private void _FillUserObject()
        {
            _CurrenUser.PersonID = Convert.ToInt32(lblPersonID.Text);
            _CurrenUser.UserName = txtUsername.Text.Trim().ToLower();
            _CurrenUser.Password = txtPassword.Text.Trim();
            _CurrenUser.IsActive = ToggleSwitchISActive.Checked;
            _CurrenUser.Permission = _GetUserPermission();
        }
        private void _SaveUser()
        {

            if (_CurrenUser.Save())
            {
                MessageBox.Show("Save successfully");

                _Mode = enMode.Update;
                lblTitleHeader.Text = $"Update ID {_CurrenUser.UserID}";
                lblUserID.Text = _CurrenUser.UserID.ToString();
            }
            else
            {
                MessageBox.Show("User Saved Failed.", "Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please fill all required fields before saving.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_ValidateForm())
            {
                _FillUserObject();
                _SaveUser();
            }
            else
            {
                MessageBox.Show("Please correct the validation errors before saving.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cbAllPermission_CheckedChanged(object sender, EventArgs e)
        {
            IsAllChecked(cbAllPermission.Checked);
        }
    }
}
