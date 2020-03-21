using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OrderItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public OrderItem(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override bool Equals(object obj)
        {
            OrderItem orderItem = obj as OrderItem;
            return orderItem.Name == this.Name && orderItem.Price == this.Price;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return "货物名:" + Name + " 单价:" + Price;
        }
    }
}
