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
        public CompletedOrder(int id, DateTime date, ClientTest[] tests)
        {
            InitializeComponent();

            lbCompletedId.Text = id.ToString();
            lbCompletedDate.Text = date.ToString();

            listbxCompletedTests.DataSource = tests;
        }
    }
}
