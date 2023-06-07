using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SE_project
{
    internal class UserManagement
    {

        private static User? _activeUser = null;
        private static User _adminAccount = new User(0,0,"admin","1234","admin","");
        private static List<User> _techniciansAccounts = new List<User>();
        private static List<Client> _clientsAccounts = new List<Client>();

        public UserManagement()
        {
            // load data from DB
        }

        public static void CreateClient()
        {
            throw new NotImplementedException();
        }

        public static void DeactivateClient()
        {
            throw new NotImplementedException();
        }

        public static void ActivateClient()
        {
            throw new NotImplementedException();
        }

        public static void CreateTechnician(string login, string password, string name, string surname, DateTime? birthdate = null, string pesel = "0", string residence = "0")
        {
            int id = _techniciansAccounts.Count();
            User newTechnician = new User(id, 1, login, password, name, surname, 1, birthdate, pesel, residence);
            _techniciansAccounts.Add(newTechnician);
        }

        public static void DeactivateTechnician()
        {
            throw new NotImplementedException();
        }

        public static void ActivateTechnician()
        {
            throw new NotImplementedException();
        }

        public static List<string> GetTechnicianNameList()
        {
            List<string> strings = new List<string>();
            foreach (User t in _techniciansAccounts)
                strings.Add(t.Name + " " + t.Surname);
            return strings;
        }

        
        public static User? GetTechnicianByName(string name, string surname)
        {
            foreach (User t in _techniciansAccounts)
            {
                if (t.Name.Equals(name) && t.Surname.Equals(surname))
                    return t;
            }
            return null;
        }

        public static bool IsValidPassword(string password)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*\W).{8,16}$";

            return Regex.IsMatch(password, pattern);
        }

        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            return Regex.IsMatch(email, pattern);
        }

        public static bool IsEmailAlreadyUsed(string email)
        {
            foreach (Client client in _clientsAccounts)
            {
                if (client.Email.Equals(email))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsLoginAlreadyUsed(string login)
        {
            foreach (User user in _techniciansAccounts)
            {
                if (user.Login.Equals(login))
                {
                    return true;
                }
            }
            if (_adminAccount.Login.Equals(login))
            {
                return true;
            }


            return false;
        }

        public static bool IsValidLogin(string login)
        {
            throw new NotImplementedException();
        }

        public static bool LogInUser(int userType, string login, string password)
        {
            User? tmpUser = null;
            if (userType == 0)
            {
                var account = _clientsAccounts.Find(a => a.Login == login);
                if (account != null)
                    tmpUser = account;
            }
            else if (userType == 1)
            {
                var account = _techniciansAccounts.Find(a => a.Login == login);
                if (account != null)
                    tmpUser = account;
            }
            else if (userType == 2)
            {
                if (_adminAccount.Login == login)
                    tmpUser = _adminAccount;
            }

            if (tmpUser != null && tmpUser.Password == password)
            {
                _activeUser = tmpUser;
                return true;
            }
         
            return false;
        }

    }
}
