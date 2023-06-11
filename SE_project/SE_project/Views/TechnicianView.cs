using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SE_project.controllers;

namespace SE_project
{
    public partial class TechnicianView : Form
    {
        public List<Test> listTests = new List<Test>();
        public List<Test> listTestsFromManagemant = new List<Test>();
        Order SelectedOrder = new Order();
        Test SelectedTest = new Test();
        public TechnicianView()
        {
            InitializeComponent();
            LoadUnacteptedTests();
        }
        private void LoadUnacteptedTests()
        {
            listTestsFromManagemant.AddRange(TestManagement.testList);
            foreach (Order o in OrderManagement.toAcceptOrderList)
                listBox1.Items.Add(o.ID);
            foreach (Order o in OrderManagement.toFillOrderList)
                listBox3.Items.Add(o.ID);
            foreach (Order o in OrderManagement.completedOrderList)
                listBox5.Items.Add(o.ID);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listTests.Clear();
            var selectedCategory = listBox1.SelectedItem;
            foreach (Order o in OrderManagement.toAcceptOrderList)
            {
                if (o.ID.Equals(selectedCategory))
                {
                    SelectedOrder = o;
                    for (int i = 0; i < o.Tests.Count; i++)
                    {
                        foreach (Test t in TestManagement.testList)
                        {
                            if (t.ID.Equals(o.Tests[i].TestID))
                            {
                                listTests.Add(t);
                                listBox2.Items.Add(t.Name);
                            }

                        }
                    }
                    break;
                }

            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCategoryTestsIndex = listBox2.SelectedIndex;
            if (selectedCategoryTestsIndex.Equals(-1))
                selectedCategoryTestsIndex = SelectedOrder.Tests.Count - 1;
            SelectedTest = listTests[selectedCategoryTestsIndex];
            label19.Text = SelectedOrder.ID.ToString();
            label20.Text = SelectedOrder.Date.ToString();
            label21.Text = SelectedOrder.Status.ToString();
            label22.Text = SelectedTest.ID.ToString();
            label23.Text = SelectedTest.Name;
            label24.Text = SelectedTest.Type;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (OrderManagement.toAcceptOrderList.Count > 0)
            {
                SelectedOrder.Status = 2;
                label21.Text = SelectedOrder.Status.ToString();
                OrderManagement.deleteOrderFromToAcceptOrderList(SelectedOrder);
                OrderManagement.addOrderToFillOrderList(SelectedOrder);
                listBox1.Items.Remove(SelectedOrder.ID);
                listBox3.Items.Add(SelectedOrder.ID);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (OrderManagement.toAcceptOrderList.Count > 0)
            {
                SelectedOrder.Status = 3;
                label21.Text = SelectedOrder.Status.ToString();
                OrderManagement.deleteOrderFromToAcceptOrderList(SelectedOrder);
                OrderManagement.addOrderToDeniedOrderList(SelectedOrder);
                listBox1.Items.Remove(SelectedOrder.ID);
            }
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            listTests.Clear();
            var selectedCategory = listBox3.SelectedItem;
            foreach (Order o in OrderManagement.toFillOrderList)
            {
                if (o.ID.Equals(selectedCategory))
                {
                    SelectedOrder = o;
                    for (int i = 0; i < o.Tests.Count; i++)
                    {
                        foreach (Test t in listTestsFromManagemant)
                        {
                            if (t.ID.Equals(o.Tests[i].TestID))
                            {
                                listTests.Add(t);
                                listBox4.Items.Add(t.Name);
                            }

                        }
                    }
                    break;
                }

            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCategoryTestsIndex = listBox4.SelectedIndex;
            if (listBox4.Items.Count > 0)
            {
                if (selectedCategoryTestsIndex.Equals(-1))
                    selectedCategoryTestsIndex = listTests.Count - 1;
                SelectedTest = listTests[selectedCategoryTestsIndex];
                label26.Text = SelectedOrder.ID.ToString();
                label27.Text = SelectedTest.ID.ToString();
                label28.Text = SelectedTest.Name;
                label29.Text = SelectedTest.Type;
                label30.Text = SelectedTest.Min.ToString();
                label31.Text = SelectedTest.Max.ToString();
                label33.Text = SelectedTest.GetUnitStringFull();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ClientTest c in SelectedOrder.Tests)
            {
                if (c.TestID.Equals(SelectedTest.ID))
                {
                    c.Result = textBox5.Text;
                }
                break;
            }
            if (OrderManagement.toFillOrderList.Count > 0)
            {
                var selectedCategoryTestsIndex = listBox4.SelectedIndex;
                if (selectedCategoryTestsIndex.Equals(-1))
                    selectedCategoryTestsIndex = listTests.Count - 1;
                listBox4.Items.RemoveAt(selectedCategoryTestsIndex);
                listTests.RemoveAt(selectedCategoryTestsIndex);
                listTestsFromManagemant.Remove(SelectedTest);
                if (listBox4.Items.Count.Equals(0))
                {
                    OrderManagement.toFillOrderList.Remove(SelectedOrder);
                    OrderManagement.completedOrderList.Add(SelectedOrder);
                    listBox3.Items.Remove(SelectedOrder.ID);
                    listBox5.Items.Add(SelectedOrder.ID);
                }
            }
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox6.Items.Clear();
            listTests.Clear();
            var selectedCategory = listBox5.SelectedItem;
            foreach (Order o in OrderManagement.completedOrderList)
            {
                if (o.ID.Equals(selectedCategory))
                {
                    SelectedOrder = o;
                    for (int i = 0; i < o.Tests.Count; i++)
                    {
                        foreach (Test t in TestManagement.testList)
                        {
                            if (t.ID.Equals(o.Tests[i].TestID))
                            {
                                listTests.Add(t);
                                listBox6.Items.Add(t.Name);
                            }

                        }
                    }
                    break;
                }

            }
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCategoryTestsIndex = listBox6.SelectedIndex;
            if (selectedCategoryTestsIndex.Equals(-1))
                selectedCategoryTestsIndex = SelectedOrder.Tests.Count - 1;
            SelectedTest = listTests[selectedCategoryTestsIndex];
            label36.Text = SelectedOrder.ID.ToString();
            label37.Text = SelectedTest.ID.ToString();
            label38.Text = SelectedTest.Name;
            label39.Text = SelectedTest.Type;
            label41.Text = SelectedTest.GetUnitStringFull();
            foreach (ClientTest c in SelectedOrder.Tests)
            {
                if (c.TestID.Equals(SelectedTest.ID))
                {
                    label40.Text = c.Result + "  " + SelectedTest.GetUnitStringFull();
                }
                break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ClientTest c in SelectedOrder.Tests)
            {
                if (c.TestID.Equals(SelectedTest.ID))
                {
                    c.Result = textBox1.Text;
                }
                break;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

