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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SE_project
{
    public partial class ClientView : Form
    {
        public List<String> names = new List<String>();
        public List<String> categories = new List<String>();

        public List<String> hours = new List<string> { "8", "9", "10", "11", "12", "13", "15", "16" };
        public List<String> minutes = new List<string> {
                                                    "0", "1", "2", "3", "4", "5", "6", "7",
                                                    "8", "9", "10", "11", "12", "13", "15", "16",
                                                    "17", "18", "19", "20", "21", "22", "23", "24",
                                                    "25", "26", "27", "28", "29", "30", "31", "32",
                                                    "33", "34", "35", "36", "37", "38", "39", "40",
                                                    "41", "42", "43", "44", "45", "46", "47", "48",
                                                    "49", "50", "51", "52", "53", "54", "55", "56",
                                                    "57", "58", "59"
                                                };
        public List<String> checkedTests = new List<String>();

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
            //LoadClientOrders();
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

            if (!cbCategorySort.SelectedText.Equals("<wszystkie kategorie>"))
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
                            //TODO
                        }
                        else
                        {
                            MessageBox.Show("Podany adres e-mail jest już w użyciu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Niepoprawny adres e-mail!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Podany adres e-mail jest taki sam jak obecnie używany!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Podane adresy e-mail nie są takie same!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNewLogin_Click(object sender, EventArgs e)
        {
            Client currentUser = new Client(1, 2, 3, "john123", "pass123", "John", "Doe", new DateTime(1990, 5, 10), "1234567890", "New York");

            currentUser.email = "example@gmail.com";

            if (txtbNewLogin.Text.Equals(txtbNewLoginConfirm.Text))
            {
                if (!txtbNewLogin.Text.Equals(currentUser.Login))
                {
                    if (UserManagement.IsValidLogin(txtbNewLogin.Text))
                    {
                        if (!UserManagement.IsLoginAlreadyUsed(txtbNewLoginConfirm.Text))
                        {
                            //TODO
                        }
                        else
                        {
                            MessageBox.Show("Podane login jest już w użyciu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Podany login nie spełnia wymagań!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Podany login jest taki sam jak obecnie używany!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Podane loginy nie są takie same!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                        //TODO
                    }
                    else
                    {
                        MessageBox.Show("Podane hasło nie spełnia wymagań!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Podane hasło jest takie same jak obecnie używane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Podane hasła nie są takie same!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //TODO
            DateTime selectedDate = new DateTime(monthCalendar.SelectionStart.Day, monthCalendar.SelectionStart.Month, monthCalendar.SelectionStart.Year, int.Parse(listbxHours.SelectedItem.ToString()), int.Parse(listbxMinutes.SelectedItem.ToString()), 0);

            //lbSum.Text = selectedDate.ToString();

            if (monthCalendar.SelectionStart.DayOfWeek != DayOfWeek.Saturday && monthCalendar.SelectionStart.DayOfWeek != DayOfWeek.Sunday)
            {
                List<Test> orderedTests = new List<Test>();

                foreach (String s in checkedTests)
                    foreach (Test t in TestManagement.testList)
                        if (t.Name.Equals(s))
                        {
                            orderedTests.Add(t);
                            break;
                        }

                List<ClientTest> clientOrderedTests = new List<ClientTest>();

                //TODO
                int clientTestId = 1; //pobranie z bazy pierwszego wolnego id dla ClientTest
                int orderId = 1;    //pobranie z bazy pierwszego wolnego id dla Orders

                foreach (Test t in orderedTests)
                {
                    ClientTest newClientTest = new ClientTest(clientTestId, orderId, "", t.ID);
                    clientOrderedTests.Add(newClientTest);
                    clientTestId++;
                }


                int clientId = 1;    //id klienta 

                Order newOrder = new Order(orderId, 0, selectedDate, clientId, -1, clientOrderedTests);
                OrderManagement.toAcceptOrderList.Add(newOrder);
            }
            else
            {
                MessageBox.Show("Placówka nie funkcjonuje w wybranym terminie!\nGodziny otwarcia: Pn - Pt: 8:00 - 16:00", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        checkedTests.Add(testName);
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
                        checkedTests.Remove(testName);
                        sum -= t.Price;
                        break;
                    }
                }
            }

            lbSum.Text = sum.ToString();
        }

        private void btnUserAccountDelete_Click(object sender, EventArgs e)
        {
            Client currentUser = new Client(1, 2, 3, "john123", "pass123", "John", "Doe", new DateTime(1990, 5, 10), "1234567890", "New York");
            currentUser.email = "example@gmail.com";

            //TODO
            using (var popupForm = new AccountDeleteConfimation())
            {
                var result = popupForm.ShowDialog(); // Wywołanie formularza modalnego

                if (result == DialogResult.OK)
                {
                    //TODO
                }
            }
        }

        private void btnUserLogOut_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }
}
