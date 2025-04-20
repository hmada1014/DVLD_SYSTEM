using DVLDSystem_BusinessLayer_;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDSystem_WindowsForm_.Application_Forms
{
    public partial class frmEditApplicationType : Form
    {
        private enum enMode { Update =1 ,Empty}
        private enMode _Mode = enMode.Update;
        private int _ID;

        private clsApplicationTypes _ApplicationTypes;
        public frmEditApplicationType(int iD)
        {
            InitializeComponent();
            _ID = iD;
            
            if (_ID <= 0)
            {
                _Mode = enMode.Empty;
            }
            else
            {
                _Mode = enMode.Update;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void _LoadData()
        {
            if (_Mode == enMode.Empty)
            {
                return;
            }

            _ApplicationTypes = clsApplicationTypes.Find(_ID);

            if (_ApplicationTypes == null)
            {
                MessageBox.Show("this page will colse becuese no Application Types found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (_Mode == enMode.Update)
            {
                _FillApplicationTypeForm();
            }
        }

        private void _FillApplicationTypeForm()
        {
            lblID.Text = _ApplicationTypes.ApplicationTypeID.ToString();
            txtApplicationTypeTitle.Text = _ApplicationTypes.ApplicationTypeTitle;
            txtApplicationFees.Text = Convert.ToSingle( _ApplicationTypes.ApplicationFees).ToString();
        }
        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private bool IsEmpty(object sender)
        {
            Guna2TextBox txt = sender as Guna2TextBox;

            if (string.IsNullOrWhiteSpace(txt.Text.Trim()))
            {
                return false;
            }
            
            return true;

        }

        private bool IsValidForm()
        {
            bool Isvalid = true;

            Isvalid &= IsEmpty(txtApplicationFees);
            Isvalid &= IsEmpty(txtApplicationTypeTitle);

            return Isvalid;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!IsValidForm())
            {
                MessageBox.Show("Please fill all required fields Correctly before saving.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _FillApplicationType();
            _SaveApplicationType();
        }

        private void _SaveApplicationType()
        {
            if (_ApplicationTypes.Save())
            {
                MessageBox.Show("Application Type was saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
                lblID.Text = _ApplicationTypes.ApplicationTypeID.ToString();
                txtApplicationTypeTitle.Text = _ApplicationTypes.ApplicationTypeTitle.ToString();
                txtApplicationFees.Text = _ApplicationTypes.ApplicationFees.ToString();

            }
            else
            {
                MessageBox.Show("Application Type was not saved Successfully", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _FillApplicationType()
        {
            _ApplicationTypes.ApplicationTypeTitle = txtApplicationTypeTitle.Text;
            _ApplicationTypes.ApplicationFees = Convert.ToDecimal(txtApplicationFees.Text);
        }

        private void txtApplicationFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Prevent input
            }

            // Ensure only one decimal point is allowed
            if (e.KeyChar == '.' && (sender as Guna.UI2.WinForms.Guna2TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtApplicationTypeTitle_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox txt = sender as Guna2TextBox;
            if (string.IsNullOrWhiteSpace(txt.Text.Trim()))
            {
                ep1.SetError(txt , "Required to fill.");
            }
            else
            {
                ep1.SetError(txt, string.Empty);
            }
        }
    }
}
