using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_project
{
    internal static class TestTypeManagement
    {
        private static List<string> _list = new List<string>();

        public static List<string> List { get => _list; }
        
        public static void CreateType(string name)
        {
            if (name.Equals("")) { System.Console.Error.WriteLine("type name cannot be empty"); return; }


            if (_list.Contains(name) == false)
            {
                _list.Add(name);
            }
            else { System.Console.Error.WriteLine("type already exits"); return; }

        }

        public static void RemoveType(string name)
        {
            throw new NotImplementedException();
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
