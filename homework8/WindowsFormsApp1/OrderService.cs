using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public class OrderService
    {
        int id;
        public List<Order> orders;
        public OrderService()
        {
            orders = new List<Order>();
            id = 0;
        }
        public bool AddOrder(string name, string address)
        {
            Order order = new Order(name, address, id);
            if (!orders.Contains(order))
            {
                orders.Add(order);
                id++;
                return true;
            }
            return false;
        }
        public bool UpdateOrder(string name, string address)
        { 
            Order order = new Order(name, address, id);
            if (!orders.Contains(order))
                return false;
            orders.ForEach(o =>
            {
                if (o.ID == id)
                {
                    o.Address = address;
                    o.CustomerName = name;
                }
            });
            return true;
        }
        public void RemoveOrder(string remove, int method)
        {
            switch (method)
            {
                case 1:
                    int id = Convert.ToInt32(remove);
                    orders.ForEach(o =>
                    {
                        if (o.ID == id)
                            orders.Remove(o);
                    });
                    break;
                case 2:
                    int cid = Convert.ToInt32(remove);
                    orders.ForEach(o =>
                    {
                        if (o.CustomerID == cid)
                            orders.Remove(o);
                    });
                    break;
                case 3:
                    string name = remove;
                    orders.ForEach(o =>
                    {
                        if (o.CustomerName == name)
                            orders.Remove(o);
                    });
                    break;
                case 4:
                    string itemName = remove;
                    orders.ForEach(o =>
                    {
                        if (o.items.Exists(i => i.Name == itemName))
                            orders.Remove(o);
                    });
                    break;
            }
            orders.ForEach(o =>
            {
                if (o.ID == id)
                    orders.Remove(o);
            });
        }
        public void Query(string query, int method) 
        {
            switch(method)
            {
                case 1:
                    int id=Convert.ToInt32(query);
                    orders.Where(o => o.ID == id).OrderBy(o => o.items.Sum(i => i.TotalPrice()));
                    break;
                case 2:
                    int cid = Convert.ToInt32(query);
                    orders.Where(o => o.CustomerID == cid).OrderBy(o => o.items.Sum(i => i.TotalPrice()));
                    break;
                case 3:
                    string name = query;
                    orders.Where(o => o.CustomerName == name).OrderBy(o => o.items.Sum(i => i.TotalPrice()));
                    break;
                case 4:
                    string itemName = query;
                    orders.Where(o => o.items.Exists(i => i.Name == itemName)).OrderBy(o => o.items.Sum(i => i.TotalPrice()));
                    break;
            }
        }
        public void Export(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, orders);
            }
        }
        public List<Order> Import(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                return (List<Order>)xmlSerializer.Deserialize(fs);
            }
        }
    }
}
