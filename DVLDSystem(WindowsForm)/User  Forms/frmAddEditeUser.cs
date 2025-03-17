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
            }
        }


        private void frmAddEditeUser_Click(object sender, EventArgs e)
        {

        }

        private void frmAddEditeUser_Load(object sender, EventArgs e)
        {
           // ucPersonCard1.pbImageLocation = "C:\\Users\\mohammed\\Desktop\\alll images\\photo_2024-03-10_22-39-01.jpg";

        }

        private void btnSelectePerson_Click(object sender, EventArgs e)
        {
            frmSelectePerson selectePerson = new frmSelectePerson();
            selectePerson.ShowDialog();
        }
    }
}
