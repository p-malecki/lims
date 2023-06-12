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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace SE_project.controllers
{
    internal static class DatabaseManagement
    {    
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
                    int id = Convert.ToInt32(c.testTypeID);
                    string name = Convert.ToString(c.name);
                    bool status = Convert.ToBoolean(c.status);

                    var newType = new TestType(id, name, status);
                    testTypesList.Add(newType);
                }
            }
            return testTypesList;
        }

        public static void InsertNewTestType(TestType t)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string insertSql = "INSERT INTO TestsTypes (typeID, name, status) Values (" + t.ID + ", '" + t.Name + "'," + ((t.Status) ? 1 : 0).ToString() + ");";
                cnn.Execute(insertSql);
            }
        }

        public static void ChangeTestTypeStatus(string name, int status)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string query = string.Format("UPDATE TestsTypes SET status={0} WHERE name='{1}'", status, name);
                cnn.Execute(query);
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
                    int type = Convert.ToInt32(t.type);
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

        public static void InsertNewOrder(Order o)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string insertSql = "INSERT INTO Orders (orderID, status, date, clientID, technicianID) Values (" + o.ID.ToString() + "," + o.Status.ToString() + ",'" + o.Date.ToString() + "'," + o.ClientID.ToString() + "," + o.TechnicianID.ToString() + ")";
                var affectedRow = cnn.Execute(insertSql);
            }
        }

        public static void InsertNewOrderClientTests(List<ClientTest> clientTests)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                foreach (ClientTest ct in clientTests)
                {
                    string insertSql = "INSERT INTO ClientTest (clientTestID, status, orderID, testID, result) Values (" + ct.ID.ToString() + "," + ((ct.Status) ? 1 : 0).ToString() + "," + ct.OrderID.ToString() + "," + ct.TestID.ToString() + ",\"\")";
                    var affectedRow = cnn.Execute(insertSql);
                }
            }
        }

        public static int getFreeClientTestsID()
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var querySql = "SELECT clientTestID FROM ClientTest ORDER BY clientTestID DESC LIMIT 1";
                var typeData = cnn.Query(querySql);
                int id = 0;
                foreach (var c in typeData)
                {
                    id = Convert.ToInt32(c.clientTestID);

                }
                return id + 1;
            }
        }

        public static List<ClientTest> GetClientTests(int orderID)
        {
            List<ClientTest> clientTests = new List<ClientTest>();
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var querySql = "SELECT * FROM ClientTest WHERE orderID = " + orderID.ToString();
                var typeData = cnn.Query(querySql);

                foreach (var c in typeData)
                {
                    int id = Convert.ToInt32(c.clientTestID);
                    bool status = Convert.ToBoolean(c.status);
                    int testid = Convert.ToInt32(c.testID);
                    string result = Convert.ToString(c.result);

                    clientTests.Add(new ClientTest(id, orderID, result, testid, status));

                }

                return clientTests;
            }
        }

        public static List<Order> getToAcceptOrderList()
        {
            List<Order> orders = new List<Order>();

            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var querySql = "SELECT * FROM Orders WHERE status = 0";
                var typeData = cnn.Query(querySql);
                foreach (var c in typeData)
                {
                    int id = Convert.ToInt32(c.orderID);
                    int status = Convert.ToInt32(c.status);
                    DateTime date = Convert.ToDateTime(c.date);
                    int clientid = Convert.ToInt32(c.clientID);
                    int technicianid = Convert.ToInt32(c.technicianID);

                    orders.Add(new Order(id, status, date, clientid, technicianid, GetClientTests(id)));
                }

                return orders;
            }
        }

        public static List<Order> getToFillOrderList()
        {
            List<Order> orders = new List<Order>();

            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var querySql = "SELECT * FROM Orders WHERE status = 1";
                var typeData = cnn.Query(querySql);
                foreach (var c in typeData)
                {
                    int id = Convert.ToInt32(c.orderID);
                    int status = Convert.ToInt32(c.status);
                    DateTime date = Convert.ToDateTime(c.date);
                    int clientid = Convert.ToInt32(c.clientID);
                    int technicianid = Convert.ToInt32(c.technicianID);

                    orders.Add(new Order(id, status, date, clientid, technicianid, GetClientTests(id)));
                }

                return orders;
            }
        }

        public static List<Order> getCompletedOrderList()
        {
            List<Order> orders = new List<Order>();

            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var querySql = "SELECT * FROM Orders WHERE status = 2";
                var typeData = cnn.Query(querySql);
                foreach (var c in typeData)
                {
                    int id = Convert.ToInt32(c.orderID);
                    int status = Convert.ToInt32(c.status);
                    DateTime date = Convert.ToDateTime(c.date);
                    int clientid = Convert.ToInt32(c.clientID);
                    int technicianid = Convert.ToInt32(c.technicianID);

                    orders.Add(new Order(id, status, date, clientid, technicianid, GetClientTests(id)));
                }

                return orders;
            }
        }

        public static List<Order> getDeniedOrderList()
        {
            List<Order> orders = new List<Order>();

            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var querySql = "SELECT * FROM Orders WHERE status = -1";
                var typeData = cnn.Query(querySql);
                foreach (var c in typeData)
                {
                    int id = Convert.ToInt32(c.orderID);
                    int status = Convert.ToInt32(c.status);
                    DateTime date = Convert.ToDateTime(c.date);
                    int clientid = Convert.ToInt32(c.clientID);
                    int technicianid = Convert.ToInt32(c.technicianID);

                    orders.Add(new Order(id, status, date, clientid, technicianid, GetClientTests(id)));
                }

                return orders;
            }
        }

        public static bool isNotOrderedTwice(DateTime date)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var querySql = "SELECT * FROM Orders WHERE date LIKE '" + date.Day.ToString() + ".";
                if (date.Month < 10)
                    querySql += '0';
                querySql += date.Month.ToString() + "." + date.Year.ToString() + "%'";
                var testsData = cnn.Query(querySql);
                foreach (var t in testsData)
                {
                    return false;
                }

                return true;
            }
        }

        public static List<Order> getClientOrders(int clientID)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                List<Order> orders = new List<Order>();
                var querySql = "SELECT * FROM Orders WHERE clientID =" + clientID.ToString();
                var testsData = cnn.Query(querySql);
                foreach (var t in testsData)
                {
                    int orderid = Convert.ToInt32(t.orderID);
                    int status = Convert.ToInt32(t.status);
                    DateTime date = Convert.ToDateTime(t.date);
                    int technicianid = Convert.ToInt32(t.technicianID);

                    orders.Add(new Order(orderid, status, date, clientID, technicianid, GetClientTests(orderid)));
                }

                return orders;
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

        internal static bool ChangeTestParams(int id, string type, string description, decimal minVal, decimal maxVal, int unit, decimal price)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string data = string.Format("type='{0}',description='{1}',minimumNorm={2},maximumNorm={3},unit={4},price={5}",
                    type, description, minVal, maxVal, unit, price);
                string insertSql = "UPDATE Tests SET {0} WHERE testID={1};";
                var affectedRow = cnn.Execute(string.Format(insertSql, data, id));
                return (affectedRow > 0) ? true : false;
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }



    }
}