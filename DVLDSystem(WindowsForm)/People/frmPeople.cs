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

        
        

        private void frmPeople_Load(object sender, EventArgs e)
        {
            //ucTemplateDGVAndSearch.RefreshDGV(clsPerson.GetAllPersons());

            ucTemplateDGVAndSearch.RefreshDGV(clsPerson.GetAllPersons());

        }
    }
}
