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
    public partial class testItemExtendedDelete : UserControl
    {


        public testItemExtendedDelete(Test test)
        {
            InitializeComponent();
            testID.Text = "ID  " + test.ID.ToString().PadLeft(5, '0');
            testName.Text = test.Name;
            testType.Text = TestTypeManagement.GetTypeName(test.Type);
            price.Text = test.Price.ToString() + " zł";
        }

        private void btnTestDelete_Click(object sender, EventArgs e)
        {
            if (TestManagement.RemoveTest(Int32.Parse(testID.Text.Substring(4))) == true)
            {
                TestManagement.LoadTestLists();
                MessageBox.Show("Usunięto badanie.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nie można usunąc badania, ponieważ nie wszyskie zamówienia zawierające to badanie zostały zrealizowane",
                    "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
