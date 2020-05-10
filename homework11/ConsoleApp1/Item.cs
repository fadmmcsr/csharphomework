using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using MySql.Data;
using MySql.Data.EntityFramework;

namespace ConsoleApp1
{
    public class Item
    {
        private int itemID;
        [Key]
        public int ItemID { get => itemID; set => itemID = Math.Abs(ItemName.GetHashCode()); }
        [Required]
        public string ItemName { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public override string ToString()
        {
            return $"{ItemID} {ItemName} {Price} {Quantity} {Price * Quantity}\n";
        }
    }
}
