using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_project
{
    internal class OrderManagement
    {
        private static List<Order> _toAcceptOrderList = new List<Order>();
        private static List<Order> _toFillOrderList = new List<Order>();
        private static List<Order> _completedOrderList = new List<Order>();
        private static List<Order> _deniedOrderList = new List<Order>();

        public static List<Order> toAcceptOrderList { get => _toAcceptOrderList; }
        public static List<Order> toFillOrderList { get => _toFillOrderList; }
        public static List<Order> completedOrderList { get => _completedOrderList; }
        public static List<Order> deniedOrderList { get => _deniedOrderList; }

    }
}
