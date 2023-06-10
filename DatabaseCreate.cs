using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_project
{
    internal class DatabaseCreate
    {
        public DatabaseCreate()
        {
            string connectionString = "DATA SOURCE";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "CREATE TABLE IF NOT EXISTS Users (userID INTEGER PRIMARY KEY, type INTEGER NOT NULL, status INTEGER NOT NULL, login VARCHAR(256) NOT NULL, password VARCHAR(256) NOT NULL, name VARCHAR(256) NOT NULL, surname VARCHAR(256) NOT NULL, birthdate DATE NOT NULL, pesel VARCHAR(11) UNIQUE NOT NULL, residence VARCHAR(256) NOT NULL, number VARCHAR(9) NOT NULL)";
                    command.ExecuteNonQuery();

                    command.CommandText = "CREATE TABLE IF NOT EXISTS Client (clientID INTEGER PRIMARY KEY, email VARCHAR(256) NOT NULL, FOREIGN KEY (clientID) REFERENCES Users(userID))";
                    command.ExecuteNonQuery();

                    command.CommandText = "CREATE TABLE IF NOT EXISTS Orders (orderID INTEGER PRIMARY KEY, status INTEGER NOT NULL, date DATETIME NOT NULL, clientID INTEGER NOT NULL, technicianID INTEGER NOT NULL, FOREIGN KEY (clientID) REFERENCES Client(clientID), FOREIGN KEY (technicianID) REFERENCES Users(userID))";
                    command.ExecuteNonQuery();

                    command.CommandText = "CREATE TABLE IF NOT EXISTS TestsTypes (testTypeID INTEGER PRIMARY KEY, name VARCHAR(256) NOT NULL, status INTEGER NOT NULL)";
                    command.ExecuteNonQuery();

                    command.CommandText = "CREATE TABLE IF NOT EXISTS Tests (testID INTEGER PRIMARY KEY, name VARCHAR(256) NOT NULL, type INTEGER NOT NULL, descripiton VARCHAR(1000) NOT NULL, minimum DECIMAL NOT NULL, maximum DECIMAL NOT NULL, unit INTEGER NOT NULL, price NUMERIC NOT NULL, status INTEGER NOT NULL, FOREIGN KEY (type) REFERENCES TestsTypes(testTypeID))";
                    command.ExecuteNonQuery();

                    command.CommandText = "CREATE TABLE IF NOT EXISTS ClientTest (clientTestID INTEGER PRIMARY KEY, orderID INTEGER NOT NULL, testID INTEGER NOT NULL, result VARCHAR(256) NOT NULL, stauts INTEGER NOT NULL, FOREIGN KEY (orderID) REFERENCES Orders(orderID), FOREIGN KEY (testID) REFERENCES Tests(testID))";
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}