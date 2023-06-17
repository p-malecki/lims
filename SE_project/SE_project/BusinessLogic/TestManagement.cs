using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace SE_project.controllers
{
    internal static class TestManagement
    {
        private static List<Test> _testList = new List<Test>();
        private static FlowLayoutPanel _addTestFlp;
        private static FlowLayoutPanel _rmTestFlp;


        public static List<Test> testList { get => _testList; }


        public static void Initialize(List<FlowLayoutPanel> flp)
        {
            Test.ClassInit();
            _testList = DatabaseManagement.LoadTests();
            _addTestFlp = flp[0];
            _rmTestFlp = flp[1];
                 
        }

        public static void Initialize()
        {
            Test.ClassInit();
            _testList = DatabaseManagement.LoadTests();
        }


        public static bool CreateTest(string name, string type, string description,
                decimal minVal, decimal maxVal, int unit, decimal price)
        {
            if (name == null) 
                return false;
            if (minVal > maxVal)
                return false;
            int typeID = TestTypeManagement.GetTypeID(type);

            var elem = _testList.Find(t => t.Name == name);
            if (elem == null)
            {
                int id = _testList.Count() + 1;
                Test newTest = new Test(id, name, typeID, description, minVal, maxVal, unit, price);
                _testList.Add(newTest);

                if (!DatabaseManagement.InsertNewTest(newTest))
                    MessageBox.Show("Błąd w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                elem.Type = typeID;
                elem.Description = description;
                elem.Min = minVal;
                elem.Max = maxVal;
                elem.Unit = unit;
                elem.Price = price;
                DatabaseManagement.ChangeTestStatus(elem.ID, 1);
                DatabaseManagement.ChangeTestParams(elem.ID, type, description, minVal, maxVal, unit, price);
            }
            return true;
        }

        public static bool RemoveTest(int id)
        {
            if (OrderManagement.isTestInUncompletedOrder(id) == true) return false;

            var elem = _testList.Find(t => t.ID == id);
            if (elem != null)
            {
                elem.Status = false;
                DatabaseManagement.ChangeTestStatus(elem.ID, 0);
            }

            return true;
        }
        
        public static void LoadTestLists()
        {
            _addTestFlp.Controls.Clear();
            foreach (Test t in _testList)
            {
                if (t.Status)
                    _addTestFlp.Controls.Add(new testItemExtended(t));
            }

            _rmTestFlp.Controls.Clear();
            foreach (Test t in _testList)
            {
                if (t.Status)
                    _rmTestFlp.Controls.Add(new testItemExtendedDelete(t));
            }

        }

        internal static int CountTestWithType(string typeName)
        {
            return _testList.Count(t => (t.GetTestTypeString() == typeName) && (t.Status == true));
        }

        public static string getClientTestName(ClientTest test)
        {
            foreach (Test t in _testList)
                if (test.TestID == t.ID)
                    return t.Name;

            return "";
        }

        public static string getClientTestUnitStringAbbrev(ClientTest test)
        {
            foreach (Test t in _testList)
                if (test.TestID == t.ID)
                    return t.GetUnitStringAbbrev();

            return "";
        }

        public static decimal getClientTestMin(ClientTest test)
        {
            foreach (Test t in _testList)
                if (test.TestID == t.ID)
                    return t.Min;

            return 0;
        }

        public static decimal getClientTestMax(ClientTest test)
        {
            foreach (Test t in _testList)
                if (test.TestID == t.ID)
                    return t.Max;

            return 0;
        }
    }
}
