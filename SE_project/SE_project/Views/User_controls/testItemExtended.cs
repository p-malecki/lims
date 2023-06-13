using SE_project.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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

            testID.Text = "ID  " + test.ID.ToString().PadLeft(5, '0');
            testName.Text = test.Name;
            minVal.Text = "min: " + test.Min.ToString();
            maxVal.Text = "max: " + test.Max.ToString();
            units.Text = "unit: " + test.GetUnitStringAbbrev();
            testType.Text = TestTypeManagement.GetTypeName(test.Type);
            price.Text = test.Price.ToString() + " zł";
        }

        private void testItemExtended_Load(object sender, EventArgs e)
        {

        }
    }
}
