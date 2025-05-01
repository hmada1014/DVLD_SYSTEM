using DVLDSystem_BusinessLayer_;
using DVLDSystem_WindowsForm_.Application_Forms;
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
using System.Web.Configuration;
using System.Windows.Forms;

namespace DVLDSystem_WindowsForm_.User_Control
{
    public partial class ucTemplateDGV : UserControl
    {
        private  enum enModeUC { ManageApplicationTypes = 1, ManageTestTypes = 2, VisionTestAppointments =3 , WritingTestAppointments = 4, StreetTestAppointments = 5, Empty }
        private  enModeUC _enMode = enModeUC.Empty;
        private string _FormName;
        public ucTemplateDGV()
        {
            InitializeComponent();
        }

        public ucTemplateDGV(string FormName)
        {
            InitializeComponent();

            _FormName = FormName;
            switch (_FormName)
            {
                case "frmManageApplicationTypes":
                    TSMEditApplicationType.Visible = true;
                    _enMode = enModeUC.ManageApplicationTypes; 
                    break;
                case "frmManageTestTypes":
                    TSMManageTestTypes.Visible = true;
                    _enMode = enModeUC.ManageTestTypes;
                    break;
                case "frmVisionTestAppointments":
                    _enMode = enModeUC.VisionTestAppointments;
                    break;
                case "frmWritingTestAppointments":
                    _enMode = enModeUC.WritingTestAppointments;
                    break;
                case "frmStreetTestAppointments":
                    _enMode = enModeUC.StreetTestAppointments;
                    break;
            }
        }

        /*########### Expose Properties of Controls in UserControl #######*/


        [Browsable(true)]
        [Category("Misc Controls Properties")]
        public DataGridViewAutoSizeColumnsMode dgvSizeColumnsMode
        {
            get { return dgvShowList.AutoSizeColumnsMode; }
            set { dgvShowList.AutoSizeColumnsMode = value; }
        }
        [Browsable(true)]
        [Category("Misc Controls Properties")]
        public string Rdcords
        {
            get { return lblRrecords.Text; }
        }
        [Browsable(true)]
        [Category("Misc Controls Properties")]
        public Color dgvColor
        {
            get { return dgvShowList.BackgroundColor; }
            set { dgvShowList.BackgroundColor = value; }
        }

        //############################ UI Data Helper ######################

        

        public void RefreshDGV(object DataSours)
        {
            DataView dv = _ConvertToDataView(DataSours);
            if (dv == null) return;

            switch (_enMode)
            {
                case enModeUC.ManageApplicationTypes:
                     dgvShowList.DataSource = dv;
                    _UpdateManageApplicationTypesColumnHeaders();
                    break;
                case enModeUC.ManageTestTypes:
                    dgvShowList.DataSource = dv;
                    _ResizeDgvForManageTestType();
                    _UpdateManageTestTypeColumnHeaders();
                    break;
                case enModeUC.VisionTestAppointments:
                    dgvShowList.DataSource = dv;
                    _UpdateAppointmentsColumnHeaders();
                    _ResizeDgvForAppointment();
                    break;
                case enModeUC.WritingTestAppointments:
                    dgvShowList.DataSource = dv;
                    _UpdateAppointmentsColumnHeaders();
                    _ResizeDgvForAppointment();
                    break;
                case enModeUC.StreetTestAppointments:
                    dgvShowList.DataSource = dv;
                    _UpdateAppointmentsColumnHeaders();
                    _ResizeDgvForAppointment();
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
        private void _SafeHeaderUpdate(string ColumnName, string headerText)
        {
            if (dgvShowList.Columns.Contains(ColumnName))
            {
                dgvShowList.Columns[ColumnName].HeaderText = headerText;
            }
        }

        private void _UpdateAppointmentsColumnHeaders()
        {
            _SafeHeaderUpdate("TestAppointmentID", "AppointmentID");
            _SafeHeaderUpdate("AppointmentDate", "Appointment Date");
            _SafeHeaderUpdate("PaidFees", "Paid Fees");
            _SafeHeaderUpdate("IsLocked", "Is Locked");

        }
        private void _UpdateManageApplicationTypesColumnHeaders()
        {
            _SafeHeaderUpdate("ApplicationTypeID", "ID");
            _SafeHeaderUpdate("ApplicationTypeTitle", "Title");
            _SafeHeaderUpdate("ApplicationFees", "Fees");
        }
        private void _UpdateManageTestTypeColumnHeaders()
        {
            _SafeHeaderUpdate("TestTypeID", "ID");
            _SafeHeaderUpdate("TestTypeTitle", "Title");
            _SafeHeaderUpdate("TestTypeDescription", "Description");
            _SafeHeaderUpdate("TestTypeFees", "Fees");
        }
        private void _ResizeDgvForManageTestType()
        {
            _SafeHeaderSizeUpdate("TestTypeDescription" ,300);
            _SafeHeaderSizeUpdate("TestTypeTitle", 135);
            _SafeHeaderSizeUpdate("TestTypeID", 50);
        }

        private void _ResizeDgvForAppointment()
        {
            _SafeHeaderSizeUpdate("TestAppointmentID", 200);
            _SafeHeaderSizeUpdate("AppointmentDate", 200);
            _SafeHeaderSizeUpdate("PaidFees", 175);
            _SafeHeaderSizeUpdate("IsLocked", 175);

        }

        private void _SafeHeaderSizeUpdate(string ColumnName, int ColumnSize)
        {
            if (dgvShowList.Columns.Contains(ColumnName))
            {
                dgvShowList.Columns[ColumnName].Width = ColumnSize;
            }
        }

        /*########################### cmsGeneralMenu ################################*/

        //-------------------_EditApplicationType --------------------------------
        private void _EditApplicationType()
        {
            if (int.TryParse(dgvShowList.CurrentRow.Cells["ApplicationTypeID"].Value.ToString(), out int ID))
            {
                frmEditApplicationType EditapplicationType = new frmEditApplicationType(ID);
                EditapplicationType.ShowDialog();
                TSMRefresh_Click(null,null);
            }
            else
            {
                MessageBox.Show("Application Type Not Found to Edit.", "Failed");
            }
        }
        //-------------------_EditTestType ---------------------------------------
        private void _EditTestType()
        {
            if (int.TryParse(dgvShowList.CurrentRow.Cells["TestTypeID"].Value.ToString(), out int ID))
            {
                frmEditTestType EditTestTypes = new frmEditTestType(ID);
                EditTestTypes.ShowDialog();
                TSMRefresh_Click(null, null);
            }
            else
            {
                MessageBox.Show("User Not Found to Edit.", "warning");
            }
        }

        //########################## events #####################################
        private void cmsGeneral_Opening(object sender, CancelEventArgs e)
        {
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
            if (hitTest.Type != DataGridViewHitTestType.Cell || hitTest.RowIndex < 0)
            {
                e.Cancel = true;
            }
        }
        private void TSMRefresh_Click(object sender, EventArgs e)
        {

            switch(_enMode)
            {
                case enModeUC.ManageApplicationTypes:
                    RefreshDGV(clsApplicationTypes.GetAllApplicationTypes());
                    break;
                case enModeUC.ManageTestTypes:
                    RefreshDGV(clsTestType.GetAllTestTypeDatas());
                    break;
            }
        }
        private void cmsGeneral_Click(object sender, EventArgs e)
        {
            switch (_enMode)
            {
                case enModeUC.ManageApplicationTypes:
                    _EditApplicationType();
                    break;
                case enModeUC.ManageTestTypes:
                    _EditTestType();
                    break;
            }
        }
    }
}
