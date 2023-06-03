using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_project
{
    public partial class TechnicianView : Form
    {
        public TechnicianView()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-OBGFI3F;Initial Catalog=Laboratorium;Integrated Security=true";
            SqlConnection connection = new SqlConnection(connectionString);


            // Otwórz połączenie
            connection.Open();


                // Zapytanie SQL pobierające dane
                string query = "SELECT nazwa_badania FROM badania";

                // Utworzenie polecenia SQL
                SqlCommand command = new SqlCommand(query, connection);

                // Wykonanie zapytania i odczyt danych
                SqlDataReader reader = command.ExecuteReader();

                // Czytanie danych i dodawanie ich do ListBox
                while (reader.Read())
                {
                    string value = reader.GetString(0);
                    listBox1.Items.Add(value);
                }

                // Zamknięcie czytnika i połączenia
                reader.Close();
                connection.Close();
            


        }
    }
}
