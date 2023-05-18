
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Test {


    public Test(uint iD, string name, int type, double min, double max, int unit)
    {
        ID1 = iD;
        this.Name = name;
        this.Type = type;
        this.Min = min;
        this.Max = max;
        this.Unit = unit;
    }

    private uint ID;

    private string name;

    private int type;

    private double min;

    private double max;

    private int unit;

    public uint ID1 { get => ID; set => ID = value; }
    public string Name { get => name; set => name = value; }
    public int Type { get => type; set => type = value; }
    public double Min { get => min; set => min = value; }
    public double Max { get => max; set => max = value; }
    public int Unit { get => unit; set => unit = value; }
}