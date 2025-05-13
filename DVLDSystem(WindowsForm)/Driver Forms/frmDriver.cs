using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDSystem_BusinessLayer_;


namespace DVLDSystem_WindowsForm_.Driver_Forms
{
    public partial class frmDriver : Form
    {
        public frmDriver()
        {
            InitializeComponent();
        }
        private string[] _FillComboBoxwhitString()
        {
            string[] strings = { "None","Driver ID","National No"
                                , "Full Name", };
            return strings;
        }

        private void frmDriver_Load(object sender, EventArgs e)
        {
            ucTemplateDGVAndSearch1.RefreshDGV(clsDriver.GetAllDrivers());
            ucTemplateDGVAndSearch1.FillComboBox(_FillComboBoxwhitString());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
