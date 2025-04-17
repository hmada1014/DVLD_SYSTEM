using DVLDSystem_BusinessLayer_;
using DVLDSystem_WindowsForm_.Properties;
using RentalVehical_WindowsForm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace DVLDSystem_WindowsForm_
{
    public partial class frmLoginScreen : Form
    {
        private static readonly Color HoverColor = Color.FromArgb(18, 51, 61);
        private static readonly Color DefaultColor = Color.FromArgb(22, 64, 77);

        public frmLoginScreen()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
            this.CancelButton = ibtnClose;
        }
        private void rPlTop_MouseDown(object sender, MouseEventArgs e)
        {
            clsDragForm.ReleaseCapture();
            clsDragForm.SendMessage(this.Handle);
        }
        private void ibtnClose_Click(object sender, EventArgs e)
        {
            _RememberMeSave();
            Application.Exit();
        }
        private void rPlTop_MouseHover(object sender, EventArgs e)
        {
            rPlTop.BackColor = HoverColor;
      
        }
        private void rPlTop_MouseLeave(object sender, EventArgs e)
        {
            rPlTop.BackColor = DefaultColor;
        
        }
        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = (!cbShowPassword.Checked) ? true : false;
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                txtPassword.Text = string.Empty;
            }

            txtPassword.isPassword = (!cbShowPassword.Checked) ? true : false;
        }
        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            _RememberMeLoadData();
            this.KeyPreview = true;
        }
        private void _RememberMeLoadData()
        {
            if (Settings.Default.RememberMeCheckStatus)
            {
                txtUsername.Text = Settings.Default.Username ;
                txtPassword.Text = Settings.Default.Password;
                cbRememberMe.Checked = true;
            }
            else
            {

                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
                cbRememberMe.Checked = false;

            }
        }
        private void _RememberMeSave()
        {
            if (cbRememberMe.Checked)
            {
                
                Settings.Default.RememberMeCheckStatus = true;
                Settings.Default.Username = txtUsername.Text.Trim();
                Settings.Default.Password = txtPassword.Text.Trim();
                Settings.Default.Save();
            }
            else
            {
                Settings.Default.RememberMeCheckStatus = false;
                Settings.Default.Username = string.Empty;
                Settings.Default.Username = string.Empty;
                Settings.Default.Save();
            }
            
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text.Trim();
            string Password = txtPassword.Text.Trim();

            if (clsUser.IsUserExist(Username))
            {
                clsUser User = clsUser.Find(Username, Password);

                if (User != null)
                {
                    txtMessageInvalied.Visible = false;
                    if (User.IsActive)
                    {
                        this.Hide();
                        using (frmMainScreen Main = new frmMainScreen(User.UserID))
                        {
                            
                            _RememberMeSave();
                            Main.ShowDialog();
                        }
                        this.Show(); 
                    }
                    else
                    {
                        ShowLoginError("Your account is inactive, Please contact the administrator.", "Falied Login");
                    }
                }
                else
                {
                    ShowLoginError("wrong username/password.", "Falied Login");
                }
            }
            else
            {
                ShowLoginError("User does not exist ", "Falied Login");
            }
        }
        private void ShowLoginError(string MessageErorr , string Caption)
        {
            txtMessageInvalied.Visible = true;
            SystemSounds.Beep.Play();
            MessageBox.Show(MessageErorr,Caption,MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        } 
    }
}
