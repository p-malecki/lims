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

            }
        }
    }
}
