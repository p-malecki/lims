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

namespace SE_project
{
    public partial class TechnicianView : Form
    {
        public List<int> listOrder = new List<int>();
        public List<Test> listTests = new List<Test>();
        public List<string> listTestsNames = new List<string>();
        Order SelectedOrder = new Order();
        Test SelectedTest = new Test();
        public TechnicianView()
        {
            InitializeComponent();
            LoadUnacteptedTests();
        }
        private void LoadUnacteptedTests()
        {
            foreach (Order o in OrderManagement.toAcceptOrderList)
                listOrder.Add(o.ID);
            listBox1.DataSource = listOrder;
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
                                listTestsNames.Add(t.Name);
                            }

                        }
                    }
                }
            }
            listBox2.DataSource = listTestsNames;

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
            SelectedOrder.Status = 2;
            label21.Text = SelectedOrder.Status.ToString();
            OrderManagement.deleteOrderFromToAcceptOrderList(SelectedOrder);
            OrderManagement.addOrderToFillOrderList(SelectedOrder);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SelectedOrder.Status = 3;
            label21.Text = SelectedOrder.Status.ToString();
            OrderManagement.deleteOrderFromToAcceptOrderList(SelectedOrder);
            OrderManagement.addOrderToDeniedOrderList(SelectedOrder);   
        }
    }
}

