using DVLDSystem_BusinessLayer_;
using DVLDSystem_WindowsForm_.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDSystem_WindowsForm_
{
    public partial class frmPeople : Form
    {
        public frmPeople()
        {
            
            InitializeComponent();
        }

        private string [] FillComboBoxwhitString()
        {
            string[] strings = { "ID", "Name" };
            return strings;
        }
        private void frmPeople_Load(object sender, EventArgs e)
        {
           // ucTemplateDGVAndSearch1.RefreshDGV(clsPerson.GetAllPersons());
            ucTemplateDGVAndSearch1.FillComboBox(FillComboBoxwhitString());

            ucTemplateDGVAndSearch1.RefreshDGV(clsPerson.SearchPersonByPersonName("0"));

        }
    }
}
