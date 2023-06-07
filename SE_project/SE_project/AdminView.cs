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

namespace SE_project
{
    public partial class AdminView : Form
    {
        public AdminView()
        {
            InitializeComponent();
            List<FlowLayoutPanel> flpList = new List<FlowLayoutPanel>() { flowLayoutPanel1, flowLayoutPanel2 };
            TestManagement.InitTestManagement(flpList);

            //cbAddTestUnits.SelectedIndex = 0;
            cbAddTestUnits.DisplayMember = "Text";
            cbAddTestUnits.ValueMember = "Value";

            var items = new[] {
                new { Text = "Femtoliter ", Value = "fL"},
                new { Text = "Grams", Value = "g"},
                new { Text = "Grams per deciliter", Value = "g/dL"},
                new { Text = "Grams per liter", Value = "g/L"},
                new { Text = "International units per liter", Value = "IU/L"},
                new { Text = "International units per milliliter", Value = "IU/mL"},
                new { Text = "Micrograms", Value = "mcg"},
                new { Text = "Micrograms per deciliter", Value = "mcg/dL"},
                new { Text = "Micrograms per liter", Value = "mcg/L"},
                new { Text = "Microkatals per liter", Value = "mckat/L"},
                new { Text = "Microliters", Value = "mcL"},
                new { Text = "Micromoles per liter", Value = "mcmol/L"},
                new { Text = "Milliequivalents", Value = "mEq"},
                new { Text = "Milliequivalents per liter", Value = "mEq/L"},
                new { Text = "Milligrams", Value = "mg"},
                new { Text = "Milligrams per deciliter", Value = "mg/dL"},
                new { Text = "Milligrams per liter", Value = "mg/L"},
                new { Text = "Milli-international units per liter", Value = "mIU/L"},
                new { Text = "Milliliters", Value = "mL"},
                new { Text = "Millimeters", Value = "mm"},
                new { Text = "Millimeters of mercury", Value = "mm Hg"},
                new { Text = "Millimoles", Value = "mmol"},
                new { Text = "Millimoles per liter", Value = "mmol/L"},
                new { Text = "Milliosmoles per kilogram of water", Value = "mOsm/kg water"},
                new { Text = "Milliunits per gram", Value = "mU/g"},
                new { Text = "Milliunits per liter", Value = "mU/L"},
                new { Text = "Nanograms per deciliter", Value = "ng/dL"},
                new { Text = "Nanograms per liter", Value = "ng/L"},
                new { Text = "Nanograms per milliliter", Value = "ng/mL"},
                new { Text = "Nanograms per milliliter per hour", Value = "ng/mL/hr"},
                new { Text = "Nanomoles", Value = "nmol"},
                new { Text = "Nanomoles per liter", Value = "nmol/L"},
                new { Text = "Picograms", Value = "pg"},
                new { Text = "Picograms per milliliter", Value = "pg/mL"},
                new { Text = "Picomoles per liter", Value = "pmol/L"},
                new { Text = "Units per liter", Value = "U/L"},
                new { Text = "Units per milliliter", Value = "U/mL"}
            }; // TODO import from DB
            cbAddTestUnits.DataSource = items;
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
            List<string> names = UserManagement.GetTechnicianNameList();
            names.Sort();
            lboxTechnicianAccountsList.Items.Clear();
            lboxTechnicianAccountsList.Items.AddRange(names.ToArray());
            ResetTechnicianData();
        }

        private void RefreshTechnicianAccountList(object sender, TabControlEventArgs e)
        {
            RefreshTechnicianAccountList();
        }


        private User? GetSelectedTechnician()
        {
            if (lboxTechnicianAccountsList.SelectedItem == null) return null;
            string[] name = lboxTechnicianAccountsList.SelectedItem.ToString().Split(" ");
            User? currentTechnician = UserManagement.GetTechnicianByName(name[0], name[1]);
            return currentTechnician;
        }

        private void txtbAddTestID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
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
            int id = 0;
            try
            {
                id = Int32.Parse(txtbAddTestID.Text);
            }
            catch (Exception ex)
            {
                string strID = txtbAddTestID.Text;
                while (strID[0] == '0')
                    strID = strID.Substring(1);
                if (strID != "")
                    id = Int32.Parse(txtbAddTestID.Text);
            }
            TestManagement.CreateTest(
                    id,
                    txtbAddTestName.Text,
                    cbAddTestType.Text,
                    rtxtbAddTestDescription.Text.ToString(),
                    numAddTestMin.Value,
                    numAddTestMax.Value,
                    cbAddTestUnits.GetItemText(cbAddTestUnits.SelectedValue),
                    numAddTestPrice.Value
                );
            TestManagement.LoadTestLists();
        }

        private void btnDelType_Click(object sender, EventArgs e)
        {
            TestTypeManagement.RemoveType(cbDelSelectType.Text);
            List<string> typeNameList = TestTypeManagement.GetNameList();
            RefreshTypeList(typeNameList);
            RefreshRmTypeList(typeNameList);
        }
        private void btnChangeAccountsStatus_Click(object sender, EventArgs e)
        {
            User? currentTechnician = GetSelectedTechnician();
            if (currentTechnician == null) return;

            currentTechnician.Status = (currentTechnician.Status == 0) ? 1 : 0;
            RefreshTechnicianAccountList();
        }

        private void ResetTechnicianData()
        {
            lbLoginAccountData.Text = "";
            lbNameAccountData.Text = "";
            lbSurnameAccountData.Text = "";
            lbBirthdateAccountData.Text = "";
            lbPeselAccountData.Text = "";
            lbResidenceAccountData.Text = "";
            lbStatusAccountData.Text = "";

            btnChangeAccountStatus.Text = "zmien status";
        }


        private void LoadTechnicianData(object sender, EventArgs e)
        {
            User? currentTechnician = GetSelectedTechnician();
            if (currentTechnician == null) return;

            lbLoginAccountData.Text = currentTechnician.Login.ToString();
            lbNameAccountData.Text = currentTechnician.Name.ToString();
            lbSurnameAccountData.Text = currentTechnician.Surname.ToString();
            lbBirthdateAccountData.Text = currentTechnician.GetBirthdateAsString();
            lbPeselAccountData.Text = currentTechnician.Pesel.ToString();
            lbResidenceAccountData.Text = currentTechnician.Residence.ToString();
            lbStatusAccountData.Text = currentTechnician.Status.ToString();

            btnChangeAccountStatus.Text = (currentTechnician.Status == 0) ? "aktywuj konto" : "dezaktywuj konto";
        }

        private void btnAddTechnician_Click(object sender, EventArgs e)
        {
            int year = (int)numNewBirthdateYear.Value;
            int month = (int)numNewBirthdateMonth.Value;
            int day = (int)numNewBirthdateDay.Value;
            DateTime? date = new DateTime(year, month, day);

            UserManagement.CreateTechnician(
                    txtbNewLogin.Text,
                    txtbNewPassword.Text,
                    txtbNewName.Text,
                    txtbNewSurname.Text,
                    date,
                    txtbNewPesel.Text,
                    txtbNewResidence.Text
                );

            RefreshTechnicianAccountList();
        }

    }
}
