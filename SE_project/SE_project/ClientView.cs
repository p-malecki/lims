using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_project
{
    public partial class ClientView : Form
    {
        public List<String> names = new List<String>();
        public List<String> categories = new List<String>();

        public decimal sum;

        public ClientView()
        {
            this.sum = 0;

            InitializeComponent();

            label31.Text = sum.ToString();

            LoadAvailableTests();
            LoadClientData();
        }

        private void LoadAvailableTests()
        {
            foreach (Test t in TestManagement.testList) names.Add(t.Name);
            chlbTestsList.DataSource = names;

            categories.Add("<wszystkie kategorie>");
            foreach (TestType tt in TestTypeManagement.List) categories.Add(tt.Name);
            cbCategorySort.DataSource = categories;
        }

        private void LoadClientData()
        {
            Client currentUser = new Client(1, 2, 3, "john123", "pass123", "John", "Doe", new DateTime(1990, 5, 10), "1234567890", "New York");

            currentUser.email = "example@gmail.com";

            lbLogin.Text = currentUser.Name;
            lbEmail.Text = currentUser.email;
            lbName.Text = currentUser.Name;
            lbSurname.Text = currentUser.Surname;
            lbPesel.Text = currentUser.Pesel;
            lbBirthdate.Text = currentUser.Birthdate.ToString();
            lbAddress.Text = currentUser.Residence;
        }

        private void LoadClientOrders()
        {

        }

        private void cbCategorySort_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<String> selectedNames = new List<String>();

            if (!cbCategorySort.Text.Equals("<wszystkie kategorie>"))
            {
                foreach (Test t in TestManagement.testList)
                {
                    if (t.Type.Equals(cbCategorySort.Text)) selectedNames.Add(t.Name);
                }

                chlbTestsList.DataSource = null;
                chlbTestsList.Items.Clear();
                chlbTestsList.DataSource = selectedNames;
            }
            else
            {
                chlbTestsList.DataSource = null;
                chlbTestsList.Items.Clear();
                chlbTestsList.DataSource = names;
            }
        }

        private void txtbSearch_TextChanged(object sender, EventArgs e)
        {
            List<string> searched = new List<string>();

            foreach (Test t in TestManagement.testList)
            {
                if (t.Name.StartsWith(txtbSearch.Text)) searched.Add(t.Name);
            }

            chlbTestsList.DataSource = null;
            chlbTestsList.Items.Clear();
            chlbTestsList.DataSource = searched;
        }

        private void chlbTestsList_Click(object sender, EventArgs e)
        {
            var selectedName = chlbTestsList.SelectedItem;

            foreach (Test t in TestManagement.testList)
            {
                if (t.Name.Equals(selectedName))
                {
                    lbDescription.Text = t.Description;
                    lbCategory.Text = t.Type;
                    lbUnits.Text = t.Unit;
                    lbPrice.Text = t.Price.ToString();
                    break;
                }
            }
        }

        private void btnNewEmail_Click(object sender, EventArgs e)
        {
            Client currentUser = new Client(1, 2, 3, "john123", "pass123", "John", "Doe", new DateTime(1990, 5, 10), "1234567890", "New York");

            currentUser.email = "example@gmail.com";

            if (txtbNewEmail.Text.Equals(txtbNewEmailConfirm.Text))
            {
                if (!txtbNewEmail.Text.Equals(currentUser.email))
                {
                    if (UserManagement.IsValidEmail(txtbNewEmail.Text))
                    {
                        if (!UserManagement.IsEmailAlreadyUsed(txtbNewEmail.Text))
                        {

                        }
                        else
                        {

                        }
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
            else
            {

            }
        }

        private void btnNewLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnNewPassword_Click(object sender, EventArgs e)
        {

            Client currentUser = new Client(1, 2, 3, "john123", "pass123", "John", "Doe", new DateTime(1990, 5, 10), "1234567890", "New York");

            currentUser.email = "example@gmail.com";

            if (txtbNewPassword.Text.Equals(txtbNewPasswordConfirm.Text))
            {
                if (!txtbNewPassword.Text.Equals(currentUser.Password))
                {
                    if (UserManagement.IsValidPassword(txtbNewPassword.Text))
                    {

                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
            else
            {

            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
