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
        //Client activeClient = UserManagement.ActiveUser as Client;
        Client activeClient = new Client(1, "john123", "pass123", "John", "Doe", new DateTime(2023, 6, 8, 10, 30, 0), "john@example.com");

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

        public decimal sum = 0;

        public ClientView()
        {
            InitializeComponent();

            lbSum.Text = "0";

            listbxHours.DataSource = hours;
            listbxMinutes.DataSource = minutes;

            LoadAvailableTests();
            LoadClientData();
            LoadClientOrders();
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
            lbLogin.Text = activeClient.Name;
            lbEmail.Text = activeClient.Email;
            lbName.Text = activeClient.Name;
            lbSurname.Text = activeClient.Surname;
            lbPesel.Text = activeClient.Pesel;
            lbBirthdate.Text = activeClient.Birthdate.ToString();
            lbAddress.Text = activeClient.Residence;
        }

        private void LoadClientOrders()
        {
            foreach (Order o in activeClient.Orders)
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
            if (txtbNewEmail.Text.Equals(txtbNewEmailConfirm.Text))
            {
                if (!txtbNewEmail.Text.Equals(activeClient.Email))
                {
                    if (UserManagement.IsValidEmail(txtbNewEmail.Text))
                    {
                        if (!UserManagement.IsEmailAlreadyUsed(txtbNewEmail.Text))
                        {
                            //TODO
                            activeClient.Email = txtbNewEmail.Text;
                            MessageBox.Show("Twój aders e-mail został zmieniony!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (txtbNewLogin.Text.Equals(txtbNewLoginConfirm.Text))
            {
                if (!txtbNewLogin.Text.Equals(activeClient.Login))
                {
                    if (UserManagement.IsValidLogin(txtbNewLogin.Text))
                    {
                        if (!UserManagement.IsLoginAlreadyUsed(txtbNewLogin.Text))
                        {
                            //TODO
                            activeClient.Login = txtbNewLogin.Text;
                            MessageBox.Show("Twój login został zmieniony!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (txtbNewPassword.Text.Equals(txtbNewPasswordConfirm.Text))
            {
                if (!txtbNewPassword.Text.Equals(activeClient.Password))
                {
                    if (UserManagement.IsValidPassword(txtbNewPassword.Text))
                    {
                        //TODO
                        activeClient.Password = txtbNewPassword.Text;
                        MessageBox.Show("Twoje hasło zostało zmienione!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (checkedTests.Count == 0)
            {
                MessageBox.Show("Nie wybrałeś żadnego testu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DateTime selectedDate = new DateTime(monthCalendar.SelectionStart.Year, monthCalendar.SelectionStart.Month, monthCalendar.SelectionStart.Day, int.Parse(listbxHours.SelectedItem.ToString()), int.Parse(listbxMinutes.SelectedItem.ToString()), 0);
            
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

                int clientTestId = OrderManagement.getFreeClientTestsID(); //pobranie z bazy pierwszego wolnego id dla ClientTest
                int orderId = OrderManagement.getFreeOrderID();    //pobranie z bazy pierwszego wolnego id dla Orders

                foreach (Test t in orderedTests)
                {
                    ClientTest newClientTest = new ClientTest(clientTestId, orderId, "", t.ID);
                    clientOrderedTests.Add(newClientTest);
                    clientTestId = OrderManagement.getFreeClientTestsID();
                }

                int clientId = activeClient.ID; 

                Order newOrder = new Order(orderId, 0, selectedDate, clientId, -1, clientOrderedTests);
                OrderManagement.toAcceptOrderList.Add(newOrder);
                activeClient.Orders.Add(newOrder);

                PendingOrder newPendingOrder = new PendingOrder(orderId, selectedDate, 0, checkedTests);
                flowLayoutPanel1.Controls.Add(newPendingOrder);

                MessageBox.Show("Udało ci się złożyć zamówienie!\nSzczegóły w zakłace \"Zamówienia\"", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Client currentUser = new Client(1, "john123", "pass123", "John", "Doe", new DateTime(1990, 5, 10), "example@gmail.com", "1234567890", "New York");

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
            this.Close();
            UserManagement.LogOutUser();
        }
    }
}