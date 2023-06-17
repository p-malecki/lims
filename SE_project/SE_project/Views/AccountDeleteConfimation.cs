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
    public partial class AccountDeleteConfimation : Form
    {

        private Client _currentUser;

        public Client CurrentUser { get => _currentUser; set => _currentUser = value; }

        public AccountDeleteConfimation(Client currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            

            if (txtbEmail.Text.Equals(CurrentUser.Email))
                if (txtbLogin.Text.Equals(CurrentUser.Login))
                    if (txtbPassword.Text.Equals(CurrentUser.Password))
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                        MessageBox.Show("Niepoprawne hasło", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Niepoprawny login", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Niepoprawny adres e-mail", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
