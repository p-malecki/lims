using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_project.controllers
{
    internal static class TestTypeManagement
    {
        private static List<TestType> _testTypesList = new List<TestType>();
        public static List<TestType> List { get => _testTypesList; }

        public static void Initialize()
        {
            _testTypesList = DatabaseManagement.LoadTestTypes();
        }

        public static void CreateType(string name)
        {
            if (name.Equals(""))
            {
                MessageBox.Show("Wartość maksymalna musi być nie mniejsza od minimalnej", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var elem = _testTypesList.Find(t => t.Name == name);
            if (elem == null)
            {
                var newType = new TestType(_testTypesList.Count()+1, name);
                _testTypesList.Add(newType);
                DatabaseManagement.InsertNewTestType(newType);
            }
            else if (!elem.Status)
            {
                elem.Status = true;
                DatabaseManagement.ChangeTestTypeStatus(elem.Name, 1);
            }

        }

        public static void RemoveType(string name)
        {
            var elem = _testTypesList.Find(t => t.Name == name);
            if (elem != null)
            {
                elem.Status = false;
                DatabaseManagement.ChangeTestTypeStatus(elem.Name, 0);
            }
        }

        public static List<string> GetNameList()
        {
            List<string> strings = new List<string>();
            foreach (TestType t in _testTypesList)
            {
                if (t.Status)
                    strings.Add(t.Name);
            }
            return strings;
        }

        public static int GetTypeID(string name)
        {
            var elem = _testTypesList.Find(t => t.Name == name);
            return (elem != null) ? elem.ID:0;
        }

        public static string GetTypeName(int id)
        {
            var elem = _testTypesList.Find(t => t.ID == id);
            return (elem != null) ? elem.Name : "";
        }
    }
}