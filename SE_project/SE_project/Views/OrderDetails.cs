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

namespace SE_project
{
    public partial class OrderDetails : Form
    {
        public OrderDetails(Order order)
        {
            InitializeComponent();

            foreach (ClientTest ct in order.Tests)
            {
                ResultControl control = new ResultControl(ct);
                flowLayoutPanel1.Controls.Add(control);
            }
        }
    }
}
