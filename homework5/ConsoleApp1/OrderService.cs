using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OrderService
    {
        private List<Order> orders = new List<Order>();
        public bool DeleteOrder(Order order)
        {
            if (!orders.Contains(order))
                return false;
            else
            {
                orders.Remove(order);
                return true;
            }
        }
        public bool AddOrder(Order order)
        {
            if (orders.Contains(order))
                return false;
            else
            {
                orders.Add(order);
                return true;
            }
        }
        public bool UpdateOrder(Order order)
        {
            foreach(Order o in orders)
            {
                if(o.ID==order.ID)
                {
                    int index = orders.IndexOf(o);
                    orders[index] = order;
                    return true;
                }
            }
            return false;
        }
        public List<Order> QueryByID(int ID)
        {
            var query = orders.Where(order => order.ID == ID);
            return query.ToList();
        }
        public List<Order> QueryByCustomerID(int customerID)
        {
            var query = orders.Where(order => order.CustomerID == customerID);
            return query.ToList();
        }
        public List<Order> QueryByCustomerName(string customerName)
        {
            var query = orders.Where(order => order.CustomerName == customerName);
            return query.ToList();
        }
        public List<Order> QueryByItemName(string itemName)
        {
            var query = orders.Where(order =>
            {
                foreach(Order o in orders)
                {
                    foreach (OrderItem i in o.items)
                    {
                        if (i.Name == itemName)
                            return true;
                        else
                            return false;
                    }
                }
                return false;
            });
            return query.ToList();
        }
        public List<Order> SortBy(int method)
        {
            if (method > 4 || method < 1)
                return orders;
            List<Order> list = new List<Order>();
            orders.ForEach(order => list.Add(order));
            switch (method)
            { 
                case 1: 
                    list.Sort((o1, o2) => string.Compare(o2.CustomerName, o1.CustomerName));
                    return list;
                case 2:
                    list.Sort((o1, o2) => o2.CustomerID - o1.CustomerID);
                    return list;
                case 3:
                    list.Sort((o1, o2) => DateTime.Compare(o2.DateTime, o1.DateTime));
                    return list;
                default:
                    list.Sort((o1, o2) => o2.ID - o1.ID);
                    return list;
            }
        }
    }
}
