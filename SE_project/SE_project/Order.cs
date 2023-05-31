
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Order {

    public Order() {
    }

    public Order(int id, int status, DateTime date, int clientId, int technicianId, ClientTest[] tests)
    {
        ID = id;
        Status = status;
        Date = date;
        ClientID = clientId;
        TechnicianID = technicianId;
        Tests = tests;
    }

    private int _ID;
    private int _status;
    private DateTime _date;
    private int _clientID;
    private int _technicianID;
    private ClientTest [] _tests;

    public int ID { get => _ID; set => _ID = value; }
    public int Status { get => _status; set => _status = value; }
    public DateTime Date { get => _date; set => _date = value; }
    public int ClientID { get => _clientID; set => _clientID = value; }
    public int TechnicianID { get => _technicianID; set => _technicianID = value; }
    public ClientTest[] Tests { get => _tests; set => _tests = value; }
}