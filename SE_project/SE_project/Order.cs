
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Order {

    public Order() {
    }

    public Order(uint iD, int status, DateTime date, uint clientID, uint technicianID, ClientTest[] tests)
    {
        ID1 = iD;
        this.Status = status;
        this.Date = date;
        ClientID1 = clientID;
        TechnicianID1 = technicianID;
        this.Tests = tests;
    }

    private uint ID;

    private int status;

    private DateTime date;

    private uint ClientID;

    private uint TechnicianID;

    private ClientTest [] tests;

    public uint ID1 { get => ID; set => ID = value; }
    public int Status { get => status; set => status = value; }
    public DateTime Date { get => date; set => date = value; }
    public uint ClientID1 { get => ClientID; set => ClientID = value; }
    public uint TechnicianID1 { get => TechnicianID; set => TechnicianID = value; }
    public ClientTest[] Tests { get => tests; set => tests = value; }
}