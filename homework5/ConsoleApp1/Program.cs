using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        OrderService orderService = new OrderService();
        public List<Order> QueryBy(int method)
        {
            if (method > 4 || method < 1)
                return null;
            switch (method)
            {
                case 1:
                    int ID = Convert.ToInt32(Console.ReadLine());
                    return orderService.QueryByCustomerID(ID);
                case 2:
                    int customerID = Convert.ToInt32(Console.ReadLine());
                    return orderService.QueryByCustomerID(customerID);
                case 3:
                    return orderService.QueryByCustomerName(Console.ReadLine());
                default:
                    return orderService.QueryByItemName(Console.ReadLine());
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
