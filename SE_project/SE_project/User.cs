
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class User {

    public User(uint iD, int type, string login, string password, string name, string surname, DateTime birthdate, string pesel="0", string residence="0")
    {
        ID1 = iD;
        this.Type = type;
        this.Login = login;
        this.Password = password;
        this.Name = name;
        this.Surname = surname;
        this.Birthdate = birthdate;
        this.Pesel = pesel;
        this.Residence = residence;
    }

    private uint ID;

    private int type;

    private string login;

    private string password;

    private string name;

    private string surname;

    private DateTime birthdate;

    private string pesel;

    private string residence;


    public uint ID1 { get => ID; set => ID = value; }
    public int Type { get => type; set => type = value; }
    public string Login { get => login; set => login = value; }
    public string Password { get => password; set => password = value; }
    public string Name { get => name; set => name = value; }
    public string Surname { get => surname; set => surname = value; }
    public DateTime Birthdate { get => birthdate; set => birthdate = value; }
    public string Pesel { get => pesel; set => pesel = value; }
    public string Residence { get => residence; set => residence = value; }
}