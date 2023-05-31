using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Test {


    public Test(int id, string name, string type, decimal min, decimal max, string unit, decimal price, int status=1)
    {
        ID = id;
        Name = name;
        Type = type;
        Min = min;
        Max = max;
        Unit = unit;
        Price = price;
        Status = status;
    }
        
    private int _ID;
    private string _name;
    private string _type;
    private decimal _min;
    private decimal _max;
    private string _unit;
    private decimal _price;
    private int _status;

    public int ID { get => _ID; set => _ID = value; }
    public string Name { get => _name; set => _name = value; }
    public string Type { get => _type; set => _type = value; }
    public decimal Min { get => _min; set => _min = value; }
    public decimal Max { get => _max; set => _max = value; }
    public string Unit { get => _unit; set => _unit = value; }
    public decimal Price { get => _price; set => _price = value; }
    public int Status { get => _status; set => _status = value; }
}