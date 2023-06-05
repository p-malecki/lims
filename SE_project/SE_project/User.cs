
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

public class User {

    public User(int id, int type, string login, string password, string name, string surname, int status=1, DateTime? birthdate=null, string pesel="0", string residence="0")
    {
        ID = id;
        Type = type;  // client=0, technician=1, admin=2
        Status = status;
        Login = login;
        Password = password;
        Name = name;
        Surname = surname;
        Birthdate = birthdate;
        Pesel = pesel;
        Residence = residence;

    }

    private int _ID;
    private int _type;
    private int _status;
    private string _login;
    private string _password;
    private string _name;
    private string _surname;
    private DateTime? _birthdate;
    private string _pesel;
    private string _residence;



    public int ID { get => _ID; set => _ID = value; }
    public int Type { get => _type; set => _type = value; }
    public int Status { get => _status; set => _status = value; }
    public string Login { get => _login; set => _login = value; }
    public string Password { get => _password; set => _password = value; }
    public string Name { get => _name; set => _name = value; }
    public string Surname { get => _surname; set => _surname = value; }
    public DateTime? Birthdate { get => _birthdate; set => _birthdate = value; }
    public string Pesel { get => _pesel; set => _pesel = value; }
    public string Residence { get => _residence; set => _residence = value; }

    public string GetBirthdateAsString()
    {
        if (_birthdate.HasValue)
        {
            DateTime dateTime = _birthdate.Value;
            return dateTime.ToString("yyyy-MM-dd");
        }

        return string.Empty;
    }

}