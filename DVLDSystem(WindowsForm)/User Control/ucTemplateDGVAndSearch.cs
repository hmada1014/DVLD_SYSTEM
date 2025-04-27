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
        private enum enLDLApplicationStatus { New = 1 ,Canceled =2 , Completed =3}
        private enLDLApplicationStatus enLDLApplicationStatusMode;
        private enum enModeUC { ManageLDLApplication , People,Drivers,Users,Empty}
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
                case "frmManageLDLApplication":
                    _enMode = enModeUC.ManageLDLApplication;
                    dgvShowList.ContextMenuStrip = cmsLDLApplication;
                    _FillcbGeneralForStatusLDLApplication();
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

        /*########### Expose Properties of Controls in UserControl #######*/

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

        [Browsable(true)]
        [Category("Misc Controls Properties")]
        public string Records
        {
            get { return lblRrecords.Text; }
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]
        public DataGridViewColumnHeadersHeightSizeMode dgvColumnHeadersHeightSizeMode
        {
            get { return dgvShowList.ColumnHeadersHeightSizeMode; }
            set { dgvShowList.ColumnHeadersHeightSizeMode = value; }
            
        }
        


        //############################ UI Data Helper ######################
        public void RefreshDGV(object DataSours)
        {
            DataView dv = _ConvertToDataView(DataSours);
            if (dv == null) return;

            switch(_enMode)
            {
                case enModeUC.ManageLDLApplication:
                    dgvShowList.DataSource = dv;
                    _UpdateLDLApplicatinColumnHeaders();
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
        private void _UpdateLDLApplicatinColumnHeaders()
        {
            if (dgvShowList.Columns.Count <= 0) return;
            _SafeHeaderUpdate("LocalDrivingLicenseApplicationID", "L.D.LAppID");
            _SafeHeaderUpdate("ClassName", "Driving Class");
            _SafeHeaderUpdate("NationalNo", "National NO");
            _SafeHeaderUpdate("FullName", "Full Name");
            _SafeHeaderUpdate("ApplicationDate", "Application Date");
            _SafeHeaderUpdate("PassedTestCount", "Passed Test");
            _updateColumnsSizeForDLDApplication();
        }
        private void _updateColumnsSizeForDLDApplication()
        {
            if(dgvShowList.Columns.Count <= 0) return;
            _SafeHeaderSizeUpdate("LocalDrivingLicenseApplicationID", 100);
            _SafeHeaderSizeUpdate("ClassName", 230);
            _SafeHeaderSizeUpdate("NationalNo", 110);
            _SafeHeaderSizeUpdate("FullName", 230);
            _SafeHeaderSizeUpdate("ApplicationDate", 150);
            _SafeHeaderSizeUpdate("PassedTestCount", 120);
        }
        private void _SafeHeaderSizeUpdate(string ColumnName, int ColumnSize)
        {
            if (dgvShowList.Columns.Contains(ColumnName))
            {
                dgvShowList.Columns[ColumnName].Width = ColumnSize;
            }
        }
        private void _SafeHeaderUpdate(string ColumnName, string headerText)
        {
            if (dgvShowList.Columns.Contains(ColumnName))
            {
                dgvShowList.Columns[ColumnName].HeaderText = headerText;
            }
        }
        private int _ConvertSatusToInt(string Status)
        {
            if (Status == "New")
            {
                return 1;
            }
            else if (Status == "Cancelled")
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        /*############### for txtsearch ############################*/

        //--------------- Filter  DLDApplication ---------------------------
        private void _FillcbGeneralForStatusLDLApplication()
        {
            string[] Words = { "All", "New", "Cancelled","Completed" };
            cbGeneral.DataSource = Words;
        }
        private void _SearchLDLApplicationByLDLApplicationID(string LDLApplicationID)
        {
            DataTable dt = clsLocalDrivingLicenseApplication.SearchLDLApplicationByLDLApplicationID(LDLApplicationID).Table;
            if (dt.Rows.Count > 0)
            {
                dgvShowList.DataSource = dt;
                _UpdateLDLApplicatinColumnHeaders();
            }
            lblRrecords.Text = dgvShowList.RowCount.ToString();
        }
        private void _SearchLDLApplicationByNationalNo(string NationalNo)
        {
            DataTable dt = clsLocalDrivingLicenseApplication.SearchLDLApplicationByNationalNo(NationalNo).Table;
            if (dt.Rows.Count > 0)
            {
                dgvShowList.DataSource = dt;
                _UpdateLDLApplicatinColumnHeaders();
            }
            lblRrecords.Text = dgvShowList.RowCount.ToString();
        }
        private void _SearchLDLApplicationByFullName(string FullName)
        {
            DataTable dt = clsLocalDrivingLicenseApplication.SearchLDLApplicationByFullName(FullName).Table;
            if (dt.Rows.Count > 0)
            {
                dgvShowList.DataSource = dt;
                _UpdateLDLApplicatinColumnHeaders();
            }
            lblRrecords.Text = dgvShowList.RowCount.ToString();
        }
        private void _SearchLDLApplicationByStatus(int Status)
        {
            DataTable dt = clsLocalDrivingLicenseApplication.SearchLDLApplicationByStatus(Status).Table;
            if (dt.Rows.Count > 0)
            {
                dgvShowList.DataSource = dt;
                _UpdateLDLApplicatinColumnHeaders();
            }
            lblRrecords.Text = dgvShowList.RowCount.ToString();
        }
      
        //--------------- Filter  People ---------------------------
        private void _FillcbGeneralForGenderpeople()
        {
            string[] Words = { "All","Male", "Female" };
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
        private void _SearchPeopleByGender(string Gender)
        {
            DataTable dt;
            if (Gender == "Male")
                 dt = clsPerson.SearchPeopleByGender(0).Table;
            else
                 dt = clsPerson.SearchPeopleByGender(1).Table;

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

        //--------------- Filter User -----------------------------
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
            if( cbGeneral.Text == "Yes")
                dt = clsUser.SearchUserByIsActive(1, 1).Table;
            else
                dt = clsUser.SearchUserByIsActive(0, 0).Table;

            if (dt.Rows.Count > 0)
            {
                dgvShowList.DataSource = dt;
                _UpdateUserColumnHeaders();
            }
            lblRrecords.Text = dgvShowList.RowCount.ToString();
        }

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
                    if(cbGeneral.Text == "All")
                        _btnRefreshDGV_Click(null, null);
                    else
                    _SearchPeopleByGender(cbGeneral.Text);
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
                    if (cbGeneral.Text == "All")
                        _btnRefreshDGV_Click(null, null);
                    else
                        _SearchUserByIsActive();
                    break;
            }
        }
        private void _SearchDataByFilteringLDLApplication(string Text)
        {
            switch (cbFindBy.Text)
            {
                case "None":
                    break;
                case "L.D.LAppID":
                    _SearchLDLApplicationByLDLApplicationID(txtSearchDGV.Text.Trim());
                    break;
                case "National No":
                    _SearchLDLApplicationByNationalNo(txtSearchDGV.Text.Trim());
                    break;
                case "Full Name":
                    _SearchLDLApplicationByFullName(txtSearchDGV.Text.Trim());
                    break;
                case "Status":
                    if (cbGeneral.Text == "All")
                        _btnRefreshDGV_Click(null, null);
                    else
                        _SearchLDLApplicationByStatus(_ConvertSatusToInt(cbGeneral.Text));
                    break;
            }
        }

        /*########################### cmsLDLApplication ################################*/

        private void _DeleteLDLApplication()
        {
            int ID = Convert.ToInt32(dgvShowList.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value);
            if (clsLocalDrivingLicenseApplication.IsLocalDrivingLicenseApplicationExist(ID))
            {
                if (MessageBox.Show($"Are you suer you want to Delete LDLApplicationID : {ID}", "Delete LDLApplication", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    if (clsLocalDrivingLicenseApplication.DeleteLocalDrivingLicenseApplication(ID))
                    {
                        MessageBox.Show($"LDLApplication with ID : {ID} was Deleted Successfully", "Successfully deleted\r\n ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _btnRefreshDGV_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("LDLApplication was not deleted because it has data linked to it", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show($"LDLApplication with ID {ID} was not found", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*########################### cmsGeneralMenu ################################*/

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
            _btnRefreshDGV_Click(null, null);
        }
        private void _EditPerson()
        {
            if (int.TryParse(dgvShowList.CurrentRow.Cells["PersonID"].Value.ToString(), out int ID))
            {
                frmAddEditPeople editPeople = new frmAddEditPeople(ID);
                editPeople.ShowDialog();
                _btnRefreshDGV_Click(null,null);
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
                        _btnRefreshDGV_Click(null, null);
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
            _btnRefreshDGV_Click(null, null);
        }
        private void _EditUser()
        {
            if (int.TryParse(dgvShowList.CurrentRow.Cells["UserID"].Value.ToString(), out int ID))
            {
                frmAddEditeUser editeUser = new frmAddEditeUser(ID);
                editeUser.ShowDialog();
                _btnRefreshDGV_Click(null, null);
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
                        _btnRefreshDGV_Click(null, null);
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
        private void _MenuForUser()
        {
            TSMChangePassword.Visible = true;
            TSSchangePassword.Visible = true;
        }

        //########################## events #####################################

        private void _txtSearchDGV_TextChanged(object sender, EventArgs e)
        {
            dgvShowList.DataSource = null;
            switch (_enMode)
            {
                case enModeUC.ManageLDLApplication:
                    _SearchDataByFilteringLDLApplication(txtSearchDGV.Text.Trim());
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
        private void _txtSearchDGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFindBy.Text == "Person ID" || cbFindBy.Text == "User ID" || cbFindBy.Text == "L.D.LAppID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
            }
        }
        private void _btnRefreshDGV_Click(object sender, EventArgs e)
        {
            txtSearchDGV.Clear();
            switch (_enMode)
            {
                case enModeUC.ManageLDLApplication:
                    RefreshDGV(clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications());
                    break;
                case enModeUC.People:
                    RefreshDGV(clsPerson.GetAllPersons());
                    break;
                case enModeUC.Drivers:

                    break;
                case enModeUC.Users:
                    RefreshDGV(clsUser.GetAllUsers());
                    break;
            }
        }
        private void _TSM_Refresh_Click(object sender, EventArgs e)
        {
            _btnRefreshDGV_Click(sender, e);
        }
        private void _TSMEditGeneral_Click(object sender, EventArgs e)
        {
            switch (_enMode)
            {
                case enModeUC.ManageLDLApplication:
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
        private void _TSMDeleteGeneral_Click(object sender, EventArgs e)
        {
            switch (_enMode)
            {
                case enModeUC.ManageLDLApplication:
                    _DeleteLDLApplication();
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
        private void _TSMShowDetailsGeneral_Click(object sender, EventArgs e)
        {
            switch (_enMode)
            {
                case enModeUC.ManageLDLApplication:
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
        private void _TSMAddNewGeneral_Click(object sender, EventArgs e)
        {
            switch (_enMode)
            {
                case enModeUC.People:
                    _AddNewPerson();
                    break;
                case enModeUC.Drivers:

                    break;
                case enModeUC.Users:
                    _AddNewUser();
                    break;
                case enModeUC.Empty:
                    break;
            }
        }
        private void _TSMSendEmailGeneral_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implement yet.", "info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void _TSMPhoneCallGeneral_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implement yet", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void _TSMChangePassword_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dgvShowList.CurrentRow.Cells["UserID"].Value.ToString(),out int UserID))
            {

                frmChangePasswordUser passwordUser = new frmChangePasswordUser(UserID);
                passwordUser.ShowDialog();

            } 
        }
        private void _TSMCancelApplicationl_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to cancel this LDLApplication \n{dgvShowList.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value}","Cancel Application",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes )
            {
                if (clsLocalDrivingLicenseApplication.UpdateApplicationStatus(Convert.ToInt32(enLDLApplicationStatus.Canceled),  Convert.ToInt32(dgvShowList.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value),DateTime.Now))
                {
                    MessageBox.Show("Application canceled successfully", "Canceled successfully", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    _btnRefreshDGV_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Application canceled Faild", "Canceled Faild", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
        private void _cbFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cbFindBy.Text == "None")
            {
                txtSearchDGV.Visible = false;
                cbGeneral.Visible = false;
                _btnRefreshDGV_Click(sender, e);
                return;
            }
            else txtSearchDGV.Visible = true;

            if (cbFindBy.Text == "Gendor" || cbFindBy.Text == "Is Active" || cbFindBy.Text == "Status")
            {
                txtSearchDGV.Visible = false;
                cbGeneral.Visible = true;
                cbGeneral.SelectedIndex = 0;
                _btnRefreshDGV_Click(sender, e);
                return;
            }
            else
            {
                txtSearchDGV.Visible = true;
                cbGeneral.Visible = false;
            }
            _btnRefreshDGV_Click(sender, e);

        }
        private void _cbGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            _txtSearchDGV_TextChanged(sender, e);
        }
        private void _CheckdgvShowListEmpty(DataGridView dataGrid ,CancelEventArgs e)
        {
            if (dataGrid.Rows.Count == 0)
            {
                e.Cancel = true;
                return;
            }
        }
        private void _CheckMousePosition(DataGridView dataGrid, CancelEventArgs e)
        {
            // Cursor.Position current mouse position 
            // Get mouse position relative to the DataGridView
            Point clientPoint = dataGrid.PointToClient(Cursor.Position);

            // Check if the click is on a valid row
            DataGridView.HitTestInfo hitTest = dataGrid.HitTest(clientPoint.X, clientPoint.Y);
            if (hitTest.Type != DataGridViewHitTestType.Cell || hitTest.RowIndex < 0)
            {
                e.Cancel = true;
            }
        }
        private void _cmsGeneralMenu_opening(object sender, CancelEventArgs e)
        {
            _CheckdgvShowListEmpty(dgvShowList,e);
            _CheckMousePosition(dgvShowList, e);
        }
        private void _cmsLDLApplication_Opening(object sender, CancelEventArgs e)
        {
            _CheckdgvShowListEmpty(dgvShowList, e);
            _CheckMousePosition(dgvShowList, e);
            _EnableAndDisableCmsLDLApplication(_GetApplicationStatus(Convert.ToInt16(dgvShowList.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value)));
        }


        private enLDLApplicationStatus _GetApplicationStatus(int LDLApplicationID)
        {
            int Status = clsLocalDrivingLicenseApplication.Find(Convert.ToInt32(dgvShowList.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value)).ApplicationStatus;
            
            switch (Status)
            {
                case 1:
                    return enLDLApplicationStatus.New;
                case 2:
                    return enLDLApplicationStatus.Canceled;
                default:
                    return enLDLApplicationStatus.Completed;
            }
        }
        private void _EnableAndDisableMenuCompletedStatus()
        {
            TSMShowLicenseApplication.Enabled = true;
            TSMShowPersonLicenseHistory.Enabled = true;
        }
        private void _EnableAndDisableMenuNewStatus()
        {
            TSMEditApplication.Enabled = true;
            TSMDeleteApplication.Enabled = true;
            TSMCancelApplication.Enabled = true;
            TSMSechduleTests.Enabled = true;
            TSMShowPersonLicenseHistory.Enabled = true; 
        }
        private void _EnableAndDisableMenuCanceledStatus()
        {
            TSMDeleteApplication.Enabled = true;
            TSMShowPersonLicenseHistory.Enabled = true;
        }
        private void _ResetAllMenus()
        {
            TSMEditApplication.Enabled = false;
            TSMDeleteApplication.Enabled = false;
            TSMCancelApplication.Enabled = false;
            TSMSechduleTests.Enabled = false;
            TSMIssueDrivingLicenseFirstTimeApplication.Enabled = false;
            TSMShowLicenseApplication.Enabled = false;
            TSMShowPersonLicenseHistory.Enabled = false;
        }

        private void _EnableAndDisableCmsLDLApplication(enLDLApplicationStatus status)
        {
            _ResetAllMenus();
            switch (status)
            {
                case enLDLApplicationStatus.New:
                    _EnableAndDisableMenuNewStatus();
                    break;
                case enLDLApplicationStatus.Canceled:
                    _EnableAndDisableMenuCanceledStatus();
                    break;
                case enLDLApplicationStatus.Completed:
                    _EnableAndDisableMenuCompletedStatus();
                    break;

            }
        }


        private void _dgvShowList_ShowDeitailsGeneral_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (_enMode)
            {
                case enModeUC.ManageLDLApplication:
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
