
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ClientTest : Test {



    public ClientTest(uint iD, string name, int type, double min, double max, int unit) : base(iD, name, type, min, max, unit)
    {
    }

    private uint orderID;

    private double result;

    protected uint OrderID { get => orderID; set => orderID = value; }
    protected double Result { get => result; set => result = value; }
}