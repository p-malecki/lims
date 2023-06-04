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
    public partial class testItemExtendedDelete : UserControl
    {


        public testItemExtendedDelete(Test test)
        {
            InitializeComponent();
            testID.Text = test.ID.ToString();
            testName.Text = test.Name;
            minVal.Text = test.Min.ToString();
            maxVal.Text = test.Max.ToString();
            units.Text = test.Unit;
            testType.Text = test.Type;
            price.Text = test.Price.ToString();
        }

        private void btnTestDelete_Click(object sender, EventArgs e)
        {
            TestManagement.RemoveTest(Int32.Parse(testID.Text));
            TestManagement.LoadTestLists();
        }
    }
}
