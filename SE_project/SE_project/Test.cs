
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Test {


    public Test(int id, string name, int type, double min, double max, int unit, int status)
    {
        ID = id;
        Name = name;
        Type = type;
        Min = min;
        Max = max;
        Unit = unit;
        Status = status;
    }
        
    private int _ID;
    private string _name;
    private int _type;
    private double _min;
    private double _max;
    private int _unit;
    private int _status;

    public int ID { get => _ID; set => _ID = value; }
    public string Name { get => _name; set => _name = value; }
    public int Type { get => _type; set => _type = value; }
    public double Min { get => _min; set => _min = value; }
    public double Max { get => _max; set => _max = value; }
    public int Unit { get => _unit; set => _unit = value; }
    public int Status { get => _status; set => _status = value; }
}