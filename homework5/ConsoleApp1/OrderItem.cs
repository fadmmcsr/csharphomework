using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class OrderItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public OrderItem() { }
        public OrderItem(string name, double price)
        {
            try
            {
                Name = name;
                Price = price;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("输入有误!");
            }
        }
        public override bool Equals(object obj)
        {
            OrderItem orderItem = obj as OrderItem;
            return orderItem.Name == Name && orderItem.Price == Price;
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
