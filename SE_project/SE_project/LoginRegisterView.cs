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

            // TODO check whether login data is correct

            switch (cbLoginType.Text)
            {
                case "Klient":
                    ClientView clientForm = new ClientView();
                    clientForm.Show();
                    break;
                case "Technik laboratoryjny":
                    TechnicianView technicianForm = new TechnicianView();
                    technicianForm.Show();
                    break;
                case "Administrator":
                    AdminView adminForm = new AdminView();
                    adminForm.Show();
                    break;
            }
            this.Hide();
        }
    }
}