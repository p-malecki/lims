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
using SE_project.controllers;
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
        public List<String> checkedTests = new List<String>();

        public decimal sum = 0;

        public ClientView()
        {
            InitializeComponent();

            lbSum.Text = "0";

            LoadAvailableTests();
            LoadClientData();
            LoadClientOrders();
        }

        private void LoadAvailableTests()
        {
            foreach (Test t in TestManagement.testList)
                names.Add(t.Name);
            chlbTestsList.DataSource = names;

            categories.Add("<wszystkie kategorie>");
            foreach (TestType tt in TestTypeManagement.List)
                categories.Add(tt.Name);
            cbCategorySort.DataSource = categories;
        }

        private void LoadClientData()
        {
            lbLogin.Text = activeClient.Name;
            lbEmail.Text = activeClient.Email;
            lbName.Text = activeClient.Name;
            lbSurname.Text = activeClient.Surname;
            lbPesel.Text = activeClient.Pesel;
            //TODO - data bez godziny
            lbBirthdate.Text = activeClient.Birthdate.ToString();
            lbAddress.Text = activeClient.Residence;
            lbPhoneNum.Text = activeClient.PhoneNumber;
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
                if (t.Name.StartsWith(txtbxSearch.Text))
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

        private void txtbxHours_Leave(object sender, EventArgs e)
        {
            int value = int.Parse(txtbxHours.Text);

            if (value >= 0 && value < 10)
                txtbxHours.Text = "0" + value.ToString();
            else if (value < 0)
                txtbxHours.Text = "00";
            else if (value > 23)
                txtbxHours.Text = "23";
        }

        private void txtbxMinutes_Leave(object sender, EventArgs e)
        {
            int value = int.Parse(txtbxHours.Text);

            if (value >= 0 && value < 10)
                txtbxMinutes.Text = "0" + value.ToString();
            else if (value < 0)
                txtbxMinutes.Text = "00";
            else if (value > 59)
                txtbxMinutes.Text = "59";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (checkedTests.Count == 0)
            {
                MessageBox.Show("Nie wybrałeś żadnego testu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtbxHours.Text.Equals("") || txtbxMinutes.Text.Equals(""))
            {
                MessageBox.Show("Wpisz odpowiednią godzinę", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DateTime selectedDate = new DateTime(monthCalendar.SelectionStart.Year, monthCalendar.SelectionStart.Month, monthCalendar.SelectionStart.Day, int.Parse(txtbxHours.Text), int.Parse(txtbxMinutes.Text), 0);

            if (selectedDate > DateTime.Now)
            {
                if (monthCalendar.SelectionStart.DayOfWeek != DayOfWeek.Saturday && monthCalendar.SelectionStart.DayOfWeek != DayOfWeek.Sunday)
                {
                    if (OrderManagement.isNotOrderedTwice(selectedDate))
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

                        chlbTestsList.ClearSelected();
                        checkedTests.Clear();
                        sum = 0;
                    }
                    else
                        MessageBox.Show("Złożyłeś już zamówienie w tym terminie!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Placówka nie funkcjonuje w wybranym terminie!\nGodziny otwarcia: Pn - Pt: 8:00 - 16:00", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Nie możesz złożyć zamówienia w przeszłości!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        if (!UserManagement.IsLoginAlreadyUsed(txtbNewLogin.Text, 0))
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

        private void btnUserAccountDelete_Click(object sender, EventArgs e)
        {
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