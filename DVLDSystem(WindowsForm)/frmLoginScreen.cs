using RentalVehical_WindowsForm;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLDSystem_WindowsForm_
{
    public partial class frmLoginScreen : Form
    {
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
            rPlTop.BackColor = Color.FromArgb(18, 51, 61);
        }


        private void rPlTop_MouseLeave(object sender, EventArgs e)
        {
            rPlTop.BackColor = Color.FromArgb(22, 64, 77);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1(Convert.ToInt32( textBox1.Text));
            //form1.ShowDialog();

            MDIParentForm mDIParentForm = new MDIParentForm();
            mDIParentForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(Convert.ToInt32(textBox1.Text));
            form1.Show();
        }
    }
}
