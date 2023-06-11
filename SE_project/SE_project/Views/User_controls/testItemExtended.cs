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
    public partial class testItemExtended : UserControl
    {
        public testItemExtended(Test test)
        {
            InitializeComponent();
            testID.Text = test.ID.ToString();
            testName.Text = test.Name;
            minVal.Text = test.Min.ToString();
            maxVal.Text = test.Max.ToString();
            units.Text = test.GetUnitStringFull();
            testType.Text = test.Type;
            price.Text = test.Price.ToString();
        }
    }
}
