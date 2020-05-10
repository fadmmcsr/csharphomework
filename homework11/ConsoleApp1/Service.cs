using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data.Entity;

namespace ConsoleApp1
{
    class Service
    {
        public void AddOrder()
        {
            using (var context = new Context())
            {
                var order = new Order();
                Console.WriteLine("输入用户名：\n");
                order.CustomerName = Console.ReadLine();
                Console.WriteLine("输入地址：\n");
                order.Address = Console.ReadLine();
                order.Items = new List<Item>();
                bool stop = false;
                var item = new Item();
                while(!stop)
                {
                    Console.WriteLine("输入商品名：\n");
                    item.ItemName = Console.ReadLine();
                    Console.WriteLine("输入单价：\n");
                    item.Price = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("输入数量：\n");
                    item.Quantity = Convert.ToInt32(Console.ReadLine());
                    item.OrderID = order.OrderID;
                    context.Entry(item).State = EntityState.Added;
                    context.SaveChanges();
                    Console.WriteLine("输入stop退出，任意字符继续\n");
                    if (Console.ReadLine().ToLower() == "stop")
                        stop = true;
                }
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }
        public void UpdateOrder()
        {
            using (var context = new Context())
            {
                Console.WriteLine("输入订单号：\n");
                var order = new Order() { OrderID = Convert.ToInt32(Console.ReadLine()) };  
                bool stop = false;
                int method;
                var item = new Item();
                while (!stop)
                {
                    Console.WriteLine("输入数字继续：1、修改地址,2、添加商品，3、修改商品信息，4、删除商品，0、返回\n");
                    method = Convert.ToInt32(Console.ReadLine());
                    switch (method)
                    {
                        case 1:
                            Console.WriteLine("输入地址：\n");
                            order.Address = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("输入商品名：\n");
                            item.ItemName = Console.ReadLine();
                            Console.WriteLine("输入单价：\n");
                            item.Price = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("输入数量：\n");
                            item.Quantity = Convert.ToInt32(Console.ReadLine());
                            item.OrderID = order.OrderID;
                            context.Entry(item).State = EntityState.Added;
                            context.SaveChanges();
                            break;
                        case 3:
                            Console.WriteLine("输入商品ID：\n");
                            item.ItemID = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("输入单价：\n");
                            item.Price = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("输入数量：\n");
                            item.Quantity = Convert.ToInt32(Console.ReadLine());
                            item.OrderID = order.OrderID;
                            context.Entry(item).State = EntityState.Modified;
                            context.SaveChanges();

                            break;
                        case 4:
                            Console.WriteLine("输入商品ID：\n");
                            item = context.Items.FirstOrDefault(i => i.ItemID == Convert.ToInt32(Console.ReadLine()));
                            if (item != null)
                            {
                                context.Items.Remove(item);
                                context.SaveChanges();
                            }
                            break;

                        case 0:
                            stop = true;
                            break;
                    }
                }
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }
        public void DeleteOrder()
        {
            using (var context = new Context())
            {
                Console.WriteLine("输入订单号：\n");
                var order = new Order() { OrderID = Convert.ToInt32(Console.ReadLine()) };
                if (order != null)
                {
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
            }
        }
        public void QueryOrder()
        {
            using (var context = new Context())
            {
                bool stop = false;
                int method;
                while (!stop)
                {
                    Console.WriteLine("输入数字继续：1、按订单号查询,2、按用户账号查询，3、按用户名查询，4、按地址查询，5、按商品号查询，6、按商品名查询0、返回\n");
                    method = Convert.ToInt32(Console.ReadLine());
                    switch(method)
                    {
                        case 1:
                            Console.WriteLine("输入订单号：\n");
                            var query = context.Orders.Where(o => o.OrderID == Convert.ToInt32(Console.ReadLine())).OrderBy(o => o.OrderID);
                            foreach(var o in query)
                            {
                                Console.WriteLine(o);
                            }
                            break;
                        case 2:
                            Console.WriteLine("输入用户账号：\n");
                            query = context.Orders.Where(o => o.CustomerID == Convert.ToInt32(Console.ReadLine())).OrderBy(o => o.OrderID);
                            foreach (var o in query)
                            {
                                Console.WriteLine(o);
                            }
                            break;
                        case 3:
                            Console.WriteLine("输入用户名：\n");
                            query = context.Orders.Where(o => o.CustomerName == Console.ReadLine()).OrderBy(o => o.OrderID);
                            foreach (var o in query)
                            {
                                Console.WriteLine(o);
                            }
                            break;
                        case 4:
                            Console.WriteLine("输入地址：\n");
                            query = context.Orders.Where(o => o.Address == Console.ReadLine()).OrderBy(o => o.OrderID);
                            foreach (var o in query)
                            {
                                Console.WriteLine(o);
                            }
                            break;
                        case 5:
                            Console.WriteLine("输入商品号：\n");
                            query = context.Orders.Where(o => o.Items.Where(i => i.ItemID == Convert.ToInt32(Console.ReadLine())) != null).OrderBy(o => o.OrderID);
                            foreach (var o in query)
                            {
                                Console.WriteLine(o);
                            }
                            break;
                        case 6:
                            Console.WriteLine("输入商品名：\n");
                            query = context.Orders.Where(o => o.Items.Where(i => i.ItemName ==Console.ReadLine()) != null).OrderBy(o => o.OrderID);
                            foreach (var o in query)
                            {
                                Console.WriteLine(o);
                            }
                            break;
                        case 0:
                            stop = true;
                            break;
                    }
                }
            }
        }
    }
}
