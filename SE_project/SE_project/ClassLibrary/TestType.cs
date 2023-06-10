using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class TestType
{
    public TestType(string name, int status = 1)
    {
        Name = name;
        Status = status;
    }

    private string _name;
    private int _status;

    public string Name { get => _name; set => _name = value; }
    public int Status { get => _status; set => _status = value; }
}