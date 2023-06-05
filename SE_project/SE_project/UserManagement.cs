using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SE_project
{
    internal class UserManagement
    {

        private static User _adminAccount;  // = new User();
        private static List<User> _techniciansAccounts = new List<User>();
        private static List<Client> _clientsAccounts = new List<Client>();

        public UserManagement()
        {
            //_adminAccount = new User(0, 0, 1, "admin", "", "admin", "");
            // load _techniciansAccounts
            // load _clientsAccounts
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

        public static void CreateTechnician()
        {
            throw new NotImplementedException();
        }

        public static void DeactivateTechnician()
        {
            throw new NotImplementedException();
        }

        public static void ActivateTechnician()
        {
            throw new NotImplementedException();
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
                if (client.email.Equals(email))
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

    }
}
