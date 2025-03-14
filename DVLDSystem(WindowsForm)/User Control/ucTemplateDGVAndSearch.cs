using DVLDSystem_BusinessLayer_;
using DVLDSystem_WindowsForm_.People;
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

            dgvShowList.DataSource = _ProcessPeopleGenderColumn(dv.Table);
            if (_enMode == enModeUC.People)
            {
                _UpdatePeopleColumnHeaders();
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
            _SafeHeaderUpdate("CountryName","Country Name");
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
        private void _SearchPeople(string ID)
        {
            DataTable dt = clsPerson.SearchPersonByPersonID(ID).Table;
            if (dt.Rows.Count > 0)
            {
                dgvShowList.DataSource = _ProcessPeopleGenderColumn(dt);
                _UpdatePeopleColumnHeaders();
            }
            lblRrecords.Text = dgvShowList.RowCount.ToString();
        }
        private void _SearchUser(string ID)
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
                    _SearchPeople(ID);
                    break;
                case enModeUC.Drivers:
                    
                    break;
                case enModeUC.Users:
                    _SearchUser(ID);
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
                case "Name":
                    
                    break;
                case " ": 
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
                if (MessageBox.Show("Are you suer you want to Delete Person", "waring Delete Person", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    if (clsPerson.DeletePerson(ID))
                    {
                        MessageBox.Show($"Person with ID {ID} was Deleted", "Successfully deleted\r\n ");
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
                    dgvShowList.DataSource = clsPerson.GetAllPersons();
                    break;
                case "frmDrivers":
                  
                    break;
                case "frmUsers":
                    
                    break;
            }
        }
    }
}
