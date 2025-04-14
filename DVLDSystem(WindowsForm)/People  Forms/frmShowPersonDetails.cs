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

namespace DVLDSystem_WindowsForm_.People__Forms
{
    public partial class frmShowPersonDetails : Form
    {
        int _PersonID;
        clsPerson _CurrentPerson;
        public frmShowPersonDetails(int personID)
        {
            InitializeComponent();
            _PersonID = personID;

            if (_PersonID != -1)
            {
                _CurrentPerson = clsPerson.Find(_PersonID);
            }
        }

        private void frmShowPersonDetails_Load(object sender, EventArgs e)
        {
            ucPersonCard1.LoadPersonInfo(_CurrentPerson);
        }
    }
}
