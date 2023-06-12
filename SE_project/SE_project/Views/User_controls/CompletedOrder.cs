using SE_project.controllers;
using SE_project.Views.User_controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SE_project
{
    public partial class CompletedOrder : UserControl
    {
        Order completedOrder;
        public CompletedOrder(int id, DateTime date, Order order)
        {
            InitializeComponent();

            completedOrder = order;

            lbCompletedId.Text = id.ToString();
            lbCompletedDate.Text = date.ToString();

            List<String> testNames = new List<string>();
            foreach (ClientTest ct in order.Tests)
            {
                foreach (Test t in TestManagement.testList)
                {
                    if (t.ID == ct.TestID)
                    {
                        testNames.Add(t.Name);
                        break;
                    }
                }
            }

            listbxCompletedTests.DataSource = testNames;
        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            using (var popupForm = new OrderDetails())
            {
                var result = popupForm.ShowDialog(); // Wywołanie formularza modalnego

                if (result == DialogResult.OK)
                {
                    
                }
                    UserManagement.ChangeAccountStatus(activeClient.ID, activeClient.Type);

                this.Close();
                UserManagement.LogOutUser();
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
