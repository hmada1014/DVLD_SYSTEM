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

namespace DVLDSystem_WindowsForm_.Application_Forms
{
    public partial class frmEditTestType : Form
    {
        enum enMode { Update = 1 ,Empty = 2}
        enMode _Mode = enMode.Empty;
        private int _ID;

        private clsTestType _TestType;
        public frmEditTestType(int iD)
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
        private void _LoadData()
        {
            if (_Mode == enMode.Empty)
            {
                return;
            }

            _TestType = clsTestType.Find(_ID);

            if (_TestType == null)
            {
                MessageBox.Show("this page will colse becuese no Application Test Types found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (_Mode == enMode.Update)
            {
                _FillTestTypeForm();
            }
        }

        private void _FillTestTypeForm()
        {
            lblID.Text = _TestType.TestTypeID.ToString();
            txtTestTypeTitleTitle.Text = _TestType.TestTypeTitle;
            txtTestTypeDescription.Text =_TestType.TestTypeDescription;
            txtTestTypeFees.Text = Convert.ToSingle(_TestType.TestTypeFees).ToString();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
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

            Isvalid &= IsEmpty(txtTestTypeDescription);
            Isvalid &= IsEmpty(txtTestTypeTitleTitle);
            Isvalid &= IsEmpty(txtTestTypeFees);


            return Isvalid;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValidForm())
            {
                MessageBox.Show("Please fill all required fields Correctly before saving.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _FillTestType();
            _SaveTestType();
        }

        private void _FillTestType()
        {
            _TestType.TestTypeTitle = txtTestTypeTitleTitle.Text.Trim();
            _TestType.TestTypeDescription = txtTestTypeDescription.Text.Trim(); 
            _TestType.TestTypeFees = Convert.ToDecimal( txtTestTypeFees.Text.Trim());
        }

        private void _SaveTestType()
        {
            if (_TestType.Save())
            {
                MessageBox.Show("Test Type was saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
                lblID.Text = _TestType.TestTypeID.ToString();
                txtTestTypeDescription.Text = _TestType.TestTypeDescription.ToString();
                txtTestTypeTitleTitle.Text = _TestType.TestTypeTitle;
                txtTestTypeFees.Text = _TestType.TestTypeFees.ToString();

            }
            else
            {
                MessageBox.Show("Test Type was not saved Successfully", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void frmEditTestType_Load(object sender, EventArgs e)
        {
            _LoadData();

        }

        private void _CheckErrorProvied(object sender, CancelEventArgs e)
        {
            Guna2TextBox txt = sender as Guna2TextBox;
            if (string.IsNullOrWhiteSpace(txt.Text.Trim()))
            {
                ep1.SetError(txt, "Required to fill.");
            }
            else
            {
                ep1.SetError(txt, string.Empty);
            }
        }

        private void txtTestTypeFees_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
