using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class TestType
{
    public TestType(string name, bool status = true)
    {
        Name = name;
        Status = status;
    }

    private string _name;
    private bool _status;

    public string Name { get => _name; set => _name = value; }
    public bool Status { get => _status; set => _status = value; }
}