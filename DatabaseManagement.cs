using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace SE_project
{
    internal class DatabaseManagement
    {
        static string connectionString = "Data Source=ścieżka/do/pliku.db";
        static SQLiteConnection connection = new SQLiteConnection(connectionString);

        public List<Client> GetClientsFromDatabase()
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            List<Client> clients = new List<Client>();
            string query = "SELECT * FROM Clients INNER JOIN Users ON Clients.clientID = Users.userID";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["userID"]);
                int type = Convert.ToInt32(reader["type"]);
                bool status = Convert.ToBoolean(reader["status"]);
                string login = Convert.ToString(reader["login"]);
                string password = Convert.ToString(reader["password"]);
                string name = Convert.ToString(reader["name"]);
                string surname = Convert.ToString(reader["surname"]);
                DateTime birtdate = Convert.ToDateTime(reader["birthdate"]);
                string email = Convert.ToString(reader["email"]);
                string pesel = Convert.ToString(reader["pesel"]);
                string residence = Convert.ToString(reader["residence"]);

                Client client = new Client(id, login, password, name, surname, birtdate, email, pesel, residence);
                clients.Add(client);
            }

            reader.Close();

            return clients;
        }

        public List<User> GetTechniciansFromDatabase()
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            List<User> technicians = new List<User>();
            string query = "SELECT * FROM Users WHERE type = 1";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["userID"]);
                bool status = Convert.ToBoolean(reader["status"]);
                string login = Convert.ToString(reader["login"]);
                string password = Convert.ToString(reader["password"]);
                string name = Convert.ToString(reader["name"]);
                string surname = Convert.ToString(reader["surname"]);
                DateTime birtdate = Convert.ToDateTime(reader["birthdate"]);
                string pesel = Convert.ToString(reader["pesel"]);
                string residence = Convert.ToString(reader["residence"]);

                User technician = new User(id, 1, login, password, name, surname, 1, birtdate, pesel, residence);
                technicians.Add(technician);
            }

            reader.Close();

            return technicians;
        }

        public List<Order> GetToAcceptOrderList()
        {
            throw new NotImplementedException();
        }

        public List<Order> GetToFillOrderList()
        {
            throw new NotImplementedException();
        }

        public List<Order> GetCompletedOrderList()
        {
            throw new NotImplementedException();
        }

        public List<Order> GetDeniedOrderList()
        {
            throw new NotImplementedException();
        }

        public void ChangeUserPassword(int id, string newPassword)
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            string query = "UPDATE Users SET password = @newPassword WHERE userID = @id";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@newPassword", newPassword);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }

        public void ChangeUserLogin(int id, string newLogin)
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            string query = "UPDATE Users SET login = @newLogin WHERE userID = @id";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@newLogin", newLogin);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }
        public static void ChangeUserEmail(int id, string newEmail)
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            string query = "UPDATE Users SET email = @newEmail WHERE userID = @id";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@newEmail", newEmail);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }
    }
}