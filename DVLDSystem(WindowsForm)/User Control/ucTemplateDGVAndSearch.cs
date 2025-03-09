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
            dgvShowList.DataSource = DataSours;
        }
        private void changeHeaderNameForUser()
        {
            if (dgvShowList.Columns.Count > 0)
            {
                dgvShowList.Columns["UserID"].HeaderText = "User ID";
                dgvShowList.Columns["PersonID"].HeaderText = "Person ID";
                dgvShowList.Columns["Full_Name"].HeaderText = "Full Name";
                dgvShowList.Columns["UserName"].HeaderText = "User Name";
                dgvShowList.Columns["IsActive"].HeaderText = "Is Active"; 
            }
        }
        private DataTable changeColumnGendar(DataTable dt) 
        {
            dt.Columns.Add("GenderNew", typeof(string));

            foreach (DataRow row in dt.Rows)
            {
                if (row["Gender"].ToString()=="0")
                {
                    row["GenderNew"] = "Male";
                }
                else if(row["Gender"].ToString() == "1")
                {
                    row["GenderNew"] = "Female";
                }
            }
            dt.Columns.Remove("Gender");
            dt.Columns["GenderNew"].ColumnName = "Gender";
            return dt;
        
        
        }
        private void changeHeaderNameForPeople()
        {    
                dgvShowList.Columns["PersonID"].HeaderText = "Person ID";
                dgvShowList.Columns["NationalNo"].HeaderText = "National No";
                dgvShowList.Columns["FullName"].HeaderText = "Full Name";
                dgvShowList.Columns["DateOfBirth"].HeaderText = "Date Of Birth";
                dgvShowList.Columns["CountryName"].HeaderText = "Country Name";
                dgvShowList.Columns["ImagePath"].HeaderText = "Image Path";
        }
        private void SearchDataByID(string ID)
        {

            switch (_enMode)
            {
                case enModeUC.Application:

                    break;
                case enModeUC.People:
                    dgvShowList.DataSource = null;
                    DataTable dt = clsPerson.SearchPersonByPersonID(ID).Table;
                    if (dt.Rows.Count > 0)
                    {
                        dgvShowList.DataSource = changeColumnGendar(dt);
                        changeHeaderNameForPeople(); 
                    }
                    break;
                case enModeUC.Drivers:
                    
                    break;
                case enModeUC.Users:
                    dgvShowList.DataSource = clsUser.SearchUserByUserID(ID);
                    changeHeaderNameForUser();
                    break;

            }
        }
        private void txtSearchDGV_TextChanged(object sender, EventArgs e)
        {
            switch (_enMode)
            {
                case enModeUC.Application:
                    
                    break;
                case enModeUC.People:
                    SearchDataByID(txtSearchDGV.Text.Trim());
                    break;
                case enModeUC.Drivers: 
                    break;
                case enModeUC.Users:
                    SearchDataByID(txtSearchDGV.Text.Trim());   
                    break;

            }

        }
    }
}
