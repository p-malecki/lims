using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SE_project.controllers;

namespace SE_project
{
    public partial class PendingOrder : UserControl
    {
        public PendingOrder(int id, DateTime date, int status, List<ClientTest> clientTest)
        {
            InitializeComponent();
            lbPendingId.Text = id.ToString();
            lbPendingDate.Text = date.ToString();

            if (status == 0)
                lbPendingStatus.Text = "Oczekiwanie na zatwierdzenie";
            else if (status == 1)
                lbPendingStatus.Text = "Zgłoś się na badania!";

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

            listbxPedningTests.DataSource = testNames;
        }

        public PendingOrder(int id, DateTime date, int status, List<String> clientTestNames)
        {
            InitializeComponent();
            lbPendingId.Text = id.ToString();
            lbPendingDate.Text = date.ToString();

            if (status == 0)
                lbPendingStatus.Text = "Oczekiwanie na zatwierdzenie";
            else if (status == 1)
                lbPendingStatus.Text = "Zgłoś się na badania!";

            listbxPedningTests.DataSource = clientTestNames;
        }
    }
}
