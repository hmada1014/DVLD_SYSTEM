using DVLDSystem_BusinessLayer_;
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

            DataView dv = ConvertToDataView(DataSours);
            if (dv == null) return;

            dgvShowList.DataSource = ProcessPeopleGenderColumn(dv.Table);
            if (_enMode == enModeUC.People)
            {
                UpdatePeopleColumnHeaders();
            }
            lblRrecords.Text = dgvShowList.RowCount.ToString();
        }
        private DataView ConvertToDataView(object DataSours)
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
        private void UpdateUserColumnHeaders()
        {
            if (dgvShowList.Columns.Count <= 0) return;
            SafeHeaderUpdate("UserID", "User ID");
            SafeHeaderUpdate("PersonID", "Person ID");
            SafeHeaderUpdate("Full_Name" , "Full Name");
            SafeHeaderUpdate("UserName", "User Name");
            SafeHeaderUpdate("IsActive", "Is Active");

        }
        private void UpdatePeopleColumnHeaders()
        {
            if (dgvShowList.Columns.Count <= 0) return;
            SafeHeaderUpdate("PersonID", "Person ID");
            SafeHeaderUpdate("NationalNo", "National No");
            SafeHeaderUpdate("FullName", "Full Name");
            SafeHeaderUpdate("DateOfBirth", "Date Of Birth");
            SafeHeaderUpdate("CountryName","Country Name");
            SafeHeaderUpdate("ImagePath", "ImagePath");
        }
        private void SafeHeaderUpdate(string ColumnName, string headerText)
        {
            if (dgvShowList.Columns.Contains(ColumnName))
            {
                dgvShowList.Columns[ColumnName].HeaderText = headerText;
            }
        }
        private DataTable ProcessPeopleGenderColumn(DataTable dt) 
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
        private void SearchPeople(string ID)
        {
            DataTable dt = clsPerson.SearchPersonByPersonID(ID).Table;
            if (dt.Rows.Count > 0)
            {
                dgvShowList.DataSource = ProcessPeopleGenderColumn(dt);
                UpdatePeopleColumnHeaders();
            }
            lblRrecords.Text = dgvShowList.RowCount.ToString();
        }
        private void SearchUser(string ID)
        {
            dgvShowList.DataSource = clsUser.SearchUserByUserID(ID);
            UpdateUserColumnHeaders();
            lblRrecords.Text = dgvShowList.RowCount.ToString();

        }
        private void SearchDataByID(string ID)
        {
            dgvShowList.DataSource = null;
            switch (_enMode)
            {
                case enModeUC.Application:

                    break;
                case enModeUC.People:
                    SearchPeople(ID);
                    break;
                case enModeUC.Drivers:
                    
                    break;
                case enModeUC.Users:
                    SearchUser(ID);
                    break;

            }
        }
        private void txtSearchDGV_TextChanged(object sender, EventArgs e)
        {
            switch (cbFindBy.Text)
            {
                case "ID":
                    SearchDataByID(txtSearchDGV.Text.Trim());
                    break;
                case "Name":
                    
                    break;
                case " ": 
                    break;
                case "  ":
                       
                    break;

            }

        }   
    }
}
