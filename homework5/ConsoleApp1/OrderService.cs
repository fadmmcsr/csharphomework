using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OrderService
    {
        public List<Order> orders = new List<Order>();
        public bool DeleteOrder(Order order)
        {
            try
            {
                if (!orders.Contains(order))
                    return false;
                orders.Remove(order);
                return true;
            }
            catch(NullReferenceException nre)
            {
                Console.WriteLine("没有此订单!");
                return false;
            }
        }
        public bool AddOrder(Order order)
        {
            if (orders.Contains(order))
                return false;
            orders.Add(order);
            return true;
        }
        public bool UpdateOrder(Order order)
        {
            try
            {
                foreach (Order o in orders)
                {
                    if (o.ID == order.ID)
                    {
                        int index = orders.IndexOf(o);
                        orders[index] = order;
                        return true;
                    }
                }
                return false;
            }
            catch (NullReferenceException nre)
            {
                Console.WriteLine("没有此订单!");
                return false;
            } 
        }
        public List<Order> QueryByID(int ID)
        {
            var query = orders.Where(order => order.ID == ID).OrderBy(order => order.items.Sum(i => i.Price));
            return query.ToList();
        }
        public List<Order> QueryByCustomerID(int customerID)
        {
            var query = orders.Where(order => order.CustomerID == customerID).OrderBy(order => order.items.Sum(i => i.Price));
            return query.ToList();
        }
        public List<Order> QueryByCustomerName(string customerName)
        {
            var query = orders.Where(order => order.CustomerName == customerName).OrderBy(order => order.items.Sum(i => i.Price));
            return query.ToList();
        }
        public List<Order> QueryByItemName(string itemName)
        {
            var query = orders.Where(order =>
            {
                foreach (Order o in orders)
                {
                    foreach (OrderItem i in o.items)
                    {
                        if (i.Name == itemName)
                            return true;
                    }
                }
                return false;
            }).OrderBy(order => order.items.Sum(i => i.Price));
            return query.ToList();
        }
        public List<Order> QueryBy(int method,string query)
        {
            if (method > 4 || method < 1)
                return null;
            switch (method)
            {
                case 1:
                    int ID = Convert.ToInt32(query);
                    return QueryByCustomerID(ID);
                case 2:
                    int customerID = Convert.ToInt32(query);
                    return QueryByCustomerID(customerID);
                case 3:
                    return QueryByCustomerName(query);
                default:
                    return QueryByItemName(query);
            }
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
                    list.Sort((o1, o2) => string.Compare(o1.CustomerName, o2.CustomerName));
                    return list;
                case 2:
                    list.Sort((o1, o2) => o1.CustomerID - o2.CustomerID);
                    return list;
                case 3:
                    list.Sort((o1, o2) => DateTime.Compare(o1.DateTime, o2.DateTime));
                    return list;
                default:
                    list.Sort((o1, o2) => o1.ID - o2.ID);
                    return list;
            }
        }
    }
}
