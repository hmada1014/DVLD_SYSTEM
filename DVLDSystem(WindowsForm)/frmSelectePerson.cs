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

namespace DVLDSystem_WindowsForm_
{
    public partial class frmSelectePerson : Form
    {
        private clsPerson _Person;
        public frmSelectePerson()
        {
            InitializeComponent();
        }

        private void FillComboBox()
        {
            cbFinder.Items.Add("Person ID");
            cbFinder.Items.Add("National No");
            cbFinder.SelectedIndex = 0;
        }
        private void frmSelectePerson_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }
        private clsPerson FindPerson()
        {
            switch (cbFinder.Text)
            {
                case "Person ID":
                    if (!int.TryParse(txtSearchAPerson.Text.Trim(), out int search))
                    {
                        search = -1;
                    }
                    _Person = clsPerson.Find(search);
                    break;
                case "National No":
                    _Person = clsPerson.Find(txtSearchAPerson.Text.Trim());
                    break;
            }
            return _Person;
        }
        private void FillPersonCard(clsPerson person)
        {
            if (person == null) { MessageBox.Show("Person you search for not Exists", "Person Not Found"); return; }

            ucPersonCard3.ID = person.PersonID.ToString();
            ucPersonCard3.NotionalNo = person.NationalNo.ToString();
            ucPersonCard3.PersonName = (person.FirstName.ToString() + " " + person.SecondName.ToString() + " " + person.ThirdName.ToString() + " " + person.LastName.ToString()).ToString();
            ucPersonCard3.Gendor = (person.Gender == 0) ? "Male" : "Female";
            ucPersonCard3.Email = person.Email.ToString();
            ucPersonCard3.Address = person.Address.ToString();
            ucPersonCard3.DateOfBirth = person.DateOfBirth.ToString();
            ucPersonCard3.Phone = person.Phone.ToString();
            ucPersonCard3.Country = clsCountry.Find(person.NationalityCountryID).CountryName.ToString();

        }
        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            _Person = FindPerson();
            FillPersonCard(_Person);
        }
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPeople AddnewPerson = new frmAddEditPeople(-1);
            AddnewPerson.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
