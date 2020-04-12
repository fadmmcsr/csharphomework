using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    
    public class Order
    {
        public string CustomerName { get; set; }
        public int CustomerID { get; set; }
        public string Address { get; set; }
        public int ID { get; set; }
        public List<OrderItem> items;
        public Order(string name,string address,int id)
        {
            CustomerName = name;
            CustomerID = Math.Abs(name.GetHashCode());
            Address = address;
            ID = id;
            items = new List<OrderItem>();
        }
        public bool AddItem(string name, double price, int number)
        {
            OrderItem item = new OrderItem(name, price, number);
            if (!items.Contains(item))
            {
                items.Add(item);
                return true;
            }
            return false;
        }
        public bool UpdateItem(string name, double price, int number)
        {
            OrderItem item = new OrderItem(name, price, number);
            if (!items.Contains(item))
                return false;
            items.ForEach(i =>
            {
                if (i.Name == name)
                {
                    i.Price = price;
                    i.Number = number;
                }
            });
            return true;
        }
        public void RemoveItem(string name)
        {
            items.ForEach(i =>
            {
                if (i.Name == name)
                    items.Remove(i);
            });
        }
        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            if (order.items.Count == items.Count &&
                order.items.Count(t => items.Contains(t)) != 0)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
