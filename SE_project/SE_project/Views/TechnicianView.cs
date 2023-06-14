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

        public List<Order> toAcceptOrders = OrderManagement.toAcceptOrderList;
        public List<Order> toFillOrders = OrderManagement.toFillOrderList;
        public List<Order> completedOrders = OrderManagement.completedOrderList;

        public List<List<ClientTest>> tAOTest = new List<List<ClientTest>>();
        public List<List<ClientTest>> tFOTest = new List<List<ClientTest>>();
        public List<List<ClientTest>> cOTest = new List<List<ClientTest>>();

        List<List<String>> tAOTestNames = new List<List<String>>();
        List<List<String>> tFOTestNames = new List<List<String>>();
        List<List<String>> cOTestNames = new List<List<String>>();

        public TechnicianView()
        {
            InitializeComponent();

            activeUser = UserManagement.ActiveUser;

            TestManagement.Initialize();
            TestTypeManagement.Initialize();
            OrderManagement.Initialize();

            LoadOrders();
            LoadTestsForOrders();
            resetLabels();

            listbxToAcceptOrders.SelectedItem = null;
            listbxToFillOrders.SelectedItem = null;
            listbxCompletedOrders.SelectedItem = null;
        }

        private void sortOrders()
        {
            toAcceptOrders.Sort((x, y) => x.Date.CompareTo(y.Date));
            toFillOrders.Sort((x, y) => x.Date.CompareTo(y.Date));
            completedOrders.Sort((x, y) => x.Date.CompareTo(y.Date));
        }

        private void LoadOrders()
        {
            toAcceptOrders = OrderManagement.toAcceptOrderList;
            toFillOrders = OrderManagement.toFillOrderList;
            completedOrders = OrderManagement.completedOrderList;

            sortOrders();

            List<String> tOANames = new List<String>();
            List<String> tFONames = new List<String>();
            List<String> cONames = new List<String>();

            foreach (Order tOA in toAcceptOrders)
                tOANames.Add(tOA.Date.ToString());
            foreach (Order tFO in toFillOrders)
                tFONames.Add(tFO.Date.ToString());
            foreach (Order cON in completedOrders)
                cONames.Add(cON.Date.ToString());

            listbxToAcceptOrders.DataSource = tOANames;
            listbxToFillOrders.DataSource = tFONames;
            listbxCompletedOrders.DataSource = cONames;
        }

        private void LoadTestsForOrders()
        {
            tAOTest.Clear();
            tFOTest.Clear();
            cOTest.Clear();

            tAOTestNames.Clear();
            tFOTestNames.Clear();
            cOTestNames.Clear();

            foreach (Order tOA in toAcceptOrders)
            {
                tAOTest.Add(DatabaseManagement.GetClientTests(tOA.ID));

                int lastElementIndex = tAOTest.Count - 1;

                List<String> tempList = new List<String>();

                foreach (ClientTest ct in tAOTest[lastElementIndex])
                {
                    tempList.Add(TestManagement.getClientTestName(ct));
                }

                tAOTestNames.Add(tempList);
            }

            foreach (Order tFO in toFillOrders)
            {
                tFOTest.Add(DatabaseManagement.GetClientTests(tFO.ID));

                int lastElementIndex = tFOTest.Count - 1;

                List<String> tempList = new List<String>();

                foreach (ClientTest ct in tFOTest[lastElementIndex])
                {
                    tempList.Add(TestManagement.getClientTestName(ct));
                }

                tFOTestNames.Add(tempList);
            }

            foreach (Order cO in completedOrders)
            {
                cOTest.Add(DatabaseManagement.GetClientTests(cO.ID));

                int lastElementIndex = cOTest.Count - 1;

                List<String> tempList = new List<String>();

                foreach (ClientTest ct in cOTest[lastElementIndex])
                {
                    tempList.Add(TestManagement.getClientTestName(ct));
                }

                cOTestNames.Add(tempList);
            }
        }

        private void reloadOrders()
        {
            listbxToAcceptOrders.DataSource = null;
            listbxToAcceptOrders.Items.Clear();
            listbxToAcceptTests.DataSource = null;
            listbxToAcceptTests.Items.Clear();

            listbxToFillOrders.DataSource = null;
            listbxToFillOrders.Items.Clear();
            listbxToFillTests.DataSource = null;
            listbxToFillTests.Items.Clear();

            listbxCompletedOrders.DataSource = null;
            listbxCompletedOrders.Items.Clear();
            listbxCompletedTests.DataSource = null;
            listbxCompletedTests.Items.Clear();

            LoadOrders();
            LoadTestsForOrders();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbxToAcceptOrders.SelectedIndex < 0 || listbxToAcceptOrders.SelectedIndex >= tAOTestNames.Count)
                return;

            listbxToAcceptTests.DataSource = null;
            listbxToAcceptTests.Items.Clear();
            listbxToAcceptTests.DataSource = tAOTestNames[listbxToAcceptOrders.SelectedIndex];
            listbxToAcceptTests.SelectedItem = null;

            lbToAcceptOrderID.Text = toAcceptOrders[listbxToAcceptOrders.SelectedIndex].ID.ToString();
            lbToAcceptDate.Text = toAcceptOrders[listbxToAcceptOrders.SelectedIndex].Date.ToString();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbxToAcceptTests.SelectedIndex >= 0)
            {
                lbToAcceptTestID.Text = toAcceptOrders[listbxToAcceptOrders.SelectedIndex].Tests[listbxToAcceptTests.SelectedIndex].ID.ToString();
                lbToAcceptTestName.Text = TestManagement.getClientTestName(toAcceptOrders[listbxToAcceptOrders.SelectedIndex].Tests[listbxToAcceptTests.SelectedIndex]);
                lbToAcceptTestType.Text = TestTypeManagement.GetTypeName(toAcceptOrders[listbxToAcceptOrders.SelectedIndex].Tests[listbxToAcceptTests.SelectedIndex].TestID);
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
                int orderID = toAcceptOrders[listbxToAcceptOrders.SelectedIndex].ID;
                DatabaseManagement.UpdateOrderStatus(orderID, 1);
                DatabaseManagement.UpdateOrderTechnician(orderID, activeUser.ID);

                OrderManagement.changeFromAcceptedToFill(orderID);
                OrderManagement.changeOrderTechnician(orderID, activeUser.ID);

                reloadOrders();

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
                int orderID = toAcceptOrders[listbxToAcceptOrders.SelectedIndex].ID;
                DatabaseManagement.UpdateOrderStatus(orderID, -1);

                OrderManagement.changeFromAcceptedToDenied(orderID);

                reloadOrders();

                MessageBox.Show("Odrzucono zamówienie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nie wybrałeś żadnego zamówienia do odrzucenia!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbxToFillOrders.SelectedIndex < 0 || listbxToFillOrders.SelectedIndex >= tFOTestNames.Count)
                return;

            listbxToFillTests.DataSource = null;
            listbxToFillTests.Items.Clear();
            listbxToFillTests.DataSource = tFOTestNames[listbxToFillOrders.SelectedIndex];
            listbxToFillTests.SelectedItem = null;

            lbToFillOrderID.Text = toFillOrders[listbxToFillOrders.SelectedIndex].ID.ToString();
            lbToFillClientID.Text = toFillOrders[listbxToFillOrders.SelectedIndex].ClientID.ToString();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbxToFillTests.SelectedIndex >= 0)
            {
                lbToFillTestID.Text = toFillOrders[listbxToFillOrders.SelectedIndex].Tests[listbxToFillTests.SelectedIndex].ID.ToString();
                lbToFillTestName.Text = TestManagement.getClientTestName(toFillOrders[listbxToFillOrders.SelectedIndex].Tests[listbxToFillTests.SelectedIndex]);
                lbToFillTestType.Text = TestTypeManagement.GetTypeName(toFillOrders[listbxToFillOrders.SelectedIndex].Tests[listbxToFillTests.SelectedIndex].TestID);
                lbToFillTestMin.Text = TestManagement.getClientTestMin(toFillOrders[listbxToFillOrders.SelectedIndex].Tests[listbxToFillTests.SelectedIndex]).ToString();
                lbToFillTestMax.Text = TestManagement.getClientTestMax(toFillOrders[listbxToFillOrders.SelectedIndex].Tests[listbxToFillTests.SelectedIndex]).ToString();
                lbToFillUnits.Text = TestManagement.getClientTestUnitStringAbbrev(toFillOrders[listbxToFillOrders.SelectedIndex].Tests[listbxToFillTests.SelectedIndex]);
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
                    if (listbxToFillTests.Items.Count > 1)
                    {
                        int clientTestId = toFillOrders[listbxToFillOrders.SelectedIndex].Tests[listbxToFillTests.SelectedIndex].ID;

                        DatabaseManagement.ChangeClientTestResult(clientTestId, textBox5.Text);
                        DatabaseManagement.ChangeClientTestStatusToFilled(clientTestId);

                        toFillOrders[listbxToFillOrders.SelectedIndex].Tests.RemoveAt(listbxToFillTests.SelectedIndex);
                        tFOTestNames[listbxToFillOrders.SelectedIndex].RemoveAt(listbxToFillTests.SelectedIndex);
                        tFOTest[listbxToFillOrders.SelectedIndex].RemoveAt(listbxToFillTests.SelectedIndex);

                        MessageBox.Show("Zatwierdzono wynik!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        listbxToFillTests.DataSource = null;
                        listbxToFillTests.Items.Clear();
                        listbxToFillTests.DataSource = tFOTestNames[listbxToFillOrders.SelectedIndex];
                        listbxToFillTests.SelectedItem = null;

                        textBox5.Text = "";

                    }
                    else
                    {
                        int clientTestId = toFillOrders[listbxToFillOrders.SelectedIndex].Tests[listbxToFillTests.SelectedIndex].ID;

                        DatabaseManagement.ChangeClientTestResult(clientTestId, textBox5.Text);
                        DatabaseManagement.ChangeClientTestStatusToFilled(clientTestId);
                        DatabaseManagement.UpdateOrderStatus(toFillOrders[listbxToFillOrders.SelectedIndex].ID, 2);

                        OrderManagement.changeFromToFillToAccepted(toFillOrders[listbxToFillOrders.SelectedIndex].ID);

                        reloadOrders();

                        MessageBox.Show("Order completed", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (listbxCompletedOrders.SelectedIndex < 0 || listbxCompletedOrders.SelectedIndex >= cOTestNames.Count)
                return;

            listbxCompletedTests.DataSource = null;
            listbxCompletedTests.Items.Clear();
            listbxCompletedTests.DataSource = tFOTestNames[listbxCompletedOrders.SelectedIndex];
            listbxCompletedTests.SelectedItem = null;

            lbCompletedOrderID.Text = toFillOrders[listbxCompletedOrders.SelectedIndex].ID.ToString();
            lbCompletedClientID.Text = toFillOrders[listbxCompletedOrders.SelectedIndex].ClientID.ToString();
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbxCompletedTests.SelectedIndex >= 0)
            {
                lbCompletedClientTestID.Text = toFillOrders[listbxCompletedOrders.SelectedIndex].Tests[listbxCompletedTests.SelectedIndex].ID.ToString();
                lbCompletedTestName.Text = TestManagement.getClientTestName(toFillOrders[listbxCompletedOrders.SelectedIndex].Tests[listbxCompletedTests.SelectedIndex]);
                lbCompletedTestType.Text = TestTypeManagement.GetTypeName(toFillOrders[listbxCompletedOrders.SelectedIndex].Tests[listbxCompletedTests.SelectedIndex].TestID);
                lbCompletedResult.Text = toFillOrders[listbxCompletedOrders.SelectedIndex].Tests[listbxCompletedTests.SelectedIndex].Result;
                lbCompletedUnits.Text = TestManagement.getClientTestUnitStringAbbrev(toFillOrders[listbxCompletedOrders.SelectedIndex].Tests[listbxCompletedTests.SelectedIndex]);
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
                    int clientTestId = completedOrders[listbxCompletedOrders.SelectedIndex].Tests[listbxCompletedTests.SelectedIndex].ID;

                    DatabaseManagement.ChangeClientTestResult(clientTestId, textBox1.Text);

                    MessageBox.Show("Edytowano wynik!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listbxToFillTests.SelectedItem = null;

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
        }
    }
}
