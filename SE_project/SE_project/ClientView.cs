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

        public decimal sum;

        public ClientView()
        {
            this.sum = 0;

            InitializeComponent();

            label31.Text = sum.ToString();

            LoadAvailableTests();
            LoadClientData();
        }

        private void LoadAvailableTests()
        {
            foreach (Test t in TestManagement.testList) { names.Add(t.Name); }
            chlbTestsList.DataSource = names;

            categories.Add("<wszystkie kategorie>");
            foreach (TestType tt in TestTypeManagement.List) { categories.Add(tt.Name); }
            comboBox1.DataSource = categories;
        }

        private void LoadClientData()
        {
            Client currentUser = new Client(1, 2, 3, "john123", "pass123", "John", "Doe", new DateTime(1990, 5, 10), "1234567890", "New York");

            currentUser.email = "example@gmail.com";

            lbLogin.Text = currentUser.Name;
            lbEmail.Text = currentUser.email;
            lbName.Text = currentUser.Name;
            lbSurname.Text = currentUser.Surname;
            lbPesel.Text = currentUser.Pesel;
            lbBirthdate.Text = currentUser.Birthdate.ToString();
            lbAddress.Text = currentUser.Residence;
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

                chlbTestsList.DataSource = null;
                chlbTestsList.Items.Clear();
                chlbTestsList.DataSource = selectedNames;
            }
            else
            {
                chlbTestsList.DataSource = null;
                chlbTestsList.Items.Clear();
                chlbTestsList.DataSource = names;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            List<string> searched = new List<string>();

            foreach (Test t in TestManagement.testList)
            {
                if (t.Name.StartsWith(txtbSearch.Text)) searched.Add(t.Name);
            }

            chlbTestsList.DataSource = null;
            chlbTestsList.Items.Clear();
            chlbTestsList.DataSource = searched;
        }

        private void checkedListBox1_Click(object sender, EventArgs e)
        {
            var selectedName = chlbTestsList.SelectedItem;

            foreach (Test t in TestManagement.testList)
            {
                if (t.Name.Equals(selectedName))
                {
                    label23.Text = t.Description;
                    label27.Text = t.Type;
                    label28.Text = t.Unit;
                    label29.Text = t.Price.ToString();
                    break;
                }
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }
    }
}
