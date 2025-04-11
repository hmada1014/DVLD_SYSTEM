using DVLDSystem_BusinessLayer_;
using DVLDSystem_WindowsForm_.People;
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
    public partial class ucFindPerson : UserControl
    {
        public event Action<int> onPersonSelected;

        protected virtual void PersonSelected(int personId)
        {
            Action<int> handler = onPersonSelected;
            if (handler!= null)
            {
                handler(personId);
            }
        }

        public ucFindPerson()
        {
            InitializeComponent();
        }
        private clsPerson FindBy(string text)
        {
            if (cbFinder.Text == "National No")
            {
                return clsPerson.Find(text);
            }
            else 
            {
                return clsPerson.Find(Convert.ToInt32(text));       
            }
        }
        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            if (txtSearchAPerson.Text.Trim() != string.Empty)
            {
                clsPerson person = FindBy(txtSearchAPerson.Text.Trim());
                if (person != null)
                {
                    ucPersonCard1.LoadPersonInfo(person);
                    if (onPersonSelected != null)
                        PersonSelected(person.PersonID);
                }
                else
                {
                    ucPersonCard1.LoadPersonInfo(null);
                    MessageBox.Show("person you search for not found","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    if (onPersonSelected != null)
                        PersonSelected(-1);
                }

              ;
            }
            
        }
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPeople Person = new frmAddEditPeople(-1);
            Person.ShowDialog();
        }
        private void FillFindBy()
        {
            cbFinder.Items.Add("National No");
            cbFinder.Items.Add("Person ID");
            cbFinder.SelectedIndex = 0;
        }
        private void ucFindPerson_Load(object sender, EventArgs e)
        {
            FillFindBy();
        }
        private void cbFinder_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchAPerson.Text = string.Empty;
        }
        private void txtSearchAPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFinder.Text == "Person ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                } 
            }
        }
    }
}
