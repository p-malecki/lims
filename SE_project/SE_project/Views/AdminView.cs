using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using SE_project.controllers;

namespace SE_project
{
    public partial class AdminView : Form
    {
        public AdminView()
        {
            InitializeComponent();
            List<FlowLayoutPanel> flpList = new List<FlowLayoutPanel>() { flowLayoutPanel1, flowLayoutPanel2 };
            TestManagement.Initialize(flpList);
            OrderManagement.Initialize();
            TestManagement.LoadTestLists();
            List<string> typeNameList = TestTypeManagement.GetNameList();
            RefreshTypeList(typeNameList);
            RefreshRmTypeList(typeNameList);
            cbAddTestUnits.DataSource = Test.UnitsList;
        }

        private void RefreshTypeList(List<string> list)
        {
            list.Sort();
            cbAddTestType.DataSource = null;
            cbAddTestType.Items.Clear();
            cbAddTestType.DataSource = list;
        }
        private void RefreshRmTypeList(List<string> list)
        {
            list.Sort();
            cbDelSelectType.DataSource = null;
            cbDelSelectType.Items.Clear();
            cbDelSelectType.DataSource = list;
        }

        private void RefreshTechnicianAccountList()
        {
            var items = UserManagement.GetTechnicianList();
            lboxTechnicianAccountsList.DisplayMember = "TechnicianTag";
            lboxTechnicianAccountsList.ValueMember = "TechnicianID";
            lboxTechnicianAccountsList.DataSource = items;
        }
        private void RefreshTechnicianAccountList(object sender, TabControlEventArgs e)
        {
            ResetTechnicianData();
            RefreshTechnicianAccountList();
            lboxTechnicianAccountsList.ClearSelected();
        }

        private void btnChangeAccountsStatus_Click(object sender, EventArgs e)
        {
            User? selectedTechnician = GetSelectedTechnician();
            if (selectedTechnician == null) return;
            int selectedIdx = lboxTechnicianAccountsList.SelectedIndex;

            UserManagement.ChangeAccountStatus(selectedTechnician.ID, 1);
            RefreshTechnicianAccountList();
            lboxTechnicianAccountsList.SelectedIndex = selectedIdx;
            LoadTechnicianData();
        }

        private void ResetTechnicianData()
        {
            lbLoginAccountData.Text = "";
            lbNameAccountData.Text = "";
            lbSurnameAccountData.Text = "";
            lbPhoneNumAccountData.Text = "";
            lbBirthdateAccountData.Text = "";
            lbPeselAccountData.Text = "";
            lbResidenceAccountData.Text = "";
            lbStatusAccountData.Text = "";

            btnChangeAccountStatus.Text = "zmien status";
        }

        private void LoadTechnicianData()
        {
            User? selectedTechnician = GetSelectedTechnician();
            if (selectedTechnician == null) return;

            lbLoginAccountData.Text = selectedTechnician.Login;
            lbNameAccountData.Text = selectedTechnician.Name;
            lbSurnameAccountData.Text = selectedTechnician.Surname;
            lbPhoneNumAccountData.Text = selectedTechnician.PhoneNumber;
            lbBirthdateAccountData.Text = selectedTechnician.GetBirthdateAsString();
            lbPeselAccountData.Text = selectedTechnician.Pesel;
            lbResidenceAccountData.Text = selectedTechnician.Residence;
            lbStatusAccountData.Text = selectedTechnician.Status ? "aktywne" : "nieaktywne";

            btnChangeAccountStatus.Text = (!selectedTechnician.Status) ? "aktywuj konto" : "dezaktywuj konto";

            int filled = DatabaseManagement.GetNumberOftoFillOrder(selectedTechnician.ID);
            int completed = DatabaseManagement.GetNumberOfCompletedOrder(selectedTechnician.ID);
            int denied = DatabaseManagement.GetNumberOfDeniedOrder(selectedTechnician.ID);
            lbStat1AccountData.Text = string.Format("zaakceptowanych badań\noczekujących na wypełnienie: {0}", filled.ToString());
            lbStat2AccountData.Text = string.Format("zakończonych zamówień: {0}", completed.ToString());
            lbStat3AccountData.Text = string.Format("odrzuconych zamówień: {0}", denied.ToString());

        }
        private void LoadTechnicianData(object sender, EventArgs e)
        {
            LoadTechnicianData();
        }

        private void btnAddTechnician_Click(object sender, EventArgs e)
        {
            int year = (int)numNewBirthdateYear.Value;
            int month = (int)numNewBirthdateMonth.Value;
            int day = (int)numNewBirthdateDay.Value;
            DateTime date = new DateTime(year, month, day);

            if (!UserManagement.RegisterTechnician(txtbNewLogin.Text, txtbNewPassword.Text, txtbNewName.Text,
                txtbNewSurname.Text, date, txtbNewPesel.Text, txtbNewResidence.Text, txtbNewPhoneNum.Text))
            {
                MessageBox.Show("Błąd w bazie danych. Nie udało się utworzyć konta", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshTechnicianAccountList();
        }

        private User? GetSelectedTechnician()
        {
            if (lboxTechnicianAccountsList.SelectedItem == null) return null;
            int id = Int32.Parse(lboxTechnicianAccountsList.GetItemText(lboxTechnicianAccountsList.SelectedValue));
            User? currentTechnician = UserManagement.GetTechnicianByID(id);
            return currentTechnician;
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            UserManagement.LogOutUser();
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            TestTypeManagement.CreateType(txtbAddTypeName.Text);
            List<string> typeNameList = TestTypeManagement.GetNameList();
            RefreshTypeList(typeNameList);
            RefreshRmTypeList(typeNameList);
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            if (TestManagement.CreateTest(
                    txtbAddTestName.Text,
                    cbAddTestType.Text,
                    rtxtbAddTestDescription.Text.ToString(),
                    numAddTestMin.Value,
                    numAddTestMax.Value,
                    Test.GetUnitID(cbAddTestUnits.GetItemText(cbAddTestUnits.SelectedValue)),
                    numAddTestPrice.Value
                ) == true)
            {
                TestManagement.LoadTestLists();
            }
        }

        private void btnDelType_Click(object sender, EventArgs e)
        {
            var numOfUsage = TestManagement.CountTestWithType(cbDelSelectType.Text);
            if (numOfUsage > 0)
            {
                string msg = "Nie można usunąc typu testu, ponieważ istnieje co najmniej jeden test tego typu.\nIlość testów: " + numOfUsage;
                MessageBox.Show(msg, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TestTypeManagement.RemoveType(cbDelSelectType.Text);
                List<string> typeNameList = TestTypeManagement.GetNameList();
                RefreshTypeList(typeNameList);
                RefreshRmTypeList(typeNameList);
                MessageBox.Show("Usunięto z powodzeniem", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtbNewPhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

    }
}
