using DVLDSystem_BusinessLayer_;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DVLDSystem_WindowsForm_.People
{
    public partial class frmAddEditPeople : Form
    {
        private enum enMode { Add=1 ,Update=2}
        private enMode _Mode = enMode.Add;

        private int _ID;
        private clsPerson _CurrentPerson;
        public frmAddEditPeople(int ID)
        {
            InitializeComponent();
            _ID = ID;
            if (_ID == -1)
            {
                _Mode = enMode.Add;
            }
            else
            {
                _Mode = enMode.Update;
            }

        }

        private void _LoadCountriesListInComboBox()
        {
            DataTable dtCountriesList = clsCountry.GetAllCountries().Table;
            foreach (DataRow drCountry in dtCountriesList.Rows)
            {
                cbCountry.Items.Add(drCountry["CountryName"]);
            }
        }
        private void _LoadData()
        {
            _LoadCountriesListInComboBox();
            cbCountry.SelectedIndex = 0;
            cbGender.SelectedIndex = 0;


            if (_Mode == enMode.Add)
            {
                lblTitleHeader.Text = "Add New Person";
                _CurrentPerson = new clsPerson();
                return;
            }

            _CurrentPerson = clsPerson.Find(_ID);

            if (_CurrentPerson == null)
            {
                MessageBox.Show("this page will colse becuese no Person found ", "Error Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }


            if (_Mode == enMode.Update)
            {
                lblTitleHeader.Text = "Update ID : "+_CurrentPerson.PersonID.ToString();
                lblPersonID.Text = _CurrentPerson.PersonID.ToString();
                txtNationalNo.Text = _CurrentPerson.NationalNo.ToString();
                txtFirstName.Text = _CurrentPerson.FirstName.ToString();
                txtSecondName.Text = _CurrentPerson.SecondName.ToString(); 
                txtThirdName.Text = _CurrentPerson.ThirdName.ToString(); 
                txtLastName.Text = _CurrentPerson.LastName.ToString();
                dtpDateOfBirth.Text = _CurrentPerson.DateOfBirth.ToString();
                cbGender.Text = _CurrentPerson.Gender == 0 ? "Male" : "Female";
                txtAddress.Text = _CurrentPerson.Address.ToString();
                txtPhone.Text = _CurrentPerson.Phone.ToString();
                txtEmail.Text = _CurrentPerson.Email.ToString();
                cbCountry.SelectedIndex = cbCountry.FindString( clsCountry.Find(_CurrentPerson.NationalityCountryID).CountryName);
                if (_CurrentPerson.ImagePath != string.Empty && _CurrentPerson.ImagePath != " ")
                {
                    pbImage.ImageLocation = _CurrentPerson.ImagePath;
                }

                lblLinkRemoveImage.Visible = (_CurrentPerson.ImagePath != string.Empty);
            }
        }
        private void frmAddEditPeople_Load(object sender, EventArgs e)
        {
             _LoadData();
        }
        private void _lblLinkAddImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using(OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFile.Title = "Select an Image";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    pbImage.ImageLocation = openFile.FileName;
                    MessageBox.Show($"Image selected: {pbImage.ImageLocation}", "Image Location");
                    lblLinkRemoveImage.Visible = true;
                }
            }

        }
        private void _lblLinkRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pbImage.ImageLocation != null)
            {
                pbImage.ImageLocation = null;
                lblLinkRemoveImage.Visible=false;
            }
        }
        private void _ValidateEmptyOrNull(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Guna2TextBox textBox = sender as Guna2TextBox; 
            if (string.IsNullOrEmpty(textBox.Text.Trim()))
            {
                
               e.Cancel = true;
                ep1.SetError(textBox, "This field is required.");
            }
            else
            {
                ep1.SetError(textBox,string.Empty);
            }

        }
        private bool _ValidateNationalNo(Guna2TextBox textBox, string errorMessage, string errorMessage2)
        {
            if (clsPerson.IsPersonExist(textBox.Text.Trim()))
            {
                ep1.SetError(textBox, errorMessage2);
                return false;
            }
            else if (!clsValidation.CustomValid(textBox.Text.Trim() , @"^\w+([\-\s\/]\w+)*$"))
            {
                ep1.SetError(textBox, errorMessage);
                return false;
            }
            else
            {
                return true;
            }

        }
        private bool _ValidateName(Guna2TextBox textBox,  string errorMessage)
        {
            if (!clsValidation.IsValidName(textBox.Text.Trim()))
            {
                ep1.SetError(textBox, errorMessage);
                return false;
            }
            else
            {
                ep1.SetError(textBox, "");
                return true;
            }
        }
        private bool _ValidateAddress(Guna2TextBox textBox, string errorMessage)
        {
     
            if (!clsValidation.CustomValid(textBox.Text.Trim(), @"^[\w\s.,#\-\/]{6,}$"))
            {
                ep1.SetError(textBox, errorMessage);
                return false;
            }
            else
            {
                ep1.SetError(textBox, "");
                return true;
            }
        }
        private bool _ValidatePhone(Guna2TextBox textBox, string errorMessage )
        {

            if (!clsValidation.IsValidPhoneNumber(textBox.Text.Trim()))
            {
                ep1.SetError(textBox, errorMessage);
                return false;
            }
            else
            {
                ep1.SetError(textBox, "");
                return true;
            }
        }
        private bool _ValidateEmail(Guna2TextBox textBox, string errorMessage)
        {
            if (!clsValidation.IsValidEmail(textBox.Text.Trim()))
            {
                ep1.SetError(textBox, errorMessage);
                return false;
            }
            else
            {
                ep1.SetError(textBox, "");
                return true;
            }
        }
        private bool _ValidateImage(Guna2CirclePictureBox PictureBox, string errorMessageRequired)
        {
            if (string.IsNullOrWhiteSpace(PictureBox.ImageLocation.Trim()))
            {
                ep1.SetError(PictureBox, errorMessageRequired);
                return false;
            }
            else
            {
                ep1.SetError(PictureBox, "");
                return true;
            }
        }
        private bool _ValidateForm()
        {
            bool isValid = true;

            isValid &= _ValidateNationalNo(txtNationalNo, "it's allow latters , number,- /.", "this NationalNo is exists");
            isValid &= _ValidateName(txtFirstName, "it's only Latters.");
            isValid &= _ValidateName(txtSecondName, "it's only Latters.");
            isValid &= _ValidateName(txtLastName, "it's only Latters.");
            isValid &= _ValidateAddress(txtAddress, "At least 6 Latters");
            isValid &= _ValidatePhone(txtPhone, "it's only number and '+' is optonal  ");
            if (!string.IsNullOrEmpty(txtEmail.Text.Trim()))
                isValid &= _ValidateEmail(txtEmail, "wrong email example : example@example.com");
            

            return isValid;
        }
        private void _btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please fill all required fields before saving.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_ValidateForm())
            {
                _CurrentPerson.NationalNo = txtNationalNo.Text.Trim();
                _CurrentPerson.FirstName = txtFirstName.Text.Trim();
                _CurrentPerson.SecondName = txtSecondName.Text.Trim();
                _CurrentPerson.ThirdName = txtThirdName.Text.Trim();
                _CurrentPerson.LastName = txtLastName.Text.Trim();
                _CurrentPerson.DateOfBirth = dtpDateOfBirth.Value;
                _CurrentPerson.Gender = Convert.ToByte((cbGender.SelectedIndex == -1) ? 0 : cbGender.SelectedIndex);
                _CurrentPerson.Address = txtAddress.Text.Trim();
                _CurrentPerson.Phone = txtPhone.Text.Trim();
                _CurrentPerson.Email = txtEmail.Text.Trim();
                _CurrentPerson.NationalityCountryID = cbCountry.SelectedIndex == -1 ?0:cbCountry.SelectedIndex+1;
                if (pbImage.ImageLocation != null)
                {
                    _CurrentPerson.ImagePath = pbImage.ImageLocation;
                }
                else
                {
                    _CurrentPerson.ImagePath= null;
                }

                if (_CurrentPerson.Save())
                {
                    MessageBox.Show("Person was saved Successfully");
                }
                else
                {
                    MessageBox.Show("Person was not saved Successfully");
                }

                _Mode = enMode.Update;
                lblTitleHeader.Text = "Update ID : " + _CurrentPerson.PersonID.ToString();
                lblPersonID.Text = _CurrentPerson.PersonID.ToString();

            }
            else
            {
                MessageBox.Show("Please correct the validation errors before saving.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditPeople_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.AutoValidate = AutoValidate.Disable;
            }
        }

        //private void cbCountry_TextChanged(object sender, EventArgs e)
        //{
        //    ComboBox comboBox = sender as ComboBox;

        //    if (comboBox != null)
        //    {

        //        string Search = comboBox.Text;


        //        string[] allitem = comboBox.Items.Cast<string>().ToArray();

        //        var filteredItem = allitem.Where(item => item.StartsWith(Search, StringComparison.OrdinalIgnoreCase)).ToArray();

        //        comboBox.DataSource = filteredItem;
        //        comboBox.DroppedDown = true; 
        //        //comboBox.SelectedIndex = 0;
        //    }
        //}
    }
}
