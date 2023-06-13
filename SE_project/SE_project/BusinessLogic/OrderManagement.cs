using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_project.controllers
{
    internal static class OrderManagement
    {
        private static List<Order> _toAcceptOrderList = new List<Order>();
        private static List<Order> _toFillOrderList = new List<Order>();
        private static List<Order> _completedOrderList = new List<Order>();
        private static List<Order> _deniedOrderList = new List<Order>();

        public static List<Order> toAcceptOrderList { get => _toAcceptOrderList; }
        public static List<Order> toFillOrderList { get => _toFillOrderList; }
        public static List<Order> completedOrderList { get => _completedOrderList; }
        public static List<Order> deniedOrderList { get => _deniedOrderList; }

        public static void Initialize()
        {
            _toAcceptOrderList = DatabaseManagement.getToAcceptOrderList();
            _toFillOrderList = DatabaseManagement.getToFillOrderList();
            _completedOrderList = DatabaseManagement.getCompletedOrderList();
            _deniedOrderList = DatabaseManagement.getDeniedOrderList();
        }

        public static int getFreeOrderID()
        {    
            if (_toAcceptOrderList.Count() > 0)
            {
                int id = _toAcceptOrderList[_toAcceptOrderList.Count() - 1].ID + 1;
                return id;
            }
            else
                return 1;
        }

        internal static (int, int) GetClientStats(int id)
        {
            int toAccept = _toAcceptOrderList.Count(o => o.ClientID == id);
            int completed = _completedOrderList.Count(o => o.ClientID == id);

            return (toAccept, completed);
        }
        
        internal static (int, int, int) GetTechnicianStats(int id)
        {
            int filled = _toFillOrderList.Count(o => o.TechnicianID == id);
            int completed = _completedOrderList.Count(o => o.TechnicianID == id);
            int denied = _deniedOrderList.Count(o => o.TechnicianID == id);

            return (filled, completed, denied);
        }
    }
}
