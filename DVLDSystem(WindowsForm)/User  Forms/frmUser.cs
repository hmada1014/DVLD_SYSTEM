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

namespace DVLDSystem_WindowsForm_.User
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private string[] _FillComboBoxwhitString()
        {
            string[] strings = { "ID", "PersonID" };
            return strings;
        }
        private void frmUser_Load(object sender, EventArgs e)
        {
            ucTemplateDGVAndSearch2.RefreshDGV(clsUser.GetAllUsers());
            ucTemplateDGVAndSearch2.FillComboBox(_FillComboBoxwhitString());
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmUser user1 = new frmUser();
            user1.ShowDialog();
        }
    }
}
