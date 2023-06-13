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
            cbLoginType.SelectedIndex = 0;
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

            int loginResult = UserManagement.LogInUser(userType, txtbLogin.Text, txtbPassword.Text);
            if (loginResult == 1)
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
            else if (loginResult == 0)
            {
                txtbLogin.BackColor = Color.Red;
                txtbPassword.BackColor = default(Color); ;
            }
            else if (loginResult == -1)
            {
                txtbPassword.BackColor = Color.Red;
                txtbLogin.BackColor = default(Color); ;
            }

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            ResetSignupTxtbColors();

            int year = (int)numNewBirthdateYear.Value;
            int month = (int)numNewBirthdateMonth.Value;
            int day = (int)numNewBirthdateDay.Value;
            DateTime date = new DateTime(year, month, day);

            string signupResult = UserManagement.RegisterClient(txtbNewLogin.Text, txtbNewPassword.Text, txtbNewName.Text, txtbNewSurname.Text,
                date, txtbNewEmail.Text, txtbNewPesel.Text, txtbNewAddress.Text, txtbNewPhoneNum.Text);
            if (signupResult.Equals("ok"))
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
                switch (signupResult)
                {
                    case "login":
                        txtbNewLogin.BackColor = Color.Red;
                        break;
                    case "email":
                        txtbNewEmail.BackColor = Color.Red;
                        break;
                    case "password":
                        txtbNewPassword.BackColor = Color.Red;
                        break;
                    case "birthdate":
                        numNewBirthdateDay.BackColor = Color.Red;
                        numNewBirthdateMonth.BackColor = Color.Red;
                        numNewBirthdateYear.BackColor = Color.Red;
                        break;
                    case "name":
                        txtbNewName.BackColor = Color.Red;
                        break;
                    case "surname":
                        txtbNewSurname.BackColor = Color.Red;
                        break;
                    case "pesel":
                        txtbNewPesel.BackColor = Color.Red;
                        break;
                }
            }
        }

        private void ResetSignupTxtbColors()
        {
            txtbNewLogin.BackColor = default(Color);
            txtbNewEmail.BackColor = default(Color);
            txtbNewPassword.BackColor = default(Color);
            numNewBirthdateDay.BackColor = default(Color);
            numNewBirthdateMonth.BackColor = default(Color);
            numNewBirthdateYear.BackColor = default(Color);
            txtbNewName.BackColor = default(Color);
            txtbNewSurname.BackColor = default(Color);
            txtbNewPesel.BackColor = default(Color);
        }

        private void ResetForm()
        {
            txtbLogin.Text = "";
            txtbPassword.Text = "";
            txtbLogin.BackColor = default(Color);
            txtbPassword.BackColor = default(Color);
            ResetSignupTxtbColors();
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
            txtbNewSex.SelectedIndex = 0;
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