using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static OrderService orderService = new OrderService();
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎使用订单管理系统！");
            bool quit = false;
            bool success = false;
            int id = 1;
            int customerID;
            Order order;
            while (!quit)
            {
                try
                {
                    Console.WriteLine("请选择服务：\n1.添加订单\t2.更改订单\t3.删除订单\t4.查询订单\t5.显示所有订单\t\t0.退出");
                    int service = Convert.ToInt32(Console.ReadLine());
                    switch (service)
                    {
                        case 1:
                            Console.WriteLine("请输入客户名：");
                            string customerName = Console.ReadLine();
                            Console.WriteLine("请输入地址：");
                            string address = Console.ReadLine();
                            foreach (Order o in orderService.orders)
                            {
                                if (o.CustomerName != customerName)
                                    continue;
                                else
                                {
                                    break;
                                }
                            }
                            customerID = Math.Abs(customerName.GetHashCode());
                            order = new Order(id, address, customerName, customerID);
                            id++;
                            bool back = false;
                            while (!back)
                            {
                                Console.WriteLine("请输入货物名称,或输入back返回:");
                                string name = Console.ReadLine();
                                if (name == "back")
                                {
                                    back = true;
                                    break;
                                }
                                Console.WriteLine("请输入货物单价:");
                                double price = Convert.ToDouble(Console.ReadLine());
                                OrderItem item = new OrderItem(name, price);
                                order.AddItem(item);
                            }
                            success = orderService.AddOrder(order);
                            if (success)
                            {
                                Console.WriteLine("添加成功!");
                                break;
                            }
                            Console.WriteLine("添加失败!");
                            break;
                        case 2:
                            Console.WriteLine("请输入订单编号:");
                            int currentID = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("请输入新客户名：");
                            string newCustomerName = Console.ReadLine();
                            Console.WriteLine("请输入新地址:");
                            string newAddress = Console.ReadLine();
                            foreach (Order o in orderService.orders)
                            {
                                if (o.ID == currentID)
                                {
                                    order = new Order(currentID, newAddress, newCustomerName, o.CustomerID);
                                    success = orderService.UpdateOrder(order);
                                    break;
                                }
                            }
                            if (success)
                            {
                                Console.WriteLine("修改成功!");
                                break;
                            }
                            Console.WriteLine("修改失败!");
                            break;
                        case 3:
                            Console.WriteLine("请输入订单编号:");
                            currentID = Convert.ToInt32(Console.ReadLine());
                            foreach (Order o in orderService.orders)
                            {
                                if (o.ID == currentID)
                                {
                                    order = new Order(currentID, o.Address, o.CustomerName, o.CustomerID);
                                    success = orderService.DeleteOrder(order);
                                }
                            }
                            if (success)
                            {
                                Console.WriteLine("删除成功!");
                                break;
                            }
                            Console.WriteLine("删除失败!");
                            break;
                        case 4:
                            Console.WriteLine("按什么查询:\n1.订单号\t2.客户ID\t3.客户名\t4.物品名\t\t0.返回");
                            int method = Convert.ToInt32(Console.ReadLine());
                            if (method == 0)
                                break;
                            Console.WriteLine("输入要查询的内容");
                            string query = Console.ReadLine();
                            List<Order> list = new List<Order>();
                            list = orderService.QueryBy(method, query);
                            foreach (Order o in list)
                            {
                                Console.WriteLine(o);
                            }
                            break;
                        case 5:
                            Console.WriteLine("按什么排序:\n1.客户名\t2.客户ID\t3.时间  \t4.订单号");
                            method = Convert.ToInt32(Console.ReadLine());
                            list = orderService.SortBy(method);
                            foreach (Order o in list)
                            {
                                Console.WriteLine(o);
                            }
                            break;
                        case 0:
                            quit = true;
                            break;
                    }
                }
                catch(ArgumentException ae)
                {
                    Console.WriteLine("输入有误!");
                }
            }
        }
    }
}
