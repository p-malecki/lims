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

        public List<int> hours = new List<int> { 8, 9, 10, 11, 12, 13, 14, 15, 16};
        public List<int> minutes = new List<int> {
                                                    0, 1, 2, 3, 4, 5, 6, 7,
                                                    8, 9, 10, 11, 12, 13, 15, 16,
                                                    17, 18, 19, 20, 21, 22, 23, 24,
                                                    25, 26, 27, 28, 29, 30, 31, 32,
                                                    33, 34, 35, 36, 37, 38, 39, 40,
                                                    41, 42, 43, 44, 45, 46, 47, 48,
                                                    49, 50, 51, 52, 53, 54, 55, 56,
                                                    57, 58, 59
                                                };

        public decimal sum;

        public ClientView()
        {
            InitializeComponent();

            sum = 0;
            lbSum.Text = sum.ToString();

            listbxHours.DataSource = hours;
            listbxMinutes.DataSource = minutes;

            LoadAvailableTests();
            LoadClientData();
        }

        private void LoadAvailableTests()
        {
            foreach (Test t in TestManagement.testList)
                names.Add(t.Name);

            chlbTestsList.DataSource = null;
            chlbTestsList.Items.Clear();
            chlbTestsList.DataSource = names;

            categories.Add("<wszystkie kategorie>");
            foreach (TestType tt in TestTypeManagement.List)
                categories.Add(tt.Name);

            cbCategorySort.DataSource = null;
            cbCategorySort.Items.Clear();
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
            Client tempClient = new Client(1, 2, 3, "john123", "pass123", "John", "Doe", new DateTime(1990, 5, 10), "1234567890", "New York");
            tempClient.email = "example@gmail.com";

            foreach (Order o in tempClient.orders)
            {
                if (o.Status == 0 || o.Status == 1)
                {
                    PendingOrder newPendingOrder = new PendingOrder(o.ID, o.Date, o.Status, o.Tests);
                    flowLayoutPanel1.Controls.Add(newPendingOrder);
                }
                else if (o.Status == 2)
                {
                    CompletedOrder newCompletedOrder = new CompletedOrder(o.ID, o.Date, o.Tests);
                    flowLayoutPanel2.Controls.Add(newCompletedOrder);
                }
            }
        }

        private void cbCategorySort_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<String> selectedNames = new List<String>();

            if (!cbCategorySort.Text.Equals("<wszystkie kategorie>"))
            {
                foreach (Test t in TestManagement.testList)
                    if (t.Type.Equals(cbCategorySort.Text))
                        selectedNames.Add(t.Name);

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
                if (t.Name.StartsWith(txtbSearch.Text))
                    searched.Add(t.Name);

            chlbTestsList.DataSource = null;
            chlbTestsList.Items.Clear();
            chlbTestsList.DataSource = searched;
        }

        private void chlbTestsList_Click(object sender, EventArgs e)
        {
            var selectedName = chlbTestsList.SelectedItem;

            foreach (Test t in TestManagement.testList)
                if (t.Name.Equals(selectedName))
                {
                    lbDescription.Text = t.Description;
                    lbCategory.Text = t.Type;
                    lbUnits.Text = t.Unit;
                    lbPrice.Text = t.Price.ToString();
                    break;
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
            DateTime selectedDate = new DateTime(monthCalendar.SelectionRange.Start.Day, monthCalendar.SelectionRange.Start.Month, monthCalendar.SelectionRange.Start.Year, listbxHours.SelectedItem, listbxMinutes.SelectedItem, 0);

            if (selectedDate.DayOfWeek != DayOfWeek.Saturday && selectedDate.DayOfWeek != DayOfWeek.Sunday) 
            {
                selectedDate.
            }
            else
            {

            }

        }


        private void chlbTestsList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            String testName = names[e.Index].ToString();

            if (e.NewValue == CheckState.Checked)
            {
                foreach (Test t in TestManagement.testList)
                {
                    if ((t.Name.Equals(testName)))
                    {
                        sum += t.Price;
                        break;
                    }
                }
            }

            else if (e.NewValue == CheckState.Unchecked)
            {
                foreach (Test t in TestManagement.testList)
                {
                    if ((t.Name.Equals(testName)))
                    {
                        sum -= t.Price;
                        break;
                    }
                }
            }

            lbSum.Text = sum.ToString();
        }
    }
}
