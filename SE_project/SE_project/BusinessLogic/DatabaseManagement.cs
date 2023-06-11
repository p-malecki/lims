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
                //if (!File.Exists("./lis.db"))
                //{
                //    SQLiteConnection.CreateFile("lis.db");
                //}

                //cnn.Open();
                //using (SQLiteCommand cmd = new SQLiteCommand(cnn))
                //{
                //    cmd.CommandText = "CREATE TABLE IF NOT EXISTS LabEmployees (employeeID INTEGER PRIMARY KEY, status INTEGER NOT NULL, login VARCHAR(256) NOT NULL, password VARCHAR(256) NOT NULL, name VARCHAR(256) NOT NULL, surname VARCHAR(256) NOT NULL, birthdate DATE NOT NULL, pesel VARCHAR(11) UNIQUE NOT NULL, residence VARCHAR(256) NOT NULL, phoneNum VARCHAR(9) NOT NULL)";
                //    cmd.ExecuteNonQuery();

                //    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Clients (clientID INTEGER PRIMARY KEY, status INTEGER NOT NULL, login VARCHAR(256) NOT NULL, email VARCHAR(256) NOT NULL, password VARCHAR(256) NOT NULL, name VARCHAR(256) NOT NULL, surname VARCHAR(256) NOT NULL, birthdate DATE NOT NULL, pesel VARCHAR(11) UNIQUE NOT NULL, residence VARCHAR(256) NOT NULL, phoneNum VARCHAR(9) NOT NULL)";
                //    cmd.ExecuteNonQuery();

                //    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Orders (orderID INTEGER PRIMARY KEY, status INTEGER NOT NULL, date DATETIME NOT NULL, clientID INTEGER NOT NULL, technicianID INTEGER NOT NULL, FOREIGN KEY (clientID) REFERENCES Client(clientID), FOREIGN KEY (technicianID) REFERENCES Users(userID))";
                //    cmd.ExecuteNonQuery();

                //    cmd.CommandText = "CREATE TABLE IF NOT EXISTS TestsTypes (testTypeID INTEGER PRIMARY KEY, name VARCHAR(256) NOT NULL, status INTEGER NOT NULL)";
                //    cmd.ExecuteNonQuery();

                //    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Tests (testID INTEGER PRIMARY KEY, name VARCHAR(256) NOT NULL, type INTEGER NOT NULL, descripiton VARCHAR(1000) NOT NULL, minimum DECIMAL NOT NULL, maximum DECIMAL NOT NULL, unit INTEGER NOT NULL, price NUMERIC NOT NULL, status INTEGER NOT NULL, FOREIGN KEY (type) REFERENCES TestsTypes(testTypeID))";
                //    cmd.ExecuteNonQuery();

                //    cmd.CommandText = "CREATE TABLE IF NOT EXISTS ClientTest (clientTestID INTEGER PRIMARY KEY, orderID INTEGER NOT NULL, testID INTEGER NOT NULL, result VARCHAR(256) NOT NULL, stauts INTEGER NOT NULL, FOREIGN KEY (orderID) REFERENCES Orders(orderID), FOREIGN KEY (testID) REFERENCES Tests(testID))";
                //    cmd.ExecuteNonQuery();

                //    cmd.CommandText = "CREATE TABLE IF NOT EXISTS ClientTest (clientTestID INTEGER PRIMARY KEY, orderID INTEGER NOT NULL, testID INTEGER NOT NULL, result VARCHAR(256) NOT NULL, stauts INTEGER NOT NULL, FOREIGN KEY (orderID) REFERENCES Orders(orderID), FOREIGN KEY (testID) REFERENCES Tests(testID))";
                //    cmd.ExecuteNonQuery();


                    //cmd.CommandText = "CREATE TABLE IF NOT EXISTS test (testID INTEGER);";
                    //cmd.ExecuteNonQuery();

                    //cmd.CommandText = "INSERT INTO test (testID) Values (3);";
                    //cmd.ExecuteNonQuery();

                    //string query = "SELECT * FROM test";
                    //SQLiteCommand command = new SQLiteCommand(query, cnn);
                    //SQLiteDataReader reader = command.ExecuteReader();
                    //while (reader.Read())
                    //{
                    //    int id = Convert.ToInt32(reader["testID"]);
                    //}
                    //reader.Close();
                //}
                //cnn.Close();
            }
        }

        public static List<Client> LoadClients()
        {
            var clientsList = new List<Client>();
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
                    if (password == null) password = "";
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
            var techniciansList = new List<User>();
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var querySql = "SELECT * FROM Employees WHERE employeeID > 0";
                var techniciansData = cnn.Query(querySql);
                foreach (var t in techniciansData)
                {
                    int id = Convert.ToInt32(t.employeeID);
                    bool status = Convert.ToBoolean(t.status);
                    string login = Convert.ToString(t.login);
                    string password = Convert.ToString(t.password);
                    if (password == null) password = "";
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
                var querySql = "SELECT * FROM Employees WHERE employeeID == 0";
                var a = cnn.Query(querySql).FirstOrDefault();
                if (a != null)
                {
                    int id = Convert.ToInt32(a.employeeID);
                    bool status = Convert.ToBoolean(a.status);
                    string login = Convert.ToString(a.login);
                    string password = Convert.ToString(a.password);
                    if (password == null) password = "";
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
                string data = string.Format("{0},{1},'{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}'",
                    c.ID, c.Status ? 1 : 0, c.Login, c.Email, c.Password, c.Name, c.Surname, c.GetBirthdateAsString(), c.Pesel, c.Residence, c.PhoneNumber);
                string insertSql = "INSERT INTO Clients ({0}) Values ({1});";
                var affectedRow = cnn.Execute(string.Format(insertSql, fields, data));
                return (affectedRow > 0) ? true:false;
            }
        }

        public static bool InsertNewTechnician(User t)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string fields = "employeeID, status, login, password, name, surname, birthdate, pesel, residence, phoneNum";
                string data = string.Format("{0},{1},'{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}'",
                    t.ID, t.Status ? 1 : 0, t.Login, t.Password, t.Name, t.Surname, t.GetBirthdateAsString(), t.Pesel, t.Residence, t.PhoneNumber);
                string insertSql = "INSERT INTO Employees ({0}) Values ({1});";
                var affectedRow = cnn.Execute(string.Format(insertSql, fields, data));
                return (affectedRow > 0) ? true : false;
            }
        }

        public static void ChangeUserPassword(int id, string newPassword)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string query = string.Format("UPDATE Clients SET password='{0}' WHERE clientID={1}", newPassword, id);
                var affectedRow = cnn.Execute(query);
            }
        }

        public static void ChangeUserEmail(int id, string newEmail)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string query = string.Format("UPDATE Clients SET email='{0}' WHERE clientID={1}", newEmail, id);
                var affectedRow = cnn.Execute(query);
            }
        }
        public static void ChangeAccountStatus(int id, int userType, int status)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string query;
                if (userType == 0)
                    query = string.Format("UPDATE Clients SET status='{0}' WHERE clientID={1}", status, id);
                else
                    query = string.Format("UPDATE Employees SET status='{0}' WHERE employeeID={1}", status, id);
                var affectedRow = cnn.Execute(query);
            }
        }


        public static List<TestType> LoadTestTypes()
        {
            var testTypesList = new List<TestType>();
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var querySql = "SELECT * FROM TestsTypes";
                var typeData = cnn.Query(querySql);
                foreach (var c in typeData)
                {
                    string name = Convert.ToString(c.name);
                    bool status = Convert.ToBoolean(c.status);

                    var newType = new TestType(name, status);
                    testTypesList.Add(newType);
                }
            }
            return testTypesList;
        }

        public static void InsertNewTestType(TestType t)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string insertSql = "INSERT INTO TestsTypes (name, status) Values ('" + t.Name + "'," + ((t.Status) ? 1 : 0).ToString() + ");";
                var affectedRow = cnn.Execute(insertSql);
            }
        }

        public static void ChangeTestTypeStatus(string name, int status)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string query = string.Format("UPDATE TestsTypes SET status={0} WHERE name='{1}'", status, name);
                var affectedRow = cnn.Execute(query);
            }
        }


        public static List<Test> LoadTests()
        {
            var testList = new List<Test>();
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var querySql = "SELECT * FROM Tests";
                var testsData = cnn.Query(querySql);
                foreach (var t in testsData)
                {
                    int id = Convert.ToInt32(t.testID);
                    string name = Convert.ToString(t.name);
                    string type = Convert.ToString(t.type);
                    string description = Convert.ToString(t.description);
                    decimal min = Convert.ToDecimal(t.minimumNorm);
                    decimal max = Convert.ToDecimal(t.maximumNorm);
                    int unit = Convert.ToInt32(t.unit);
                    decimal price = Convert.ToDecimal(t.price);
                    bool status = Convert.ToBoolean(t.status);

                    var newTest = new Test(id, name, type, description, min, max, unit, price, status);
                    testList.Add(newTest);
                }
            }
            return testList;
        }

        public static bool InsertNewTest(Test t)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string fields = "testID, name, status, type, description, minimumNorm, maximumNorm, unit, price";
                string data = string.Format("{0},'{1}',{2},'{3}','{4}',{5},{6},{7},{8}", 
                    t.ID, t.Name, t.Status ? 1:0, t.Type, t.Description, t.Min, t.Max, t.Unit, t.Price);
                
                string insertSql = "INSERT INTO Tests ({0}) Values ({1});";
                var affectedRow = cnn.Execute(string.Format(insertSql, fields, data));
                return (affectedRow > 0) ? true : false;
            }
        }

        public static void ChangeTestStatus(int id, int status)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string query = string.Format("UPDATE Tests SET status='{0}' WHERE testID={1}", status, id);
                var affectedRow = cnn.Execute(query);
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




        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}