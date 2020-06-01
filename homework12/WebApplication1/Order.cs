using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public List<Item> Items { get; set; }
        public override string ToString()
        {
            string result = "";
            foreach (var item in Items.OrderBy(i => i.ItemID))
            {
                result += $"{item}";
            }
            return $"订单号：{OrderID}，客户ID：{CustomerID}，客户名：{CustomerName}，地址：{Address}" + result;
        }
    }
}
