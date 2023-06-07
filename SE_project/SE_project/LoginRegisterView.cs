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

                txtbLogin.Text = "";
                txtbPassword.Text = "";
                txtbLogin.BackColor = Color.White;
                txtbPassword.BackColor = Color.White;
                cbLoginType.SelectedIndex = 0;
            }
            else
            {
                txtbLogin.BackColor = Color.Red;
                txtbPassword.BackColor = Color.Red;
            }

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            UserManagement.CreateClient();  // TODO read and pass data on to func 
        }
    }
}