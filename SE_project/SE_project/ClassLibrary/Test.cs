using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Test {

    public Test() { }
    private int _ID;
    private string _name;
    private string _type;
    private string _description;
    private decimal _min;
    private decimal _max;
    private int _unit;
    private decimal _price;
    private bool _status;

    private static List<Tuple<string, string>> _units;

    public Test(int id, string name, string type, string description, decimal min, decimal max, int unit, decimal price, bool status=true)
    {
        ID = id;
        Name = name;
        Type = type;
        Description = description;
        Min = min;
        Max = max;
        Unit = unit;
        Price = price;
        Status = status;
    }

    public static void ClassInit()
    {
        _units = new List<Tuple<string, string>> ();
        _units.Add(Tuple.Create("Femtoliter", "fL"));
        _units.Add(Tuple.Create("Femtoliter ", "fL"));
        _units.Add(Tuple.Create("Grams", "g"));
        _units.Add(Tuple.Create("Grams per deciliter", "g/dL"));
        _units.Add(Tuple.Create("Grams per liter", "g/L"));
        _units.Add(Tuple.Create("International units per liter", "IU/L"));
        _units.Add(Tuple.Create("International units per milliliter", "IU/mL"));
        _units.Add(Tuple.Create("Micrograms", "mcg"));
        _units.Add(Tuple.Create("Micrograms per deciliter", "mcg/dL"));
        _units.Add(Tuple.Create("Micrograms per liter", "mcg/L"));
        _units.Add(Tuple.Create("Microkatals per liter", "mckat/L"));
        _units.Add(Tuple.Create("Microliters", "mcL"));
        _units.Add(Tuple.Create("Micromoles per liter", "mcmol/L"));
        _units.Add(Tuple.Create("Milliequivalents", "mEq"));
        _units.Add(Tuple.Create("Milliequivalents per liter", "mEq/L"));
        _units.Add(Tuple.Create("Milligrams", "mg"));
        _units.Add(Tuple.Create("Milligrams per deciliter", "mg/dL"));
        _units.Add(Tuple.Create("Milligrams per liter", "mg/L"));
        _units.Add(Tuple.Create("Milliliters", "mL"));
        _units.Add(Tuple.Create("Millimeters", "mm"));
        _units.Add(Tuple.Create("Millimeters of mercury", "mm Hg"));
        _units.Add(Tuple.Create("Millimoles", "mmol"));
        _units.Add(Tuple.Create("Millimoles per liter", "mmol/L"));
        _units.Add(Tuple.Create("Milliunits per gram", "mU/g"));
        _units.Add(Tuple.Create("Milliunits per liter", "mU/L"));
        _units.Add(Tuple.Create("Nanograms per deciliter", "ng/dL"));
        _units.Add(Tuple.Create("Nanograms per liter", "ng/L"));
        _units.Add(Tuple.Create("Nanograms per milliliter", "ng/mL"));
        _units.Add(Tuple.Create("Nanomoles", "nmol"));
        _units.Add(Tuple.Create("Nanomoles per liter", "nmol/L"));
        _units.Add(Tuple.Create("Picograms", "pg"));
        _units.Add(Tuple.Create("Picograms per milliliter", "pg/mL"));
        _units.Add(Tuple.Create("Picomoles per liter", "pmol/L"));
        _units.Add(Tuple.Create("Units per liter", "U/L"));
        _units.Add(Tuple.Create("Units per milliliter", "U/mL"));
    }

    public int ID { get => _ID; set => _ID = value; }
    public string Name { get => _name; set => _name = value; }
    public string Type { get => _type; set => _type = value; }
    public string Description { get => _description; set => _description = value; }
    public decimal Min { get => _min; set => _min = value; }
    public decimal Max { get => _max; set => _max = value; }
    public int Unit { get => _unit; set => _unit = value; }
    public decimal Price { get => _price; set => _price = value; }
    public bool Status { get => _status; set => _status = value; }
   
    public static List<string> UnitsList
    {
        get
        {
            var enumList = new List<string>();
            foreach(var e in _units)
                enumList.Add(e.Item1);

            return enumList;
        }
    }

    public static int GetUnitID(string unitName)
    {
        for (int i = 0; i < _units.Count; i++)
            if (_units[i].Item1 == unitName)
                return i;
        return 0;
    }

    public string GetUnitStringFull()
    {
        return _units[Unit].Item1;
    }
    public string GetUnitStringAbbrev()
    {
        return _units[Unit].Item2;
    }
    


}
