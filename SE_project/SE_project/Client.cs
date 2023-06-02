
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Client : User {

    public Client(int id, int type, int status, string login, string password, string name, string surname, DateTime birthdate, string pesel = "0", string residence = "0") : base(id, type, status, login, password, name, surname, birthdate, pesel, residence)
    {
    }

    public string email;

    private Order[] orders;

    protected string Email { get => email; set => email = value; }
    protected Order[] Orders { get => orders; set => orders = value; }
}