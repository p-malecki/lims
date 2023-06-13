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

namespace SE_project.Views.User_controls
{
    public partial class DeniedOrder : UserControl
    {
        public DeniedOrder(int id, DateTime date, List<ClientTest> clientTest)
        {
            InitializeComponent();

            lbDeniedId.Text = id.ToString();
            lbDeniedDate.Text = date.ToString();

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

            listbxDeniedTests.DataSource = testNames;
        }
    }
}
