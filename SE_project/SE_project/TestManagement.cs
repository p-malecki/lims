using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_project
{
    internal class TestManagement
    {
        private static List<Test> _testList = new List<Test>();

        public static List<Test> testList { get => _testList; }

        public static void CreateTest(
            int id, string name, string type, 
            decimal minVal, decimal maxVal, string unit, decimal price
            )
        {
            Test newTest = new Test(id, name, type, minVal, maxVal, unit, price);
            _testList.Add(newTest);
        }

        public static void RemoveType(string name)
        {
            throw new NotImplementedException();
        }

        public static void LoadTestList(FlowLayoutPanel panel)
        {
            panel.Controls.Clear();
            foreach (Test t in _testList)
            {
                if (t.Status == 1)
                    panel.Controls.Add(new testItemExtended(t));
            }
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
