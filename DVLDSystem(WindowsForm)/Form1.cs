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

namespace DVLDSystem_WindowsForm_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clsTest type = new clsTest();

            type.TestID = 1;
            type.TestAppointmentID = 71;
            type.TestResult = false;
            type.CreatedByUserID = 1;
            

            type.Save();

            clsTest type1 =  clsTest.Find(29);

            bool i = clsTestType.IsTestTypeDataExist(4);

            type1.TestID = 30;

            type1.Save();
            DataView dataView = clsTest.GetAllTests();

            clsTest.DeleteTest(38);

        }
    }
}
