using DVLDSystem_BusinessLayer_;
using DVLDSystem_WindowsForm_.Properties;
using RentalVehical_WindowsForm;
using System;
using System.Drawing;
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
        }

        private void rPlTop_MouseDown(object sender, MouseEventArgs e)
        {
            clsDragForm.ReleaseCapture();
            clsDragForm.SendMessage(this.Handle);
        }

        private void ibtnClose_Click(object sender, EventArgs e)
        {
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

        private Image ResizeImage(Image img, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, width, height);
            }
            return bmp;
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
            
            this.KeyPreview = true;
        }

        private void ClearText()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text.Trim();
            string Password = txtPassword.Text.Trim();

            if (clsUser.IsUserExist(Username, Password))
            {
                clsUser User = clsUser.Find(Username, Password);

                if (User != null)
                {
                    txtMessageInvalied.Visible = false;
                    this.Hide();
                    using (frmMainScreen Main = new frmMainScreen(User.UserID))
                    {
                        Main.ShowDialog();
                    }
                    ClearText();
                    this.Show();
                }
                else
                {
                    ShowLoginError("User does not exist.");
                }
            }
            else
            {
                ShowLoginError("User does not exist.");
            }


        }

        private void ShowLoginError(string MessageErorr)
        {
            txtMessageInvalied.Visible = true;
            SystemSounds.Beep.Play();
            MessageBox.Show(MessageErorr);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmLoginScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;          // Prevents the "ding"
     
                btnLogin.PerformClick();   // Or call your login method
            }
        }

 
    }
}
