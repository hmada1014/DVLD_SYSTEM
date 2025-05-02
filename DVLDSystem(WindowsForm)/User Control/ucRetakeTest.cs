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
    public partial class ucRetakeTest : UserControl
    {
        public ucRetakeTest()
        {
            InitializeComponent();
        }



        [Browsable(true)]
        [Category("Misc Controls Properties")]

        public Label RetakeApplicationFees
        {
            get { return lblRetakeApplicationFees; }
            set { lblRetakeApplicationFees = value; }
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]

        public Label RetakeTestApplicationID
        {
            get { return lblRetakeTestApplicationID; }
            set { lblRetakeTestApplicationID = value; }
        }

        [Browsable(true)]
        [Category("Misc Controls Properties")]

        public Label TotalFees
        {
            get { return lblTotalFees; }
            set { lblTotalFees = value; }
        }



        [Browsable(true)]
        [Category("Misc Controls Properties")]

        public GroupBox GBRetakeTestInfo
        {
            get { return gbRetakeTest; }
            set { gbRetakeTest = value; }
        }

            

    }
}
