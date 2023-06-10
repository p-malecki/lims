using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Configuration;
using System.Data;
using Dapper;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System.Security.Policy;
using System.Windows.Forms;
using System.Xml;

namespace SE_project.controllers
{
    internal static class DatabaseManagement
    {
        public static void DatabaseCreate()
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(cnn))
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS LabEmployees (employeeID INTEGER PRIMARY KEY, status INTEGER NOT NULL, login VARCHAR(256) NOT NULL, password VARCHAR(256) NOT NULL, name VARCHAR(256) NOT NULL, surname VARCHAR(256) NOT NULL, birthdate DATE NOT NULL, pesel VARCHAR(11) UNIQUE NOT NULL, residence VARCHAR(256) NOT NULL, phoneNum VARCHAR(9) NOT NULL)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Clients (clientID INTEGER PRIMARY KEY, status INTEGER NOT NULL, login VARCHAR(256) NOT NULL, email VARCHAR(256) NOT NULL, password VARCHAR(256) NOT NULL, name VARCHAR(256) NOT NULL, surname VARCHAR(256) NOT NULL, birthdate DATE NOT NULL, pesel VARCHAR(11) UNIQUE NOT NULL, residence VARCHAR(256) NOT NULL, phoneNum VARCHAR(9) NOT NULL)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Orders (orderID INTEGER PRIMARY KEY, status INTEGER NOT NULL, date DATETIME NOT NULL, clientID INTEGER NOT NULL, technicianID INTEGER NOT NULL, FOREIGN KEY (clientID) REFERENCES Client(clientID), FOREIGN KEY (technicianID) REFERENCES Users(userID))";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS TestsTypes (testTypeID INTEGER PRIMARY KEY, name VARCHAR(256) NOT NULL, status INTEGER NOT NULL)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Tests (testID INTEGER PRIMARY KEY, name VARCHAR(256) NOT NULL, type INTEGER NOT NULL, descripiton VARCHAR(1000) NOT NULL, minimum DECIMAL NOT NULL, maximum DECIMAL NOT NULL, unit INTEGER NOT NULL, price NUMERIC NOT NULL, status INTEGER NOT NULL, FOREIGN KEY (type) REFERENCES TestsTypes(testTypeID))";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS ClientTest (clientTestID INTEGER PRIMARY KEY, orderID INTEGER NOT NULL, testID INTEGER NOT NULL, result VARCHAR(256) NOT NULL, stauts INTEGER NOT NULL, FOREIGN KEY (orderID) REFERENCES Orders(orderID), FOREIGN KEY (testID) REFERENCES Tests(testID))";
                    cmd.ExecuteNonQuery();
                }
                cnn.Close();
            }
        }

        public static List<Client> LoadClients()
        {
            List<Client> clientsList = new List<Client>();
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var querySql = "SELECT * FROM Clients";
                var clientsData = cnn.Query(querySql);
                foreach (var c in clientsData)
                {
                    int id = Convert.ToInt32(c.clientID);
                    bool status = Convert.ToBoolean(c.status);
                    string login = Convert.ToString(c.login);
                    string password = Convert.ToString(c.password);
                    string name = Convert.ToString(c.name);
                    string surname = Convert.ToString(c.surname);
                    DateTime birthdate = Convert.ToDateTime(c.birthdate);
                    string email = Convert.ToString(c.email);
                    string phoneNum = Convert.ToString(c.phoneNum);
                    string pesel = Convert.ToString(c.pesel);
                    string residence = Convert.ToString(c.residence);

                    Client newClient = new Client(id, login, password, name, surname,
                        birthdate, email, pesel, residence, phoneNum, status);
                    clientsList.Add(newClient);
                }
            }
            return clientsList;
        }

        public static List<User> LoadTechnicians()
        {
            List<User> techniciansList = new List<User>();
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var querySql = "SELECT * FROM LabEmployees WHERE employeeID > 0";
                var techniciansData = cnn.Query(querySql);
                foreach (var t in techniciansData)
                {
                    int id = Convert.ToInt32(t.employeeID);
                    bool status = Convert.ToBoolean(t.status);
                    string login = Convert.ToString(t.login);
                    string password = Convert.ToString(t.password);
                    string name = Convert.ToString(t.name);
                    string surname = Convert.ToString(t.surname);
                    DateTime birthdate = Convert.ToDateTime(t.birthdate);
                    string phoneNum = Convert.ToString(t.phoneNum);
                    string pesel = Convert.ToString(t.pesel);
                    string residence = Convert.ToString(t.residence);

                    User newTechnician = new User(id, 1, login, password, name, surname,
                        status, birthdate, pesel, residence, phoneNum);
                    techniciansList.Add(newTechnician);
                }
            }
            return techniciansList;
        }

        public static User LoadAdmin()
        {
            User admin = new User(0, 0, "a", "", "admin", "");
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var querySql = "SELECT * FROM LabEmployees WHERE employeeID == 0";
                var a = cnn.Query(querySql).FirstOrDefault();
                if (a != null)
                {
                    int id = Convert.ToInt32(a.employeeID);
                    bool status = Convert.ToBoolean(a.status);
                    string login = Convert.ToString(a.login);
                    string password = Convert.ToString(a.password);
                    string name = Convert.ToString(a.name);
                    string surname = Convert.ToString(a.surname);
                    DateTime birthdate = Convert.ToDateTime(a.birthdate);
                    string phoneNum = Convert.ToString(a.phoneNum);
                    string pesel = Convert.ToString(a.pesel);
                    string residence = Convert.ToString(a.residence);

                    admin = new User(id, 0, login, password, name, surname,
                    status, birthdate, pesel, residence, phoneNum);
                }
            }
            return admin;
        }

        public static bool InsertNewClient(Client c)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string fields = "clientID, status, login, email, password, name, surname, birthdate, pesel, residence, phoneNum";
                string data = "'c.ID.ToString()',";
                data += "c.Status.ToString(),";
                data += "'c.Login','c.Email','c.Password','c.Name','c.Surname',";
                data += "c.Birthdate,";
                data += "'c.Pesel','c.Residence','c.PhoneNumber'";
                string insertSql = "INSERT INTO Clients ({0}) Values ({1});";
                var affectedRow = cnn.Execute(String.Format(insertSql, fields, data));
                return (affectedRow > 0) ? true:false;
            }
        }


        //public List<Order> GetToAcceptOrderList()
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Order> GetToFillOrderList()
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Order> GetCompletedOrderList()
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Order> GetDeniedOrderList()
        //{
        //    throw new NotImplementedException();
        //}

        //public void ChangeUserPassword(int id, string newPassword)
        //{
        //    if (cnn.State != System.Data.ConnectionState.Open)
        //        cnn.Open();

        //    string query = "UPDATE Users SET password = @newPassword WHERE userID = @id";
        //    SQLiteCommand command = new SQLiteCommand(query, cnn);
        //    command.Parameters.AddWithValue("@newPassword", newPassword);
        //    command.Parameters.AddWithValue("@id", id);
        //    command.ExecuteNonQuery();
        //}

        //public void ChangeUserLogin(int id, string newLogin)
        //{
        //    if (cnn.State != System.Data.ConnectionState.Open)
        //        cnn.Open();

        //    string query = "UPDATE Users SET login = @newLogin WHERE userID = @id";
        //    SQLiteCommand command = new SQLiteCommand(query, cnn);
        //    command.Parameters.AddWithValue("@newLogin", newLogin);
        //    command.Parameters.AddWithValue("@id", id);
        //    command.ExecuteNonQuery();
        //}
        //public static void ChangeUserEmail(int id, string newEmail)
        //{
        //    if (cnn.State != System.Data.ConnectionState.Open)
        //        cnn.Open();

        //    string query = "UPDATE Users SET email = @newEmail WHERE userID = @id";
        //    SQLiteCommand command = new SQLiteCommand(query, cnn);
        //    command.Parameters.AddWithValue("@newEmail", newEmail);
        //    command.Parameters.AddWithValue("@id", id);
        //    command.ExecuteNonQuery();
        //}


        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}