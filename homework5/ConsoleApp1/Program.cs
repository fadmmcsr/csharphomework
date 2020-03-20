using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static OrderService orderService = new OrderService();
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎使用订单管理系统！请选择服务：\n1.添加订单\t2.更改订单\t3.删除订单\t4.查询订单\t\t0.退出");
            bool quit = false;
            bool success;
            int id = 1;
            int customerID = 1;
            while (!quit)
            {
                int service = Convert.ToInt32(Console.ReadLine());
                switch (service)
                {
                    case 1:
                        Console.WriteLine("请输入订单内容：");
                        string address = Console.ReadLine();
                        string customerName = Console.ReadLine();
                        Order order = new Order(id, address, customerName, customerID);
                        foreach (Order o in orderService.orders)
                        {
                            if (o.CustomerName != customerName)
                                continue;
                            else
                                customerID--;
                                break;
                        }
                        id++;
                        customerID++;
                        success = orderService.AddOrder(order);
                        if (success)
                        {
                            Console.WriteLine("添加成功！");
                            break;
                        }
                        Console.WriteLine("添加失败！");
                        break;
                    case 2:
                        Console.WriteLine("请输入订单编号：");
                        int currentID = Convert.ToInt32(Console.ReadLine());
                        string newAddress = Console.ReadLine();
                        success = false;
                        foreach (Order o in orderService.orders)
                        {
                            if (o.ID == currentID)
                            {
                                order = new Order(currentID, newAddress, o.CustomerName, o.CustomerID);
                                success = orderService.UpdateOrder(order);
                                break;
                            }
                        }
                        if (success)
                        {
                            Console.WriteLine("修改成功！");
                            break;
                        }
                        Console.WriteLine("修改失败！");
                        break;
                    case 3:
                        Console.WriteLine("请输入订单编号：");
                        currentID = Convert.ToInt32(Console.ReadLine());
                        foreach (Order o in orderService.orders)
                        {
                            if (o.ID == currentID)
                            {
                                order = new Order(currentID, o.Address, o.CustomerName, o.CustomerID);
                                success = orderService.DeleteOrder(order);
                            }
                        }
                        break;
                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
