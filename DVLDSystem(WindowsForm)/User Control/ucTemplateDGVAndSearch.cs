using DVLDSystem_BusinessLayer_;
using DVLDSystem_WindowsForm_.People;
using DVLDSystem_WindowsForm_.People__Forms;
using DVLDSystem_WindowsForm_.User;
using DVLDSystem_WindowsForm_.User__Forms;
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

namespace DVLDSystem_WindowsForm_.User_Control
{
    public partial class ucTemplateDGVAndSearch : UserControl
    {
        private string _FormName;
        private enum enModeUC { Application,People,Drivers,Users,Empty}
        private enModeUC _enMode = enModeUC.Empty;
        public ucTemplateDGVAndSearch()
        {
            InitializeComponent();
            
        }
        public ucTemplateDGVAndSearch(string FormName)
        {
            InitializeComponent();
            
            _FormName = FormName;
            switch (_FormName)
            {
                case "frmApplication":
                    _enMode = enModeUC.Application;
                    TSMAddNewGeneral.Text = "Add New Application";
                    break;
                case "frmPeople":
                    _enMode = enModeUC.People;
                    _FillcbGeneralForGenderpeople();
                    TSMAddNewGeneral.Text = "Add New Person";

                    break;
                case "frmDrivers":
                    _enMode = enModeUC.Drivers;
                    TSMAddNewGeneral.Text = "Add New Driver";

                    break;
                case "frmUsers":
                    _enMode = enModeUC.Users;
                    _FillcbGeneralForIsActiveUser();
                    _MenuForUser();
                    TSMAddNewGeneral.Text = "Add New User";

                    break;
            }
          
        }

        private void cmsEditDelete_opening(object sender ,CancelEventArgs e)
        {
            // Cancel the menu if there are no rows
            if (dgvShowList.Rows.Count == 0)
            {
                e.Cancel = true;
                return;
            }

            // Cursor.Position current mouse position 
            // Get mouse position relative to the DataGridView
            Point clientPoint = dgvShowList.PointToClient(Cursor.Position);
         
            // Check if the click is on a valid row
            DataGridView.HitTestInfo hitTest = dgvShowList.HitTest(clientPoint.X, clientPoint.Y);
            if (hitTest.Type != DataGridViewHitTestType.Cell|| hitTest.RowIndex < 0)
            {
                e.Cancel = true;
            }

        }

        //----------------- Expose Properties of Controls in UserControl----

        [Browsable(true)]
        [Category("Misc Controls Properties")]
        public Color dgvBackgroundColor
        {
            get { return dgvShowList.BackgroundColor; }
            set { dgvShowList.BackgroundColor = value;}
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]
        public DataGridViewAutoSizeRowsMode dgvAutoSizeRowsMode
        {
            get { return dgvShowList.AutoSizeRowsMode; }
            set { dgvShowList.AutoSizeRowsMode = value; }
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]
        public DataGridViewAutoSizeColumnsMode dgvAutoSizeColumnMode
        {
            get { return dgvShowList.AutoSizeColumnsMode; }
            set { dgvShowList.AutoSizeColumnsMode = value; }
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]
        public Point TextBoxLocation
        {
            get { return txtSearchDGV.Location; }
            set { txtSearchDGV.Location = value; }
        }
        //-------------------------- UI Data Helper --------------
        public void RefreshDGV(object DataSours)
        {
            DataView dv = _ConvertToDataView(DataSours);
            if (dv == null) return;

            switch(_enMode)
            {
                case enModeUC.Application:
                    break;
                case enModeUC.People:
                    dgvShowList.DataSource = dv ;
                    _UpdatePeopleColumnHeaders();
                    break;
                case enModeUC.Drivers:
                    break;
                case enModeUC.Users:
                    dgvShowList.DataSource = dv;
                    _UpdateUserColumnHeaders();
                    break;
            }

            lblRrecords.Text = dgvShowList.RowCount.ToString();
        }
        private DataView _ConvertToDataView(object DataSours)
        {
            if (DataSours is DataView)
            {
                return (DataView)DataSours;
            }
            else
            {
                return null;
            }
        }
        public void FillComboBox(object ob)
        {
            cbFindBy.DataSource = ob;
        }
        private void _UpdateUserColumnHeaders()
        {
            if (dgvShowList.Columns.Count <= 0) return;
            _SafeHeaderUpdate("UserID", "User ID");
            _SafeHeaderUpdate("PersonID", "Person ID");
            _SafeHeaderUpdate("FullName", "Full Name");
            _SafeHeaderUpdate("IsActive", "Is Active");

        }
        private void _UpdatePeopleColumnHeaders()
        {
            if (dgvShowList.Columns.Count <= 0) return;
            _SafeHeaderUpdate("PersonID", "Person ID");
            _SafeHeaderUpdate("NationalNo", "National No");
            _SafeHeaderUpdate("FirstName", "First Name");
            _SafeHeaderUpdate("SecondName", "Second Name");
            _SafeHeaderUpdate("ThirdName", "Third Name");
            _SafeHeaderUpdate("LastName", "Last Name");
            _SafeHeaderUpdate("LastName", "Last Name");
            _SafeHeaderUpdate("DateOfBirth", "Date Of Birth");
        }
        private void _SafeHeaderUpdate(string ColumnName, string headerText)
        {
            if (dgvShowList.Columns.Contains(ColumnName))
            {
                dgvShowList.Columns[ColumnName].HeaderText = headerText;
            }
        }
        private DataTable _ProcessPeopleGenderColumn(DataTable dt) 
        {
            if(dt.Columns.Count<=0)return dt;
            dt.Columns.Add("GenderNew", typeof(string));

            foreach (DataRow row in dt.Rows)
            {
                if (row["Gender"].ToString() == "0")
                {
                    row["GenderNew"] = "Male";
                }
                else if (row["Gender"].ToString() == "1")
                {
                    row["GenderNew"] = "Female";
                }
            }
            dt.Columns.Remove("Gender");
            dt.Columns["GenderNew"].ColumnName = "Gender";
            dt.Columns["Gender"].SetOrdinal(4);
            return dt;
        }

     

        //-------------------------------------------------------------


        //--------------- Filter By People ---------------------------
        private void _FillcbGeneralForGenderpeople()
        {
            string[] Words = { "Male", "Female" };
            cbGeneral.DataSource = Words;
        }
        private void _SearchPeopleByPersonID(string ID)
        {
            DataTable dt = clsPerson.SearchPeopleByPersonID(ID).Table;
            if (dt.Rows.Count > 0)
            {
                dgvShowList.DataSource = dt;
                _UpdatePeopleColumnHeaders();
            }
            lblRrecords.Text = dgvShowList.RowCount.ToString();
        }
        private void _SearchPeopleByNationalNo(string NationalNo)
        {
            DataTable dt = clsPerson.SearchPeopleByNationalNo(NationalNo).Table;
            if (dt.Rows.Count > 0)
            {
                dgvShowList.DataSource = dt;
                _UpdatePeopleColumnHeaders();
            }
            lblRrecords.Text = dgvShowList.RowCount.ToString();
        }
        private void _SearchPeopleByFirstName(string FirstName)
        {
            DataTable dt = clsPerson.SearchPeopleByFirstName(FirstName).Table;
            if (dt.Rows.Count > 0)
            {
                dgvShowList.DataSource = dt;
                _UpdatePeopleColumnHeaders();
            }
            lblRrecords.Text = dgvShowList.RowCount.ToString();
        }
        private void _SearchPeopleBySecondName(string FirstName)
        {
            DataTable dt = clsPerson.SearchPeopleByFirstName(FirstName).Table;
            if (dt.Rows.Count > 0)
            {
                dgvShowList.DataSource = dt;
                _UpdatePeopleColumnHeaders();
            }
            lblRrecords.Text = dgvShowList.RowCount.ToString();
        }
        private void _SearchPeopleByThirdName(string ThirdName)
        {
            DataTable dt = clsPerson.SearchPeopleByThirdName(ThirdName).Table;
            if (dt.Rows.Count > 0)
            {
                dgvShowList.DataSource = dt;
                _UpdatePeopleColumnHeaders();
            }
            lblRrecords.Text = dgvShowList.RowCount.ToString();
        }
        private void _SearchPeopleByLastName(string LastName)
        {
            DataTable dt = clsPerson.SearchPeopleByLastName(LastName).Table;
            if (dt.Rows.Count > 0)
            {
                dgvShowList.DataSource = dt;
                _UpdatePeopleColumnHeaders();
            }
            lblRrecords.Text = dgvShowList.RowCount.ToString();
        }
        private void _SearchPeopleByGender(byte Gender)
        {
            DataTable dt = clsPerson.SearchPeopleByGender(Gender).Table;
            if (dt.Rows.Count > 0)
            {
                dgvShowList.DataSource = dt;
                _UpdatePeopleColumnHeaders();
            }
            lblRrecords.Text = dgvShowList.RowCount.ToString();
        }
        private void _SearchPeopleByPhone(string Phone)
        {
            DataTable dt = clsPerson.SearchPeopleByPhone(Phone).Table;
            if (dt.Rows.Count > 0)
            {
                dgvShowList.DataSource = dt;
                _UpdatePeopleColumnHeaders();
            }
            lblRrecords.Text = dgvShowList.RowCount.ToString();
        }
        private void _SearchPeopleByEmail(string Email)
        {
            DataTable dt = clsPerson.SearchPeopleByEmail(Email).Table;
            if (dt.Rows.Count > 0)
            {
                dgvShowList.DataSource = dt;
                _UpdatePeopleColumnHeaders();
            }
            lblRrecords.Text = dgvShowList.RowCount.ToString();
        }
        private void _SearchPeopleByNationality(string Nationality)
        {
            DataTable dt = clsPerson.SearchPeopleByNationality(Nationality).Table;
            if (dt.Rows.Count > 0)
            {
                dgvShowList.DataSource = dt;
                _UpdatePeopleColumnHeaders();
            }
            lblRrecords.Text = dgvShowList.RowCount.ToString();
        }

        //------------------------------------------------------------


        //--------------- Filter By User -----------------------------
        private void _FillcbGeneralForIsActiveUser()
        {
            string[] Words = { "All", "Yes","No" };
            cbGeneral.DataSource = Words;
        }
        private void _SearchUserID(string ID)
        {
            dgvShowList.DataSource = clsUser.SearchUserByUserID(ID);
            _UpdateUserColumnHeaders();
            lblRrecords.Text = dgvShowList.RowCount.ToString();

        }
        private void _SearchUserByPersonID(string PersonID)
        {
            DataTable dt = clsUser.SearchUserByPersonID(PersonID).Table;
            if (dt.Rows.Count > 0)
            {
                dgvShowList.DataSource = dt;
                _UpdatePeopleColumnHeaders();
            }
            lblRrecords.Text = dgvShowList.RowCount.ToString();
        }
        private void _SearchUserByUserName(string UsenName)
        {
            DataTable dt = clsUser.SearchUserByUserName(UsenName).Table;
            if (dt.Rows.Count > 0)
            {
                dgvShowList.DataSource = dt;
                _UpdateUserColumnHeaders();
            }
            lblRrecords.Text = dgvShowList.RowCount.ToString();
        }
        private void _SearchUserByFullName(string FullName)
        {
            DataTable dt = clsUser.SearchUserByFullName(FullName).Table;
            if (dt.Rows.Count > 0)
            {
                dgvShowList.DataSource = dt;
                _UpdateUserColumnHeaders();
            }
            lblRrecords.Text = dgvShowList.RowCount.ToString();
        }
        private void _SearchUserByIsActive()
        {
            DataTable dt;
            if (cbGeneral.Text == "All" )
            {
                dt = clsUser.SearchUserByIsActive(0, 1).Table; 
            }
            else if( cbGeneral.Text == "Yes")
            {
                dt = clsUser.SearchUserByIsActive(1, 1).Table;
            }
            else
            {
                dt = clsUser.SearchUserByIsActive(0, 0).Table;
            }
            if (dt.Rows.Count > 0)
            {
                dgvShowList.DataSource = dt;
                _UpdateUserColumnHeaders();
            }
            lblRrecords.Text = dgvShowList.RowCount.ToString();
        }

        //------------------------------------------------------------

        //-------------- For _txtSearchDGV_TextChanged ---------------
        private void _SearchDataByFilteringPeople(string Text)
        {
            switch(cbFindBy.Text)
            {
                case "None":
                    break;
                case "Person ID":
                    _SearchPeopleByPersonID(txtSearchDGV.Text.Trim());
                    break;
                case "National No":
                    _SearchPeopleByNationalNo(txtSearchDGV.Text.Trim());
                    break;
                case "First Name":
                    _SearchPeopleByFirstName(txtSearchDGV.Text.Trim());
                    break;
                case "Second Name":
                    _SearchPeopleBySecondName(txtSearchDGV.Text.Trim());
                    break;
                case "Third Name":
                    _SearchPeopleByThirdName(txtSearchDGV.Text.Trim());
                    break;
                case "Last Name":
                    _SearchPeopleByLastName(txtSearchDGV.Text.Trim());
                    break;
                case"Nationality":
                    _SearchPeopleByNationality(txtSearchDGV.Text.Trim());
                    break;
                case "Gendor":
                    _SearchPeopleByGender(Convert.ToByte(cbGeneral.SelectedIndex));
                    break;
                case "Phone":
                    _SearchPeopleByPhone(txtSearchDGV.Text.Trim());
                    break;
                case "Email":
                    _SearchPeopleByEmail(txtSearchDGV.Text.Trim()); 
                    break;
            }
        }
        private void _SearchDataByFilteringUsers(string Text)
        {
            switch(cbFindBy.Text)
            {
                case "None":
                    break;
                case "User ID":
                    _SearchUserID(txtSearchDGV.Text.Trim());
                    break;
                case "UserName":
                    _SearchUserByUserName(txtSearchDGV.Text.Trim());
                    break;
                case "Person ID":
                    _SearchUserByPersonID(txtSearchDGV.Text.Trim());
                    break;
                case "Full Name":
                    _SearchUserByFullName(txtSearchDGV.Text.Trim());
                    break;
                case "Is Active":
                    _SearchUserByIsActive();
                    break;
            }
        }
        //------------------------------------------------------------
        private void _txtSearchDGV_TextChanged(object sender, EventArgs e)
        {
            dgvShowList.DataSource = null;
            switch (_enMode)
            {
                case enModeUC.Application:
                    
                    break;
                case enModeUC.People:
                    _SearchDataByFilteringPeople(txtSearchDGV.Text.Trim());
                    break;
                case enModeUC.Drivers:
                   
                    break;
                case enModeUC.Users:
                    _SearchDataByFilteringUsers(txtSearchDGV.Text.Trim());
                    break;
                case enModeUC.Empty:
                    break;
            }

        }
        //-------------------------------------------------------------------
        private void btnRefreshDGV_Click(object sender, EventArgs e)
        {
            txtSearchDGV.Clear();
            switch (_FormName)
            {
                case "frmApplication":

                    break;
                case "frmPeople":
                    RefreshDGV(clsPerson.GetAllPersons());
                    break;
                case "frmDrivers":

                    break;
                case "frmUsers":
                    RefreshDGV(clsUser.GetAllUsers());
                    break;
            }
        }
        private void TSM_Refresh_Click(object sender, EventArgs e)
        {
            btnRefreshDGV_Click(sender, e);
        }

        //-------------------------Person Edit & Delete & show info & add new ---------------------
        private void _ShowPersonDeitails()
        {
            if (int.TryParse(dgvShowList.CurrentRow.Cells["PersonID"].Value.ToString(), out int ID))
            {
                frmShowPersonDetails personDetails = new frmShowPersonDetails(ID);
                personDetails.ShowDialog();
            }
            else
            {
                MessageBox.Show("Person Not Found to Show.", "warning");
            }
     
        }
        private void _AddNewPerson()
        {
            frmAddEditPeople addPerson = new frmAddEditPeople(-1);
            addPerson.ShowDialog();
            btnRefreshDGV_Click(null, null);
        }
        private void _EditPerson()
        {
            if (int.TryParse(dgvShowList.CurrentRow.Cells["PersonID"].Value.ToString(), out int ID))
            {
                frmAddEditPeople editPeople = new frmAddEditPeople(ID);
                editPeople.ShowDialog();
                btnRefreshDGV_Click(null,null);
            }
            else
            {
                MessageBox.Show("Person Not Found to Edit.", "Failed");
            }
        }
        private void _DeletePersone()
        {
            int ID = Convert.ToInt32(dgvShowList.CurrentRow.Cells["PersonID"].Value);
            if (clsPerson.IsPersonExist(ID))
            {
                if (MessageBox.Show($"Are you suer you want to Delete Person ID : {ID}", "Delete Person", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    if (clsPerson.DeletePerson(ID))
                    {
                        MessageBox.Show($"Person with ID : {ID} was Deleted Successfully", "Successfully deleted\r\n ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        btnRefreshDGV_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Person was not deleted because it has data linked to it", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show($"Person with ID {ID} was not found", "Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        //-------------------------------------------------------------------

        //-------------------------User Edit & Delete & show info -----------------------

        private void _ShowUserDeitails()
        {
            if (int.TryParse(dgvShowList.CurrentRow.Cells["UserID"].Value.ToString(), out int ID))
            {
                frmShowUserDetails userDetails = new frmShowUserDetails(ID);
                userDetails.ShowDialog();
            }
            else
            {
                MessageBox.Show("User Not Found to Show.", "warning");
            }

        }
        private void _AddNewUser()
        {
            frmAddEditeUser Adduser = new frmAddEditeUser(-1);
            Adduser.ShowDialog();
            btnRefreshDGV_Click(null, null);
        }
        private void _EditUser()
        {
            if (int.TryParse(dgvShowList.CurrentRow.Cells["UserID"].Value.ToString(), out int ID))
            {
                frmAddEditeUser editeUser = new frmAddEditeUser(ID);
                editeUser.ShowDialog();
                btnRefreshDGV_Click(null, null);
            }
            else
            {
                MessageBox.Show("User Not Found to Edit.", "warning");
            }
        }
        private void _DeleteUser()
        {
            int ID = Convert.ToInt32(dgvShowList.CurrentRow.Cells["UserID"].Value);
            if (clsUser.IsUserExist(ID))
            {
                if (MessageBox.Show($"Are you suer you want to Delete User ID : {ID}", "Delete User", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    if (clsUser.DeleteUser(ID))
                    {
                        MessageBox.Show($"User with ID : {ID} was Deleted Successfully", "Successfully deleted\r\n ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        btnRefreshDGV_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("User was not deleted because it has data linked to it", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show($"User with ID {ID} was not found", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-------------------------------------------------------------------

        //-------------------------------Custom menu for user-----------------------

        private void _MenuForUser()
        {
            TSMChangePassword.Visible = true;
            TSSchangePassword.Visible = true;
        }


        //-------------------------------------------------------------------

        private void EditGeneral_Click(object sender, EventArgs e)
        {
            switch (_enMode)
            {
                case enModeUC.Application:

                    break;
                case enModeUC.People:
                    _EditPerson();
                    break;
                case enModeUC.Drivers:

                    break;
                case enModeUC.Users:
                    _EditUser();
                    break;
                case enModeUC.Empty:
                    break;
            }
        }
        private void DeleteGeneral_Click(object sender, EventArgs e)
        {
            switch (_enMode)
            {
                case enModeUC.Application:

                    break;
                case enModeUC.People:
                    _DeletePersone();
                    break;
                case enModeUC.Drivers:

                    break;
                case enModeUC.Users:
                    _DeleteUser();
                    break;
                case enModeUC.Empty:
                    break;
            }
        }
        private void cbFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFindBy.Text == "None")
            {
                txtSearchDGV.Visible = false;
                cbGeneral.Visible = false;
                btnRefreshDGV_Click(sender, e);
                return;
            }
            else txtSearchDGV.Visible = true;

            if (cbFindBy.Text == "Gendor")
            {
                txtSearchDGV.Visible = false;
                cbGeneral.Visible = true;
                return;
            }
            else
            {
                txtSearchDGV.Visible = true;
                cbGeneral.Visible = false;
            }

            if (cbFindBy.Text == "Is Active")
            {
                txtSearchDGV.Visible = false;
                cbGeneral.Visible = true;
                return;
            }
            else
            {
                txtSearchDGV.Visible = true;
                cbGeneral.Visible = false;
            }

            btnRefreshDGV_Click(sender, e);

        }
        private void cbGendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            _txtSearchDGV_TextChanged(sender, e);
        }
        private void txtSearchDGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFindBy.Text == "Person ID" || cbFindBy.Text == "User ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
            }
        }
        private void TSMShowDetailsGeneral_Click(object sender, EventArgs e)
        {
            switch (_enMode)
            {
                case enModeUC.Application:

                    break;
                case enModeUC.People:
                    _ShowPersonDeitails();
                    break;
                case enModeUC.Drivers:

                    break;
                case enModeUC.Users:
                    _ShowUserDeitails();
                    break;
                case enModeUC.Empty:
                    break;
            }
        }
        private void TSMAddNewGeneral_Click(object sender, EventArgs e)
        {
            switch (_enMode)
            {
                case enModeUC.Application:

                    break;
                case enModeUC.People:
                    _AddNewPerson();
                    break;
                case enModeUC.Drivers:

                    break;
                case enModeUC.Users:

                    break;
                case enModeUC.Empty:
                    break;
            }
        }
        private void TSMSendEmailGeneral_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implement yet.", "info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void TSMPhoneCallGeneral_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implement yet", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void TSMChangePassword_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dgvShowList.CurrentRow.Cells["UserID"].Value.ToString(),out int UserID))
            {

                frmChangePasswordUser passwordUser = new frmChangePasswordUser(UserID);
                passwordUser.ShowDialog();

            } 
        }

        private void dgvShowList_ShowDeitails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (_enMode)
            {
                case enModeUC.Application:

                    break;
                case enModeUC.People:
                    _ShowPersonDeitails();
                    break;
                case enModeUC.Drivers:

                    break;
                case enModeUC.Users:
                    _ShowUserDeitails();
                    break;
                case enModeUC.Empty:
                    break;
            }
        }
    }
}
