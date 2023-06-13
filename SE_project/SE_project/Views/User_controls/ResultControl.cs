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
    public partial class ResultControl : UserControl
    {
        public ResultControl(ClientTest test)
        {
            InitializeComponent();
            lbName.Text = TestManagement.getClientTestName(test);
            lbResult.Text = test.Result + " " + TestManagement.getClientTestUnitStringAbbrev(test);

            decimal min = TestManagement.getClientTestMin(test);
            decimal max = TestManagement.getClientTestMax(test);

            if (min != 0 && max != 0)
            {
                lbMin.Text = "Min: " + min.ToString();
                lbMax.Text = "Max: " + max.ToString();
            }
            else
            {
                lbMin.Text = "";
                lbMax.Text = "";
            }
        }
    }
}
