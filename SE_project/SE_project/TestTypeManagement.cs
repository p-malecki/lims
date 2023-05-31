using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_project
{
    internal static class TestTypeManagement
    {
        private static List<TestType> _list = new List<TestType>();

        public static List<TestType> List { get => _list; }
        
        public static void CreateType(string name)
        {
            if (name.Equals("")) { System.Console.Error.WriteLine("type name cannot be empty"); return; }


            if (_list.Any(t => t.Name == name) == false)
            {
                var newType = new TestType(name);
                _list.Add(newType);
            }
            else
            {
                var elem = _list.Find(t => t.Name == name);
                elem.Status = 1;
            }

        }

        public static void RemoveType(string name)
        {
            var elem = _list.Find(t => t.Name == name);
            if (elem != null)
            {
                elem.Status = 0;
            }
        }

        public static List<string> GetNameList()
        {
            List<string> strings = new List<string>();
            foreach (TestType t in _list)
            {
                if (t.Status == 1)
                    strings.Add(t.Name);
            }
            return strings;
        }

        public static void LoadTypes()
        {
            throw new NotImplementedException();
        }

        public static void SaveTypes()
        {
            throw new NotImplementedException();
        }

    }
}
