using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.EntityFramework;

namespace ConsoleApp1
{
    public class Order
    {
        private int orderID;
        private int customerID;
        [Key,Column(Order = 1)]
        public int OrderID { get => orderID; set => orderID = Math.Abs((CustomerName+Address).GetHashCode()); }
        [Required]
        public int CustomerID { get => customerID; set => customerID = Math.Abs(CustomerName.GetHashCode()); }
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
            return $"{OrderID} {CustomerID} {CustomerName} {Address}" + result;
        }
    }
}
