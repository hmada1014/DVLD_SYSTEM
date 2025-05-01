using DVLDSystem_WindowsForm_.Application_Forms;
using DVLDSystem_WindowsForm_.People__Forms;
using DVLDSystem_WindowsForm_.Test_Forms;
using DVLDSystem_WindowsForm_.User;
using DVLDSystem_WindowsForm_.User__Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDSystem_WindowsForm_
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLoginScreen());

            //Application.Run(new frmPeople());
            //Application.Run(new frmShowPersonDetails(-1));
            // Application.Run(new frmMainScreen());

            //Application.Run(new frmUser());
            //Application.Run(new frmAddEditeUser(1));

            //Application.Run(new Test1());
            // Application.Run(new frmChangePasswordUser(33));

            //   Application.Run(new frmManagApplicationTypes());

            //  Application.Run(new frmManageTestTypes());

            //Application.Run(new frmAddEditLocalDrivingLicenseApplication(16));
            //Application.Run(new frmManageLDLApplication());

            //Application.Run(new frmScheduelTest());

            //Application.Run(new frmTestAppointments(38,""));



        }
    }
}
