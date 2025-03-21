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
        private enum enModeUC { Application,People,Drivers,Users}
        private enModeUC _enMode = enModeUC.Application;
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
                    break;
                case "frmPeople":
                    _enMode = enModeUC.People;
                    _ShowToolStripMenuItemForPeple();
                    break;
                case "frmDrivers":
                    _enMode = enModeUC.Drivers;
                    break;
                case "frmUsers":
                    _enMode = enModeUC.Users;
                    _ShowToolStripMenuItemForUser();
                    break;
            }
        }
        public DataGridView ShowDataGridView
        {
            get { return dgvShowList; }
        }
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
            _SafeHeaderUpdate("FullName", "Full Name");
            _SafeHeaderUpdate("DateOfBirth", "Date Of Birth");
            _SafeHeaderUpdate("CountryName", "Nationality");
            _SafeHeaderUpdate("ImagePath", "ImagePath");
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
        //-------------------------------------------------
        private void _SearchPeopleID(string ID)
        {
            DataTable dt = clsPerson.SearchPersonByPersonID(ID).Table;
            if (dt.Rows.Count > 0)
            {
                dgvShowList.DataSource = dt;
                _UpdatePeopleColumnHeaders();
            }
            lblRrecords.Text = dgvShowList.RowCount.ToString();
        }
        private void _SearchUserID(string ID)
        {
            dgvShowList.DataSource = clsUser.SearchUserByUserID(ID);
            _UpdateUserColumnHeaders();
            lblRrecords.Text = dgvShowList.RowCount.ToString();

        }
        private void _SearchDataByID(string ID)
        {
            dgvShowList.DataSource = null;
            switch (_enMode)
            {
                case enModeUC.Application:

                    break;
                case enModeUC.People:
                    _SearchPeopleID(ID);
                    break;
                case enModeUC.Drivers:
                    
                    break;
                case enModeUC.Users:
                    _SearchUserID(ID);
                    break;

            }
        }
        private void _SearchPeopleNationalNo(string NationalNo)
        {
            DataTable dt = clsPerson.SearchPersonByNationalNo(NationalNo).Table;
            if (dt.Rows.Count > 0)
            {
                dgvShowList.DataSource = dt;
                _UpdatePeopleColumnHeaders();
            }
            lblRrecords.Text = dgvShowList.RowCount.ToString();
        }
        private void _SearchDataByNationalNo(string NationalNo)
        {
            dgvShowList.DataSource = null;
            switch (_enMode)
            {
                case enModeUC.Application:

                    break;
                case enModeUC.People:
                    _SearchPeopleNationalNo(NationalNo);
                    break;
                case enModeUC.Drivers:

                    break;
                case enModeUC.Users:
                    
                    break;

            }
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
        private void _SearchDataByPersonID(string PersonID)
        {
            dgvShowList.DataSource = null;
            switch (_enMode)
            {
                case enModeUC.Application:

                    break;
                case enModeUC.People:
                    
                    break;
                case enModeUC.Drivers:

                    break;
                case enModeUC.Users:
                    _SearchUserByPersonID(PersonID);
                    break;

            }
        }
        private void _txtSearchDGV_TextChanged(object sender, EventArgs e)
        {
            switch (cbFindBy.Text)
            {
                case "ID":
                    _SearchDataByID(txtSearchDGV.Text.Trim());
                    break;
                case "NationalNo":
                    _SearchDataByNationalNo(txtSearchDGV.Text.Trim());
                    break;
                case "PersonID":
                    _SearchDataByPersonID(txtSearchDGV.Text.Trim());
                    break;
                case "  ":
                       
                    break;

            }

        }
        private void _ShowToolStripMenuItemForPeple()
        {
            TSM_EditPerson.Visible = true;
            TSM_DeletePerson.Visible = true;
        }

        private void _ShowToolStripMenuItemForUser()
        {
            TSM_EditUser.Visible = true;
            TSM_DeleteUser.Visible = true;
        }
        private void editPersonTSM_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(dgvShowList.CurrentRow.Cells["PersonID"].Value.ToString(),out int ID))
            {
  
                frmAddEditPeople editPeople = new frmAddEditPeople(ID);
                editPeople.ShowDialog(); 
            }
            else
            {
                MessageBox.Show("Person Not Found to Edit.", "warning");
            }
        }
        private void deleteTSMPerson_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32( dgvShowList.CurrentRow.Cells["PersonID"].Value);
            if (clsPerson.IsPersonExist(ID))
            {
                if (MessageBox.Show($"Are you suer you want to Delete Person ID : {ID}", "waring Delete Person", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    if (clsPerson.DeletePerson(ID))
                    {
                        MessageBox.Show($"Person with ID : {ID} was Deleted Successfully", "Successfully deleted\r\n ");
                    }
                } 
            }
            else
            {
                MessageBox.Show($"Person with ID {ID} was not found");
            }

        }
        private void btnRefreshDGV_Click(object sender, EventArgs e)
        {
            txtSearchDGV.Clear();
            switch(_FormName)
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
            btnRefreshDGV_Click(sender,e);
        }
        private void TSM_DeleteUser_Click(object sender, EventArgs e)
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
                }
            }
            else
            {
                MessageBox.Show($"Person with ID {ID} was not found");
            }
        }
        private void TSM_EditUser_Click(object sender, EventArgs e)
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
    }
}
