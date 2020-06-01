using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public override string ToString()
        {
            return $"商品ID：{ItemID}，商品名：{ItemName}，单价：{Price}，数量：{Quantity}，总价：{Price * Quantity}\n";
        }
    }
}
