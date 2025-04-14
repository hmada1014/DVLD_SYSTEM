using DVLDSystem_BusinessLayer_;
using DVLDSystem_WindowsForm_.People;
using DVLDSystem_WindowsForm_.User;
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
                    TSMAddNewGeneral.Text = "Add New Person";

                    break;
                case "frmDrivers":
                    _enMode = enModeUC.Drivers;
                    TSMAddNewGeneral.Text = "Add New Driver";

                    break;
                case "frmUsers":
                    _enMode = enModeUC.Users;
                    TSMAddNewGeneral.Text = "Add New User";

                    break;
            }
        }
        public DataGridView ShowDataGridView
        {
            get { return dgvShowList; }
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
        public object ShowComboBox
        {
            get { return cbFindBy.DataSource; }
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
            _SafeHeaderUpdate("Full_Name" , "Full Name");
            _SafeHeaderUpdate("UserName", "User Name");
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
                    _SearchPeopleByGender(Convert.ToByte(cbGendor.SelectedIndex));
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
                    break;
                case "UserName":
                    break;
                case "Person ID":
                    break;
                case "Full Name":
                    break;
                case "Is Active":
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
        private void _AddNewPerson()
        {
            frmAddEditPeople addPerson = new frmAddEditPeople(-1);
            addPerson.ShowDialog();
        }
        private void _ShowPersonDeitails()
        {
            if (int.TryParse(dgvShowList.CurrentRow.Cells["PersonID"].Value.ToString(), out int ID))
            {
                frmAddEditPeople Person = new frmAddEditPeople(ID);
                Person.ShowDialog();
            }
            else
            {
                MessageBox.Show("Person Not Found to Show.", "warning");
            }
     
        }
        private void _EditPerson()
        {
            if (int.TryParse(dgvShowList.CurrentRow.Cells["PersonID"].Value.ToString(), out int ID))
            {
                frmAddEditPeople editPeople = new frmAddEditPeople(ID);
                editPeople.ShowDialog();
            }
            else
            {
                MessageBox.Show("Person Not Found to Edit.", "warning");
            }
        }
        private void _DeletePersone()
        {
            int ID = Convert.ToInt32(dgvShowList.CurrentRow.Cells["PersonID"].Value);
            if (clsPerson.IsPersonExist(ID))
            {
                if (MessageBox.Show($"Are you suer you want to Delete Person ID : {ID}", "waring Delete Person", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    if (clsPerson.DeletePerson(ID))
                    {
                        MessageBox.Show($"Person with ID : {ID} was Deleted Successfully", "Successfully deleted\r\n ");
                    }
                    else
                    {
                        MessageBox.Show("Person was not deleted because it has data linked to it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show($"Person with ID {ID} was not found");
            }

        }
        //-------------------------------------------------------------------

        //-------------------------User Edit & Delete & show info -----------------------
      
        private void _EditUser()
        {
            if (int.TryParse(dgvShowList.CurrentRow.Cells["UserID"].Value.ToString(), out int ID))
            {
                frmAddEditeUser editeUser = new frmAddEditeUser(ID);
                editeUser.ShowDialog();
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
                if (MessageBox.Show($"Are you suer you want to Delete User ID : {ID}", "waring Delete User", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    if (clsUser.DeleteUser(ID))
                    {
                        MessageBox.Show($"User with ID : {ID} was Deleted Successfully", "Successfully deleted\r\n ");
                    }
                    else
                    {
                        MessageBox.Show("User was not deleted because it has data linked to it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show($"User with ID {ID} was not found");
            }
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
                cbGendor.Visible = false;
                btnRefreshDGV_Click(sender, e);
                return;
            }
            else txtSearchDGV.Visible = true;

            if (cbFindBy.Text == "Gendor")
            {
                txtSearchDGV.Visible = false;
                cbGendor.Visible = true;
                return;
            }
            else
            {
                txtSearchDGV.Visible = true;
                cbGendor.Visible = false;
            }

            btnRefreshDGV_Click(sender, e);

        }
        private void cbGendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            _txtSearchDGV_TextChanged(sender, e);
        }
        private void txtSearchDGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFindBy.Text == "Person ID")
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
    }
}
