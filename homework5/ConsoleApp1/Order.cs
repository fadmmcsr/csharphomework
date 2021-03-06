﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Order
    {
        public int ID { get; set; }
        public string Address { get; set; }
        public string Time { get; set; }
        public string CustomerName { get; set; }
        public int CustomerID { get; set; }
        public List<OrderItem> items = new List<OrderItem>();
        public Order() { }
        public Order(int id, string address, string customerName, int customerID)
        {
            try
            {
                ID = id;
                Address = address;
                CustomerName = customerName;
                CustomerID = customerID;
                Time = DateTime.Now.ToString();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("输入有误!");
            }
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
            if (order.items.Count != 0)
                foreach (OrderItem item in items)
                {
                    foreach (OrderItem i in order.items)
                        if (!i.Equals(item) || order.ID != this.ID)
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
            string result;
            if (items != null)
            {
                result = "ID:" + ID + "\n地址:" + Address + "\n时间:" + Time +
                    "\n客户名:" + CustomerName + "\n客户ID:" + CustomerID +
                    "\n总项数:" + items.Count + "\n总价:" + items.Sum(i => i.Price) +
                    "\n各个项目:";
                foreach (OrderItem i in items)
                {
                    result += "\n\t" + i;
                }
                return result;
            }
            return null;
        }
    }
}
