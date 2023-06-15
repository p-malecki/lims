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
        internal static (int, int) GetClientStats(int id)
        {
            int toAccept = _toAcceptOrderList.Count(o => o.ClientID == id);
            int completed = _completedOrderList.Count(o => o.ClientID == id);

            return (toAccept, completed);
        }
        
        internal static (int, int) GetTechnicianStats(int id)
        {
            int completed = _completedOrderList.Count(o => o.TechnicianID == id);
            int denied = _deniedOrderList.Count(o => o.TechnicianID == id);

            return (completed, denied);
        }

        public static void changeFromAcceptedToFill(int orderId)
        {
            foreach (Order order in _toAcceptOrderList)
            {
                if (order.ID == orderId)
                {
                    order.Status = 1;
                    _toFillOrderList.Add(order);
                    _toAcceptOrderList.Remove(order);
                    return;
                }
            }
        }
        public static void changeFromAcceptedToDenied(int orderId, int technicianID)
        {
            foreach (Order order in _toAcceptOrderList)
            {
                if (order.ID == orderId)
                {
                    order.TechnicianID = technicianID;
                    order.Status = -1;
                    _deniedOrderList.Add(order);
                    _toAcceptOrderList.Remove(order);
                    return;
                }
            }
        }

        public static void changeFromToFillToAccepted(int orderId)
        {
            foreach (Order order in _toFillOrderList)
            {
                if (order.ID == orderId)
                {
                    order.Status = 2;
                    _completedOrderList.Add(order);
                    _toFillOrderList.Remove(order);
                    return;
                }
            }
        }

        public static void changeOrderTechnician(int orderId, int technicianId)
        {
            foreach (Order order in _toAcceptOrderList)
            {
                if (order.ID == orderId)
                {
                    order.TechnicianID = technicianId;
                    return;
                }
            }
        }


    }
}
