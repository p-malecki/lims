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
        public static void deleteOrderFromToAcceptOrderList(Order o)
        {
            _toAcceptOrderList.Remove(o);
        }
        public static void addOrderToFillOrderList(Order o)
        {
            _toFillOrderList.Add(o);
        }
        public static void addOrderToDeniedOrderList(Order o)
        {
            _deniedOrderList.Add(o);
        }

        public static int getFreeOrderID()
        {
            return 1;
            //throw new NotImplementedException();
        }

        public static int getFreeClientTestsID()
        {
            return 22;
            //throw new NotImplementedException();
        }

        public static bool isNotOrderedTwice(DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
