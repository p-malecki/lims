using Microsoft.VisualBasic;
using SE_project.controllers;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
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
        public List<Test> listTests = new List<Test>();
        public List<Test> listTestsFromManagemant = new List<Test>();
        Order SelectedOrder = new Order();
        Test SelectedTest = new Test();
        private void sortlistbox(ListBox listBox, string toAdd)
        {
            ListBox sortedList = new ListBox();
            string date1 = toAdd.Substring(toAdd.IndexOf(" "), toAdd.Length - 1);
            bool add = true;
            foreach (string s in listBox.Items)
            {
                string date2 = s.Substring(s.IndexOf(" "), s.Length - 1);
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
            InitializeComponent();
            LoadUnacteptedTests();
        }
        private void LoadUnacteptedTests()
        {
            listBox1.Items.Clear();
            List<int> listOrder = new List<int>();
            listTestsFromManagemant.AddRange(TestManagement.testList);
            foreach (Order o in OrderManagement.toAcceptOrderList)
                sortlistbox(listBox1, o.ID.ToString() + " " + o.Date.ToString());
            foreach (Order o in OrderManagement.toFillOrderList)
                sortlistbox(listBox3, o.ID.ToString() + " " + o.Date.ToString());
            foreach (Order o in OrderManagement.completedOrderList)
                sortlistbox(listBox5, o.ID.ToString() + " " + o.Date.ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listTests.Clear();
            if (listBox1.SelectedItem != null)
            {
                string selectedCategory = listBox1.SelectedItem.ToString();
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
                                    listBox2.Items.Add(t.Name);
                                }

                            }
                        }
                        break;
                    }

                }
                label19.Text = SelectedOrder.ID.ToString();
                label20.Text = SelectedOrder.Date.ToString();
                label21.Text = SelectedOrder.Status.ToString();
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCategoryTestsIndex = listBox2.SelectedIndex;
            if (selectedCategoryTestsIndex.Equals(-1))
                selectedCategoryTestsIndex = SelectedOrder.Tests.Count - 1;
            var SelectedTest = listTests[selectedCategoryTestsIndex];
            SelectedTest = listTests[selectedCategoryTestsIndex];
            label22.Text = SelectedTest.ID.ToString();
            label23.Text = SelectedTest.Name;
            label24.Text = TestTypeManagement.GetTypeName(SelectedTest.Type);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (OrderManagement.toAcceptOrderList.Count > 0)
            {
                SelectedOrder.Status = 1;
                label21.Text = SelectedOrder.Status.ToString();
                OrderManagement.toAcceptOrderList.Remove(SelectedOrder);
                OrderManagement.toFillOrderList.Add(SelectedOrder);
                listBox1.Items.Remove(SelectedOrder.ID.ToString() + " " + SelectedOrder.Date.ToString());
                sortlistbox(listBox3, SelectedOrder.ID.ToString() + " " + SelectedOrder.Date.ToString());
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (OrderManagement.toAcceptOrderList.Count > 0)
            {
                SelectedOrder.Status = -1;
                label21.Text = SelectedOrder.Status.ToString();
                OrderManagement.toAcceptOrderList.Remove(SelectedOrder);
                OrderManagement.deniedOrderList.Add(SelectedOrder);
                listBox1.Items.Remove(SelectedOrder.ID.ToString() + " " + SelectedOrder.Date.ToString());
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            listTests.Clear();
            if (listBox3.SelectedItem != null)
            {
                string selectedCategory = listBox3.SelectedItem.ToString();
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
                                    listBox4.Items.Add(t.Name);
                                }

                            }
                        }
                        break;
                    }
                }
                label26.Text = SelectedOrder.ID.ToString();
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
                label27.Text = SelectedTest.ID.ToString();
                label28.Text = SelectedTest.Name;
                label29.Text = TestTypeManagement.GetTypeName(SelectedTest.Type);
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
                    SelectedOrder.Status = 2;
                    listBox3.Items.Remove(SelectedOrder.ID.ToString() + " " + SelectedOrder.Date.ToString());
                    sortlistbox(listBox5, SelectedOrder.ID.ToString() + " " + SelectedOrder.Date.ToString());
                }
            }
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox6.Items.Clear();
            listTests.Clear();
            if (listBox5.SelectedItem != null)
            {
                string selectedCategory = listBox5.SelectedItem.ToString();
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
                                    listBox6.Items.Add(t.Name);
                                }

                            }
                        }
                        break;
                    }
                }
                label36.Text = SelectedOrder.ID.ToString();
            }
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCategoryTestsIndex = listBox6.SelectedIndex;
            if (selectedCategoryTestsIndex.Equals(-1))
                selectedCategoryTestsIndex = SelectedOrder.Tests.Count - 1;
            SelectedTest = listTests[selectedCategoryTestsIndex];
            label37.Text = SelectedTest.ID.ToString();
            label38.Text = SelectedTest.Name;
            label39.Text = TestTypeManagement.GetTypeName(SelectedTest.Type);
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
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
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
