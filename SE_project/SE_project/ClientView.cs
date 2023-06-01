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
    public partial class ClientView : Form
    {
        public List<String> names = new List<String>();
        public List<String> categories = new List<String>();

        public ClientView()
        {
            InitializeComponent();
            LoadAvailableTests();
        }

        private void LoadAvailableTests()
        {
            foreach (Test t in TestManagement.testList) { names.Add(t.Name); }
            checkedListBox1.DataSource = names;

            categories.Add("<wszystkie kategorie>");
            foreach (TestType tt in TestTypeManagement.List) { categories.Add(tt.Name); }
            comboBox1.DataSource = categories;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<String> selectedNames = new List<String>();

            if (!comboBox1.Text.Equals("<wszystkie kategorie>"))
            {
                foreach (Test t in TestManagement.testList)
                {
                    if (t.Type.Equals(comboBox1.Text)) selectedNames.Add(t.Name);
                }

                checkedListBox1.DataSource = null;
                checkedListBox1.Items.Clear();
                checkedListBox1.DataSource = selectedNames;
            }
            else
            {
                checkedListBox1.DataSource = null;
                checkedListBox1.Items.Clear();
                checkedListBox1.DataSource = names;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            List<string> searched = new List<string>();

            foreach (Test t in TestManagement.testList)
            {
                if (t.Name.StartsWith(textBox7.Text)) searched.Add(t.Name);
            }

            checkedListBox1.DataSource = null;
            checkedListBox1.Items.Clear();
            checkedListBox1.DataSource = searched;
        }

        private void checkedListBox1_Click(object sender, EventArgs e)
        {
            var selectedName = checkedListBox1.SelectedItem;

            foreach (Test t in TestManagement.testList)
            {
                if (t.Name.Equals(selectedName))
                {
                    label23.Text = t.Description;
                    break;
                }
            }
        }
    }
}
