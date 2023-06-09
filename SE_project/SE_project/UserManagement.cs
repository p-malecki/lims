using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Globalization;

namespace SE_project
{
    internal static class UserManagement
    {
        private static User? _activeUser = null;
        private static User _adminAccount = new User(0, 0, "a", "", "admin", "");
        private static List<User> _techniciansAccounts = new List<User>();
        private static List<Client> _clientsAccounts = new List<Client>();
        private static TextInfo myTI = new CultureInfo("pl-PL", false).TextInfo;

        public static User ActiveUser { get => _activeUser; set => _activeUser = value; }

        public static void Initialize()
        {
            // load data from DB
            _clientsAccounts.Add(new Client(0, "k", "", "client", "", new DateTime(1990, 5, 10), "@"));
            _techniciansAccounts.Add(new User(0, 1, "t", "", "technician", ""));
        }

        public static bool RegisterClient(string login, string password, string name, string surname,
            DateTime birthdate, string email, string pesel, string residence, string phoneNum)
        {
            int id = _clientsAccounts.Count();
            login = login.ToLower();
            email = email.ToLower();
            if (IsValidLogin(login) && !IsLoginAlreadyUsed(login, 0) && IsValidEmail(email) && !IsEmailAlreadyUsed(email))
                if (IsValidPassword(password) && IsValidBirthdate(birthdate) && name.Length!=0 && surname.Length != 0)
                    if (pesel.Length==0 || pesel=="0" || IsValidPesel(pesel) && !IsPeselAlreadyUsed(pesel,0))
                    {
                        if (pesel.Length <= 1) pesel = "0";
                        if (residence.Length == 0) residence = "-";
                        if (phoneNum.Length == 0) phoneNum = "-";
                        name = myTI.ToTitleCase(name);
                        surname = myTI.ToTitleCase(surname);
                         
                        Client newClient = new Client(id, login, password, name, surname, birthdate, email, pesel, residence, phoneNum);
                        _clientsAccounts.Add(newClient);
                        return true;
                    }
            return false;
        }


        public static bool RegisterTechnician(string login, string password, string name, string surname,
            DateTime birthdate, string pesel, string residence, string phoneNum)
        {
            int id = _techniciansAccounts.Count();
            login = login.ToLower();
            if (IsValidLogin(login) && !IsLoginAlreadyUsed(login, 1))
                if (IsValidPassword(password) && IsValidBirthdate(birthdate) && name.Length != 0 && surname.Length != 0)
                    if (pesel.Length == 0 || pesel == "0" || IsValidPesel(pesel) && !IsPeselAlreadyUsed(pesel, 1))
                    {
                        if (pesel.Length <= 1) pesel = "0";
                        if (residence.Length == 0) residence = "-";
                        if (phoneNum.Length == 0) phoneNum = "-";
                        name = myTI.ToTitleCase(name);
                        surname = myTI.ToTitleCase(surname);

                        User newTechnician = new User(id, 1, login, password, name, surname, 1, birthdate, pesel, residence, phoneNum);
                        _techniciansAccounts.Add(newTechnician);
                        return true;
                    }
            return false;
        }

        public static void ChangeAccountStatus(int id, int type, int status)
        {
            User? account = null;
            if (type == 0)
                account = _clientsAccounts.Find(t => t.ID == id);
            else if (type == 1)
                account = _techniciansAccounts.Find(t => t.ID == id);

            if (account != null)
                account.Status = status;
        }


        public static List<dynamic> GetTechnicianList()
        {
            var items = new List<dynamic>();
            foreach(var t in _techniciansAccounts)
                items.Add(new { TechnicianTag = t.Name + " " + t.Surname, TechnicianID = t.ID });
            return items;
        }

        
        public static User? GetTechnicianByID(int id)
        {
            var account = _techniciansAccounts.Find(t => t.ID == id);
            return account;
        }


        public static bool IsValidLogin(string login)
        {
            string pattern = @"^(?=.*[\w\d]).{3,30}$";
            return Regex.IsMatch(login, pattern);
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
        public static bool IsValidPesel(string pesel)
        {
            string pattern = @"^\d{11}$";
            return Regex.IsMatch(pesel, pattern);
        }

        public static bool IsValidBirthdate(DateTime date)
        {
            DateTime now = DateTime.Now;
            return date < now;
        }

        public static bool IsEmailAlreadyUsed(string email)
        {
            foreach (Client client in _clientsAccounts)
                if (client.Email.Equals(email))
                    return true;
            return false;
        }

        public static bool IsLoginAlreadyUsed(string login, int userType)
        {
            switch (userType)
            {
                case 0:
                    foreach (Client user in _clientsAccounts)
                        if (user.Login.Equals(login))
                            return true;
                    break;
                case 1:
                    foreach (User user in _techniciansAccounts)
                        if (user.Login.Equals(login))
                            return true;
                    break;
                case 2:
                    return _adminAccount.Login.Equals(login);
            }
            return false;
        }
        public static bool IsPeselAlreadyUsed(string pesel, int userType)
        {
            switch (userType)
            {
                case 0:
                    foreach (Client user in _clientsAccounts)
                        if (user.Pesel.Equals(pesel))
                            return true;
                    break;
                case 1:
                    foreach (User user in _techniciansAccounts)
                        if (user.Pesel.Equals(pesel))
                            return true;
                    break;
            }
            return false;
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

        public static void LogOutUser()
        {
            _activeUser = null;
        }

    }
}
