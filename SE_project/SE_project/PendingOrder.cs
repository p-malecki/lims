using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_project
{
    public partial class PendingOrder : UserControl
    {
        public PendingOrder(int id, DateTime date, int status, List<ClientTest> tests)
        {
            InitializeComponent();
            lbPendingId.Text = id.ToString();
            lbPendingDate.Text = date.ToString();
            lbPendingStatus.Text = status.ToString();

            listbxPedningTests.DataSource = tests;
        }
    }
}
