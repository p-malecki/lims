using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class TestType
{
    public TestType(int id, string name, bool status = true)
    {
        ID = id;
        Name = name;
        Status = status;
    }

    private int _id;
    private string _name;
    private bool _status;

    public int ID { get => _id; set => _id = value; }
    public string Name { get => _name; set => _name = value; }
    public bool Status { get => _status; set => _status = value; }
}