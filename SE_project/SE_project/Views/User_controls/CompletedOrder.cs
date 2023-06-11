using SE_project.controllers;
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
        public CompletedOrder(int id, DateTime date, List<ClientTest> clientTest)
        {
            InitializeComponent();

            lbCompletedId.Text = id.ToString();
            lbCompletedDate.Text = date.ToString();

            List<String> testNames = new List<string>();
            foreach (ClientTest ct in clientTest)
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

        private void listbxPedningTests_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
