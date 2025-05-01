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
    public partial class ucTestAppointment : UserControl
    {
        public ucTestAppointment()
        {
            InitializeComponent();

          
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]

        public string LDLApplicationID
        {
            get { return lblLDLApplicationID.Text; }
            set { lblLDLApplicationID.Text = value; }
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]

        public string LicenseClasseName
        {
            get { return lblLicenseClasses.Text; }
            set { lblLicenseClasses.Text = value; }
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]

        public string ApplicationPersonName
        {
            get { return lblApplicationPersonName.Text; }
            set { lblApplicationPersonName.Text = value; }
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]

        public string NumberOfRetakenTests
        {
            get { return lblNumberOfRetakenTests.Text; }
            set { lblNumberOfRetakenTests.Text = value; }
        }


        [Browsable(true)]
        [Category("Misc Controls Properties")]

        public string TestFee
        {
            get { return lblTestFee.Text; }
            set { lblTestFee.Text = value; }
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]

        public DateTimePicker DateTestAppointment1
        {
            get { return DtpDateTestAppointment; }
            set { DtpDateTestAppointment = value; }
        }




    }
}
