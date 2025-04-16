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

namespace DVLDSystem_WindowsForm_.User_Control
{
    public partial class ucUserCard : UserControl
    {
        public ucUserCard()
        {
            InitializeComponent();
        }

        public void LoadData(int UserID)
        {
            clsUser user = clsUser.Find(UserID);
            if (user != null)
            {
                lblUserID.Text   = user.UserID.ToString();
                lblUsername.Text = user.UserName.ToString();
                lblIsActive.Text = user.IsActive==true?"Yes":"No";
            }
            else
            {
                lblUserID.Text   = "???";
                lblUsername.Text = "???";
                lblIsActive.Text = "???";
            }
        }
        private void ucUserCard_Load(object sender, EventArgs e)
        {

        }
    }
}
