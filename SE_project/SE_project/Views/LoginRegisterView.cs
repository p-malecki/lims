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
    public partial class LoginRegisterView : Form
    {
        public LoginRegisterView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int userType = 0;
            switch (cbLoginType.Text)
            {
                case "Klient":
                    userType = 0;
                    break;
                case "Technik laboratoryjny":
                    userType = 1;
                    break;
                case "Administrator":
                    userType = 2;
                    break;
            }

            if (UserManagement.LogInUser(userType, txtbLogin.Text, txtbPassword.Text))
            {
                switch (userType)
                {
                    case 0:
                        ClientView clientForm = new ClientView();
                        clientForm.Show();
                        clientForm.Closed += (s, args) => this.Show();
                        break;
                    case 1:
                        TechnicianView technicianForm = new TechnicianView();
                        technicianForm.Show();
                        technicianForm.Closed += (s, args) => this.Show();
                        break;
                    case 2:
                        AdminView adminForm = new AdminView();
                        adminForm.Show();
                        adminForm.Closed += (s, args) => this.Show();
                        break;
                }
                this.Hide();
                ResetForm();
            }
            else
            {
                txtbLogin.BackColor = Color.Red;
                txtbPassword.BackColor = Color.Red;
            }

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            int year = (int)numNewBirthdateYear.Value;
            int month = (int)numNewBirthdateMonth.Value;
            int day = (int)numNewBirthdateDay.Value;
            DateTime date = new DateTime(year, month, day);

            if (UserManagement.RegisterClient(txtbNewLogin.Text, txtbNewPassword.Text, txtbNewName.Text, txtbNewSurname.Text,
                date, txtbNewEmail.Text, txtbNewPesel.Text, txtbNewAddress.Text, txtbNewPhoneNum.Text))
            {
                btnSignUp.BackColor = Color.Green;
                txtbNewLogin.Enabled = false;
                txtbNewEmail.Enabled = false;
                txtbNewPassword.Enabled = false;
                txtbNewName.Enabled = false;
                txtbNewSurname.Enabled = false;
                txtbNewPesel.Enabled = false;
                txtbNewAddress.Enabled = false;
                txtbNewPhoneNum.Enabled = false;
                numNewBirthdateDay.Enabled = false;
                numNewBirthdateMonth.Enabled = false;
                numNewBirthdateYear.Enabled = false;
                btnSignUp.Enabled = false;
            }
            else
            {
                btnSignUp.BackColor = Color.Red;
            }
        }

        private void ResetForm()
        {
            txtbLogin.Text = "";
            txtbPassword.Text = "";
            txtbLogin.BackColor = default(Color);
            txtbPassword.BackColor = default(Color);
            cbLoginType.SelectedIndex = 0;

            txtbNewLogin.Enabled = true;
            txtbNewEmail.Enabled = true;
            txtbNewPassword.Enabled = true;
            txtbNewName.Enabled = true;
            txtbNewSurname.Enabled = true;
            txtbNewPesel.Enabled = true;
            txtbNewAddress.Enabled = true;
            txtbNewPhoneNum.Enabled = true;
            btnSignUp.Enabled = true;
            numNewBirthdateDay.Enabled = true;
            numNewBirthdateMonth.Enabled = true;
            numNewBirthdateYear.Enabled = true;
            txtbNewLogin.Text = "";
            txtbNewEmail.Text = "";
            txtbNewPassword.Text = "";
            txtbNewName.Text = "";
            txtbNewSurname.Text = "";
            txtbNewPesel.Text = "";
            txtbNewAddress.Text = "";
            txtbNewPhoneNum.Text = "";
            btnSignUp.BackColor = SystemColors.ButtonFace;
        }

        private void TabChange(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void txtbPhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }
    }
}