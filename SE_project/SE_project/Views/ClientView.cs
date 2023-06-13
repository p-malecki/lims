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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SE_project
{
    public partial class ClientView : Form
    {
        Client activeClient;

        public List<String> names = new List<String>();
        public List<String> categories = new List<String>();
        public List<String> checkedTests = new List<String>();

        public decimal sum = 0;

        public ClientView()
        {
            InitializeComponent();
            activeClient = UserManagement.ActiveUser as Client;

            lbSum.Text = "0 zł";

            TestTypeManagement.Initialize();
            TestManagement.Initialize();
            OrderManagement.Initialize();

            LoadAvailableTests();
            LoadClientData();
            LoadClientOrders();
        }

        private void LoadAvailableTests()
        {
            foreach (Test t in TestManagement.testList)
                if (t.Status == true)
                    names.Add(t.Name);

            chlbTestsList.DataSource = null;
            chlbTestsList.Items.Clear();
            chlbTestsList.DataSource = names;

            categories.Add("<wszystkie kategorie>");
            foreach (TestType tt in TestTypeManagement.List)
                if (tt.Status == true)
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

            if (!activeClient.Pesel.Equals("0"))
                lbPesel.Text = activeClient.Pesel;
            else
                lbPesel.Text = "brak";

            DateTime date = Convert.ToDateTime(activeClient.Birthdate);
            lbBirthdate.Text = date.ToString("dd-MM-yyyy");

            lbAddress.Text = activeClient.Residence;
            lbPhoneNum.Text = activeClient.PhoneNumber;

            var (toAccept, completed) = OrderManagement.GetClientStats(activeClient.ID);
            lbStats1.Text = string.Format("zamówienia oczekujące na zatwierdzenie: {0}", toAccept.ToString());
            lbStats2.Text = string.Format("zamówienia zakończone: {0}", completed.ToString());
        }

        private void LoadClientOrders()
        {
            activeClient.Orders = DatabaseManagement.getClientOrders(activeClient.ID);

            foreach (Order o in activeClient.Orders)
            {
                if (o.Status == 0 || o.Status == 1)
                {
                    PendingOrder newPendingOrder = new PendingOrder(o.ID, o.Date, o.Status, o.Tests);
                    flowLayoutPanel1.Controls.Add(newPendingOrder);
                }
                else if (o.Status == 2)
                {
                    CompletedOrder newCompletedOrder = new CompletedOrder(o.ID, o.Date, o);
                    flowLayoutPanel2.Controls.Add(newCompletedOrder);
                }
            }
        }

        private void OrderViewDefaultLook()
        {


            txtbxHours.Text = "";
            txtbxMinutes.Text = "";

            cbCategorySort.SelectedItem = categories[0];

            monthCalendar.SelectionStart = monthCalendar.TodayDate;
            monthCalendar.SelectionEnd = monthCalendar.TodayDate;
        }
        private void cbCategorySort_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!cbCategorySort.SelectedValue.Equals("<wszystkie kategorie>"))
            {
                List<String> selectedNames = new List<String>();

                foreach (Test t in TestManagement.testList)
                {
                    string cat = t.GetTestTypeString();
                    if (cat.Equals(cbCategorySort.SelectedValue))
                        selectedNames.Add(t.Name);
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
                    lbCategory.Text = TestTypeManagement.GetTypeName(t.Type);
                    lbUnits.Text = t.GetUnitStringAbbrev();
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

            lbSum.Text = sum.ToString() + " zł";
        }

        private void txtbxHours_Leave(object sender, EventArgs e)
        {
            if (txtbxHours.Text.Length == 0)
                return;

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
            if (txtbxMinutes.Text.Length == 0)
                return;

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
                    if (DatabaseManagement.isNotOrderedTwice(selectedDate))
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

                        int clientTestId = DatabaseManagement.getFreeClientTestsID();
                        int orderId = OrderManagement.getFreeOrderID();

                        foreach (Test t in orderedTests)
                        {
                            ClientTest newClientTest = new ClientTest(clientTestId, orderId, "", t.ID);
                            clientOrderedTests.Add(newClientTest);
                            clientTestId++;
                        }

                        Order newOrder = new Order(orderId, 0, selectedDate, activeClient.ID, -1, clientOrderedTests);
                        OrderManagement.toAcceptOrderList.Add(newOrder);
                        activeClient.Orders.Add(newOrder);

                        PendingOrder newPendingOrder = new PendingOrder(orderId, selectedDate, 0, checkedTests);
                        flowLayoutPanel1.Controls.Add(newPendingOrder);

                        DatabaseManagement.InsertNewOrder(newOrder);
                        DatabaseManagement.InsertNewOrderClientTests(clientOrderedTests);

                        MessageBox.Show("Udało ci się złożyć zamówienie!\nSzczegóły w zakłace \"Zamówienia\"", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        OrderViewDefaultLook();
                    }
                    else
                        MessageBox.Show("Złożyłeś już zamówienie w tym dniu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                if (!txtbNewEmail.Text.Equals(activeClient.Email))
                    if (UserManagement.IsValidEmail(txtbNewEmail.Text))
                        if (!UserManagement.IsEmailAlreadyUsed(txtbNewEmail.Text))
                        {
                            DatabaseManagement.ChangeUserEmail(activeClient.ID, txtbNewEmail.Text);
                            UserManagement.ChangeAccountEmail(activeClient.ID, txtbNewEmail.Text);
                            MessageBox.Show("Twój aders e-mail został zmieniony!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Podany adres e-mail jest już w użyciu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Niepoprawny adres e-mail!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Podany adres e-mail jest taki sam jak obecnie używany!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Podane adresy e-mail nie są takie same!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNewPassword_Click(object sender, EventArgs e)
        {
            if (txtbNewPassword.Text.Equals(txtbNewPasswordConfirm.Text))
                if (!txtbNewPassword.Text.Equals(activeClient.Password))
                    if (UserManagement.IsValidPassword(txtbNewPassword.Text))
                    {
                        DatabaseManagement.ChangeUserPassword(activeClient.ID, txtbNewPassword.Text);
                        UserManagement.ChangeAccountPassword(activeClient.ID, txtbNewPassword.Text);
                        MessageBox.Show("Twoje hasło zostało zmienione!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Podane hasło nie spełnia wymagań!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Podane hasło jest takie same jak obecnie używane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Podane hasła nie są takie same!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUserAccountDelete_Click(object sender, EventArgs e)
        {
            //TODO
            using (var popupForm = new AccountDeleteConfimation())
            {
                var result = popupForm.ShowDialog(); // Wywołanie formularza modalnego

                if (result == DialogResult.OK)
                    UserManagement.ChangeAccountStatus(activeClient.ID, activeClient.Type);

                this.Close();
                UserManagement.LogOutUser();
            }
        }

        private void btnUserLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            UserManagement.LogOutUser();
        }

    }
}