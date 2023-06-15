using Microsoft.VisualBasic;
using SE_project.controllers;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_project
{
    public partial class TechnicianView : Form
    {
        User activeUser;

        public List<Test> listTests = new List<Test>();
        public List<Test> listTestsFromManagemant = new List<Test>();
        Order SelectedOrder = new Order();
        Test SelectedTest = new Test();
        private void sortlistbox(ListBox listBox, string toAdd)
        {
            ListBox sortedList = new ListBox();
            string date1 = toAdd.Substring(toAdd.IndexOf(" "), toAdd.Length - 2);
            bool add = true;
            foreach (string s in listBox.Items)
            {
                string date2 = s.Substring(s.IndexOf(" "), s.Length - 2);
                DateTime dt1 = DateTime.Parse(date1);
                DateTime dt2 = DateTime.Parse(date2);
                if (dt1 < dt2 && add == true)
                {
                    sortedList.Items.Add(toAdd);
                    add = false;
                }
                sortedList.Items.Add(s);
            }
            if (add)
                sortedList.Items.Add(toAdd);
            listBox.Items.Clear();
            foreach (string s in sortedList.Items)
                listBox.Items.Add(s);
        }
        public TechnicianView()
        {
            TestManagement.Initialize();
            TestTypeManagement.Initialize();
            OrderManagement.Initialize();
            activeUser = UserManagement.ActiveUser;
            InitializeComponent();
            LoadTestsForOrders();
        }
        private void LoadTestsForOrders()
        {
            resetLabels();
            listbxToAcceptOrders.Items.Clear();
            List<int> listOrder = new List<int>();
            listTestsFromManagemant.AddRange(TestManagement.testList);
            foreach (Order o in OrderManagement.toAcceptOrderList)
                sortlistbox(listbxToAcceptOrders, o.ID.ToString() + " " + o.Date.ToString());
            foreach (Order o in OrderManagement.toFillOrderList)
                sortlistbox(listbxToFillOrders, o.ID.ToString() + " " + o.Date.ToString());
            foreach (Order o in OrderManagement.completedOrderList)
                sortlistbox(listbxCompletedOrders, o.ID.ToString() + " " + o.Date.ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listbxToAcceptTests.Items.Clear();
            listTests.Clear();
            if (listbxToAcceptOrders.SelectedItem != null)
            {
                string selectedCategory = listbxToAcceptOrders.SelectedItem.ToString();
                string selectedId = selectedCategory.Substring(0, selectedCategory.IndexOf(" "));
                foreach (Order o in OrderManagement.toAcceptOrderList)
                {
                    if (o.ID.ToString().Equals(selectedId))
                    {
                        SelectedOrder = o;
                        for (int i = 0; i < o.Tests.Count; i++)
                        {
                            foreach (Test t in TestManagement.testList)
                            {
                                if (t.ID.Equals(o.Tests[i].TestID))
                                {
                                    listTests.Add(t);
                                    listbxToAcceptTests.Items.Add(t.Name);
                                }

                            }
                        }
                        break;
                    }

                }
                lbToAcceptOrderID.Text = SelectedOrder.ID.ToString();
                lbToAcceptDate.Text = SelectedOrder.Date.ToString();
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbxToAcceptTests.SelectedIndex >= 0)
            {
                var selectedCategoryTestsIndex = listbxToAcceptTests.SelectedIndex;
                if (selectedCategoryTestsIndex.Equals(-1))
                    selectedCategoryTestsIndex = SelectedOrder.Tests.Count - 1;
                var SelectedTest = listTests[selectedCategoryTestsIndex];
                SelectedTest = listTests[selectedCategoryTestsIndex];
                lbToAcceptTestID.Text = SelectedTest.ID.ToString();
                lbToAcceptTestName.Text = SelectedTest.Name;
                lbToAcceptTestType.Text = SelectedTest.Type.ToString();
            }
            else
            {
                lbToAcceptTestID.Text = "";
                lbToAcceptTestName.Text = "";
                lbToAcceptTestType.Text = "";
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (listbxToAcceptOrders.SelectedIndex >= 0)
            {
                if (OrderManagement.toAcceptOrderList.Count > 0)
                {
                    DatabaseManagement.UpdateOrderStatus(SelectedOrder.ID, 1);
                    DatabaseManagement.UpdateOrderTechnician(SelectedOrder.ID, activeUser.ID);
                    SelectedOrder.Status = 1;
                    OrderManagement.toAcceptOrderList.Remove(SelectedOrder);
                    OrderManagement.toFillOrderList.Add(SelectedOrder);
                    listbxToAcceptOrders.Items.Remove(SelectedOrder.ID.ToString() + " " + SelectedOrder.Date.ToString());
                    sortlistbox(listbxToFillOrders, SelectedOrder.ID.ToString() + " " + SelectedOrder.Date.ToString());
                }

                MessageBox.Show("Zaakceptowano zamówienie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nie wybrałeś żadnego zamówienia do zaakceptowania!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnDeny_Click(object sender, EventArgs e)
        {
            if (listbxToAcceptOrders.SelectedIndex >= 0)
            {
                if (OrderManagement.toAcceptOrderList.Count > 0)
                {
                    SelectedOrder.Status = -1;
                    OrderManagement.toAcceptOrderList.Remove(SelectedOrder);
                    OrderManagement.deniedOrderList.Add(SelectedOrder);
                    DatabaseManagement.UpdateOrderStatus(SelectedOrder.ID, -1);
                    listbxToAcceptOrders.Items.Remove(SelectedOrder.ID.ToString() + " " + SelectedOrder.Date.ToString());
                }
                MessageBox.Show("Odrzucono zamówienie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nie wybrałeś żadnego zamówienia do odrzucenia!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listbxToFillTests.Items.Clear();
            listTests.Clear();
            if (listbxToFillOrders.SelectedItem != null)
            {
                string selectedCategory = listbxToFillOrders.SelectedItem.ToString();
                string selectedId = selectedCategory.Substring(0, selectedCategory.IndexOf(" "));
                foreach (Order o in OrderManagement.toFillOrderList)
                {
                    if (o.ID.ToString().Equals(selectedId))
                    {
                        SelectedOrder = o;
                        for (int i = 0; i < o.Tests.Count; i++)
                        {
                            foreach (Test t in listTestsFromManagemant)
                            {
                                if (t.ID.Equals(o.Tests[i].TestID))
                                {
                                    listTests.Add(t);
                                    listbxToFillTests.Items.Add(t.Name);
                                }

                            }
                        }
                        break;
                    }
                }
                lbToFillOrderID.Text = SelectedOrder.ID.ToString();
                lbToFillClientID.Text = SelectedOrder.ClientID.ToString();
            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbxToFillTests.SelectedIndex >= 0)
            {
                var selectedCategoryTestsIndex = listbxToFillTests.SelectedIndex;
                if (listbxToFillTests.Items.Count > 0)
                {
                    if (selectedCategoryTestsIndex.Equals(-1))
                        selectedCategoryTestsIndex = listTests.Count - 1;
                    SelectedTest = listTests[selectedCategoryTestsIndex];
                    lbToFillTestID.Text = SelectedTest.ID.ToString();
                    lbToFillTestName.Text = SelectedTest.Name;
                    lbToFillTestType.Text = SelectedTest.Type.ToString();
                    lbToFillTestMin.Text = SelectedTest.Min.ToString();
                    lbToFillTestMax.Text = SelectedTest.Max.ToString();
                    lbToFillUnits.Text = SelectedTest.GetUnitStringAbbrev();
                }
            }
            else
            {
                lbToFillTestID.Text = "";
                lbToFillTestName.Text = "";
                lbToFillTestType.Text = "";
                lbToFillTestMin.Text = "";
                lbToFillTestMax.Text = "";
                lbToFillUnits.Text = "";
            }
        }

        private void btnConfirmResult_Click(object sender, EventArgs e)
        {
            if (listbxToFillTests.SelectedIndex >= 0)
            {
                if (textBox5.Text.Length > 0)
                {
                    foreach (ClientTest c in SelectedOrder.Tests)
                    {
                        if (c.TestID.Equals(SelectedTest.ID))
                        {
                            c.Result = textBox5.Text;
                            DatabaseManagement.ChangeClientTestResult(c.TestID, textBox5.Text);
                            DatabaseManagement.ChangeClientTestStatusToFilled(c.TestID);
                            break;
                        }
                    }
                    if (listbxToFillTests.Items.Count > 1)
                    {
                        if (OrderManagement.toFillOrderList.Count > 0)
                        {
                            var selectedCategoryTestsIndex = listbxToFillTests.SelectedIndex;
                            if (selectedCategoryTestsIndex.Equals(-1))
                                selectedCategoryTestsIndex = listTests.Count - 1;
                            listbxToFillTests.Items.RemoveAt(selectedCategoryTestsIndex);
                            listTests.RemoveAt(selectedCategoryTestsIndex);
                            listTestsFromManagemant.Remove(SelectedTest);
                        }

                        MessageBox.Show("Zatwierdzono wynik!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox5.Text = "";

                    }
                    else
                    {
                        foreach (ClientTest c in SelectedOrder.Tests)
                        {
                            if (c.TestID.Equals(SelectedTest.ID))
                            {
                                c.Result = textBox5.Text;
                                DatabaseManagement.ChangeClientTestResult(c.TestID, textBox5.Text);
                                DatabaseManagement.ChangeClientTestStatusToFilled(c.TestID);
                                break;
                            }
                        }
                        OrderManagement.toFillOrderList.Remove(SelectedOrder);
                        OrderManagement.completedOrderList.Add(SelectedOrder);
                        listbxToFillOrders.Items.Remove(SelectedOrder.ID.ToString() + " " + SelectedOrder.Date.ToString());
                        sortlistbox(listbxCompletedOrders, SelectedOrder.ID.ToString() + " " + SelectedOrder.Date.ToString());

                        DatabaseManagement.ChangeClientTestResult(SelectedTest.ID, textBox5.Text);
                        DatabaseManagement.ChangeClientTestStatusToFilled(SelectedTest.ID);
                        DatabaseManagement.UpdateOrderStatus(SelectedOrder.ID, 2);


                        MessageBox.Show("Zamówienie zrealizowane!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Nie wprowadzono wyniku!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nie wybrałeś żadnego testu, dla którego można wprowadzić wynik!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

            listbxCompletedTests.Items.Clear();
            listTests.Clear();
            if (listbxCompletedOrders.SelectedItem != null)
            {
                string selectedCategory = listbxCompletedOrders.SelectedItem.ToString();
                string selectedId = selectedCategory.Substring(0, selectedCategory.IndexOf(" "));
                foreach (Order o in OrderManagement.completedOrderList)
                {
                    if (o.ID.ToString().Equals(selectedId))
                    {
                        SelectedOrder = o;
                        for (int i = 0; i < o.Tests.Count; i++)
                        {
                            foreach (Test t in TestManagement.testList)
                            {
                                if (t.ID.Equals(o.Tests[i].TestID))
                                {
                                    listTests.Add(t);
                                    listbxCompletedTests.Items.Add(t.Name);
                                }

                            }
                        }
                        break;
                    }
                }
                lbCompletedOrderID.Text = SelectedOrder.ID.ToString();
                lbCompletedClientID.Text = SelectedOrder.ClientID.ToString();
            }
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbxCompletedTests.SelectedIndex >= 0)
            {
                var selectedCategoryTestsIndex = listbxCompletedTests.SelectedIndex;
                if (selectedCategoryTestsIndex.Equals(-1))
                    selectedCategoryTestsIndex = SelectedOrder.Tests.Count - 1;
                SelectedTest = listTests[selectedCategoryTestsIndex];
                lbCompletedClientTestID.Text = SelectedTest.ID.ToString();
                lbCompletedTestName.Text = SelectedTest.Name;
                lbCompletedTestType.Text = SelectedTest.GetTestTypeString();
                lbCompletedUnits.Text = SelectedTest.GetUnitStringAbbrev();
                foreach (ClientTest c in SelectedOrder.Tests)
                {
                    if (c.TestID.Equals(SelectedTest.ID))
                    {
                        lbCompletedResult.Text = c.Result + " " + SelectedTest.GetUnitStringAbbrev();
                        break;
                    }
                }
            }
            else
            {
                lbCompletedClientTestID.Text = "";
                lbCompletedTestName.Text = "";
                lbCompletedTestType.Text = "";
                lbCompletedResult.Text = "";
                lbCompletedUnits.Text = "";
            }
        }

        private void btnConfirmResultEdit_Click(object sender, EventArgs e)
        {
            if (listbxCompletedOrders.SelectedIndex >= 0)
            {
                if (textBox1.Text.Length > 0)
                {

                    DatabaseManagement.ChangeClientTestResult(SelectedTest.ID, textBox1.Text);

                    MessageBox.Show("Edytowano wynik!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (ClientTest c in SelectedOrder.Tests)
                    {
                        if (c.TestID.Equals(SelectedTest.ID))
                        {
                            c.Result = textBox1.Text;
                            break;
                        }
                    }
                    lbCompletedResult.Text = textBox1.Text;
                    textBox5.Text = "";
                }
                else
                {
                    MessageBox.Show("Nie wprowadzono wyniku!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nie wybrałeś żadnego testu, dla którego można edytować wynik!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnTechnicianLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            UserManagement.LogOutUser();
        }

        private void resetLabels()
        {
            lbToAcceptOrderID.Text = "";
            lbToAcceptDate.Text = "";
            lbToAcceptTestID.Text = "";
            lbToAcceptTestName.Text = "";
            lbToAcceptTestType.Text = "";
            lbToFillOrderID.Text = "";
            lbToFillTestID.Text = "";
            lbToFillTestName.Text = "";
            lbToFillTestType.Text = "";
            lbToFillTestMin.Text = "";
            lbToFillTestMax.Text = "";
            lbToFillUnits.Text = "";
            lbCompletedOrderID.Text = "";
            lbCompletedClientTestID.Text = "";
            lbCompletedTestName.Text = "";
            lbCompletedTestType.Text = "";
            lbCompletedResult.Text = "";
            lbCompletedUnits.Text = "";
            lbToFillClientID.Text = "";
            lbCompletedClientID.Text = "";
        }
    }
}
