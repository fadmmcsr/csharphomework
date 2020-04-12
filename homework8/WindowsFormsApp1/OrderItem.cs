using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class OrderItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Number { get; set; }
        public OrderItem(string name, double price, int number)
        {
            Name = name;
            Price = price;
            Number = number;
        }
        public double TotalPrice()
        {
            return Price * Number;
        }
        public override bool Equals(object obj)
        {
            OrderItem item = obj as OrderItem;
            return item.Name == Name;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
