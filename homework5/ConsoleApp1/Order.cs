using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Order
    {
        public int ID { get; set; }
        public string Address { get; set; }
        public DateTime DateTime { get; set; }
        public string CustomerName { get; set; }
        public int CustomerID { get; set; }
        public List<OrderItem> items = new List<OrderItem>();
        public Order(int id, string address, string customerName, int customerID)
        {
            ID = id;
            Address = address;
            CustomerName = customerName;
            CustomerID = customerID;
            DateTime = DateTime.Now;
        }
        public bool DeleteItem(OrderItem orderItem)
        {
            if (!items.Contains(orderItem))
                return false;
            else
            {
                items.Remove(orderItem);
                return true;
            }
        }
        public bool AddItem(OrderItem orderItem)
        {
            if (items.Contains(orderItem))
                return false;
            else
            {
                items.Add(orderItem);
                return true;
            }
        }

        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            foreach (OrderItem i in items)
            {
                if (!i.Equals(order) || order.ID != this.ID)
                    return false;
            }
            return true;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return "ID:" + ID + "\nAddress:" + Address + "\nDateTime:" + DateTime +
                "\nOrdererName:" + CustomerName + "\nOrdererID:" + CustomerID +
                "\nTotal Items:" + items.Count + "\nTotal Price:" + items.Sum(i => i.Price);
        }
    }
}
