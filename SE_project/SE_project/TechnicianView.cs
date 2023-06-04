using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SE_project
{
    public partial class TechnicianView : Form
    {

        public TechnicianView()
        {
            InitializeComponent();
            LoadDataToListBox();
            // LoadDataToComboBox();
        }
        private void LoadDataToListBox()
        {
            string connectionString = "Data Source=DESKTOP-OBGFI3F;Initial Catalog=Laboratorium;Integrated Security=true";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT orderID FROM Orders";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["orderID"]);
                    listBox2.Items.Add(id);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message);
            }
        }
        /*  private void LoadDataToComboBox()
          {
              string connectionString = "Data Source=DESKTOP-OBGFI3F;Initial Catalog=Laboratorium;Integrated Security=true";
              SqlConnection connection = new SqlConnection(connectionString);
              string query = "SELECT testID FROM OrderedTests WHERE orderID='" + @listBox2.Text + "'";
              SqlCommand command = new SqlCommand(query, connection);

              try
              {
                  connection.Open();
                  SqlDataReader reader = command.ExecuteReader();

                  while (reader.Read())
                  {
                      int id = Convert.ToInt32(reader["testID"]);
                      comboBoxResearch.Items.Add(id);
                  }

                  reader.Close();
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Error retrieving data: " + ex.Message);
              }
          }*/

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
            /*  string connectionString = "Data Source=DESKTOP-OBGFI3F;Initial Catalog=Laboratorium;Integrated Security=true";
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
            */


        }
        public static Dictionary<int, List<int>> GetTestData(string query)
        {
            string connectionString = "Data Source=DESKTOP-OBGFI3F;Initial Catalog=Laboratorium;Integrated Security=true";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Dictionary<int, List<int>> data = new Dictionary<int, List<int>>();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int userID = (int)reader["orderID"];
                int testID = (int)reader["testID"];
                if (data.ContainsKey(userID))
                {
                    data[userID].Add(testID);
                }
                else
                {
                    data[userID] = new List<int> { testID };
                }
            }

            return data;
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-OBGFI3F;Initial Catalog=Laboratorium;Integrated Security=true";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "SELECT O.orderID,O.date,Ot.testID FROM Orders as O inner join OrderedTests as Ot on O.orderID =Ot.orderID WHERE O.orderID='" + listBox2.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                Dictionary<int, List<int>> array = new Dictionary<int, List<int>>();
                array = GetTestData(query);
                while (reader.Read())
                {
                    comboBoxResearch.Items.Clear();
                    text_id.Text = reader["orderID"].ToString();
                    textBox13.Text = Convert.ToDateTime(reader["date"]).ToString("dd/MM/yyyy");
                    for (int i = 0; i < array[Convert.ToInt32(reader["orderID"])].Count; i++)
                    {
                        comboBoxResearch.Items.Add(array[Convert.ToInt32(reader["orderID"])][i]);
                    }
                }
                reader.Close();


                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message);
            }
            /*   try
               {
                   connection.Open();
                   string query = "SELECT testID FROM OrderedTests WHERE orderID=@orderID";
                   SqlCommand command = new SqlCommand(query, connection);
                   SqlDataReader reader = command.ExecuteReader();
                   while (reader.Read())
                   {
                       int id = Convert.ToInt32(reader["testID"]);
                       comboBoxResearch.Items.Add(id);
                   }

                   reader.Close();
               }
               catch (Exception ex)
               {
                   MessageBox.Show("Error retrieving data: " + ex.Message);
               }*/
        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxResearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-OBGFI3F;Initial Catalog=Laboratorium;Integrated Security=true";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "SELECT *from Tests where testID='" + comboBoxResearch.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox10.Text = reader["testID"].ToString();
                    textBox11.Text = reader["name"].ToString();
                    textBox12.Text = reader["type"].ToString();
                    //   textBox14.Text = reader["nazwa"].ToString();

                }
                reader.Close();


                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
