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
    public partial class frmPersonInfo : Form
    {
        private int _PersonID;
        private clsPerson _CurrentPerson;
        public frmPersonInfo(int PersonID)
        {
            InitializeComponent();
            this._PersonID = PersonID;

            _CurrentPerson = clsPerson.Find(_PersonID);
        }

        private void frmPersonInfo_Load(object sender, EventArgs e)
        {
            ucPersonCard1.LoadPersonInfo(_CurrentPerson);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
