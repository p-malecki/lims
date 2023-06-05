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
        public AccountDeleteConfimation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client currentUser = new Client(1, 2, 3, "john123", "pass123", "John", "Doe", new DateTime(1990, 5, 10), "1234567890", "New York");
            currentUser.email = "example@gmail.com";

            if (textBox1.Text.Equals(currentUser.email))
            {
                if (textBox2.Text.Equals(currentUser.Login))
                {
                    if (textBox3.Text.Equals(currentUser.Password))
                    {

                    }
                    else
                    {
                        MessageBox.Show("Niepoprawne hasło", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Niepoprawny login", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Niepoprawny adres e-mail", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
