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
using SE_project.Views.User_controls;
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

            TestTypeManagement.Initialize();
            TestManagement.Initialize();
            OrderManagement.Initialize();

            LoadAvailableTests();
            LoadClientData();
            LoadClientOrders();
            OrderViewDefaultLook();
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
                else if (o.Status == -1)
                {
                    DeniedOrder newDeniedOrder = new DeniedOrder(o.ID, o.Date, o.Tests);
                    flowLayoutPanel2.Controls.Add(newDeniedOrder);
                }
            }
        }

        private void OrderViewDefaultLook()
        {
            lbSum.Text = "0 zł";
            lbCategory.Text = "";
            lbPrice.Text = "";

            cbHour.SelectedIndex = 0;
            cbMinute.SelectedIndex = 0;

            cbCategorySort.SelectedItem = categories[0];

            chlbTestsList.SelectedItem = null;

            foreach (int i in chlbTestsList.CheckedIndices)
            {
                chlbTestsList.SetItemCheckState(i, CheckState.Unchecked);
            }

            chlbTestsList.SelectedItem = null;

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
                    txtbxDescription.Text = t.Description;
                    lbCategory.Text = TestTypeManagement.GetTypeName(t.Type);
                    lbPrice.Text = t.Price.ToString() + " zł";
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
                    bool stopLoop = false;

                    if ((t.Name.Equals(testName)))
                    {
                        foreach (String name in checkedTests)
                            if (t.Name == name)
                            {
                                stopLoop = true;
                                break;
                            }

                        if (stopLoop)
                            break;

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

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (checkedTests.Count == 0)
            {
                MessageBox.Show("Nie wybrałeś żadnego testu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DateTime selectedDate = new DateTime(monthCalendar.SelectionStart.Year, monthCalendar.SelectionStart.Month,
                monthCalendar.SelectionStart.Day, int.Parse(cbHour.SelectedItem.ToString()), int.Parse(cbMinute.SelectedItem.ToString()), 0);

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
                        int orderId = DatabaseManagement.getFreeOrderID();

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
            using (var popupForm = new AccountDeleteConfimation())
            {
                var result = popupForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    UserManagement.ChangeAccountStatus(activeClient.ID, activeClient.Type);
                    this.Close();
                    UserManagement.LogOutUser();
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