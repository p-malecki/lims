using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace SE_project
{
    internal static class TestManagement
    {
        private static List<Test> _testList = new List<Test>();
        private static FlowLayoutPanel _addTestFlp;
        private static FlowLayoutPanel _rmTestFlp;

        public static List<Test> testList { get => _testList; }

        public static void InitTestManagement(List<FlowLayoutPanel> flp)
        {
            _addTestFlp = flp[0];
            _rmTestFlp = flp[1];
        }

        public static void CreateTest(
       int id, string name, string type, string description,
       decimal minVal, decimal maxVal, string unit, decimal price
       )
        {
            var elem = _testList.Find(t => t.ID == id);
            if (elem == null)
            {
                Test newTest = new Test(id, name, type, description, minVal, maxVal, unit, price);
                _testList.Add(newTest);
            }
        }


        public static void RemoveTest(int id)
        {
            var elem = _testList.Find(t => t.ID == id);
            if (elem != null)
            {
                elem.Status = 0;
            }
        }

        public static void LoadTestLists()
        {
            _addTestFlp.Controls.Clear();
            foreach (Test t in _testList)
            {
                if (t.Status == 1)
                    _addTestFlp.Controls.Add(new testItemExtended(t));
            }

            _rmTestFlp.Controls.Clear();
            foreach (Test t in _testList)
            {
                if (t.Status == 1)
                    _rmTestFlp.Controls.Add(new testItemExtendedDelete(t));
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
