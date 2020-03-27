using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void DeleteOrderTest()
        {
            string name = "hwt";
            int customerID = Math.Abs(name.GetHashCode());
            OrderService orderService = new OrderService();
            Order order = new Order(1, "yc", name, customerID);
            orderService.AddOrder(order);
            Console.WriteLine(orderService.orders);
            orderService.DeleteOrder(order);
            Assert.AreEqual(orderService.orders.Count,0);
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            string name = "hwt";
            int customerID = Math.Abs(name.GetHashCode());
            OrderService orderService = new OrderService();
            Order order = new Order(1, "yc", name, customerID);
            orderService.AddOrder(order);
            Assert.AreNotEqual(0, orderService.orders.Count);
            Assert.AreEqual(order, orderService.orders.First());
        }

        [TestMethod()]
        public void UpdateOrderTest()
        {
            OrderService orderService = new OrderService();
            OrderService orderService1 = new OrderService();
            Order order = new Order(1, "yc", "hwt", "hwt".GetHashCode());
            Order order1 = new Order(2, "yc", "hwt", "hwt".GetHashCode());
            orderService.AddOrder(order);
            orderService1.AddOrder(order);
            orderService.UpdateOrder(order1);
            Assert.AreNotEqual(orderService1.orders, orderService.orders);
        }

        [TestMethod()]
        public void QueryByTest()
        {
            string name = "hwt";
            int customerID = Math.Abs(name.GetHashCode());
            OrderService orderService = new OrderService();
            Order order = new Order(1, "yc", name, customerID);
            OrderItem item = new OrderItem("cat", 1);
            order.AddItem(item);
            orderService.AddOrder(order);
            List<Order> list = orderService.QueryBy(1, "1");
            Assert.AreEqual(order, list.First());
            list = orderService.QueryBy(2, customerID.ToString());
            Assert.AreEqual(order, list.First());
            list = orderService.QueryBy(3, "hwt");
            Assert.AreEqual(order, list.First());
            list = orderService.QueryBy(4, "cat");
            Assert.AreEqual(order, list.First());
        }

        [TestMethod()]
        public void SortByTest()
        {
            OrderService orderService = new OrderService();
            string name = "hwt";
            string name1 = "HWT";
            int customerID = Math.Abs(name.GetHashCode());
            int customerID1 = Math.Abs(name1.GetHashCode());
            Order order = new Order(1, "yc", name, customerID);
            Order order1 = new Order(2, "YC", name1, customerID1);
            OrderItem item = new OrderItem("cat", 1);
            OrderItem item1 = new OrderItem("dog", 2);
            order.AddItem(item);
            order1.AddItem(item1);
            orderService.AddOrder(order);
            Assert.IsTrue(orderService.AddOrder(order1));
            Assert.AreEqual(orderService.orders.Count, 2);
            List<Order> list = orderService.SortBy(1); 
            Assert.AreEqual(order, list[0]);
            Assert.AreEqual(order1, list[1]);
            list = orderService.SortBy(2);
            if (customerID < customerID1)
            {
                Assert.AreEqual(order, list[0]);
                Assert.AreEqual(order1, list[1]);
            }
            else
            {
                Assert.AreEqual(order1, list[0]);
                Assert.AreEqual(order, list[1]);
            }
            list = orderService.SortBy(3);
            Assert.AreEqual(order, list[0]);
            Assert.AreEqual(order1, list[1]);
            list = orderService.SortBy(4);
            Assert.AreEqual(order, list[0]);
            Assert.AreEqual(order1, list[1]);
        }

        [TestMethod()]
        public void ExportTest()
        {
            OrderService orderService = new OrderService();
            string name = "hwt";
            int customerID = Math.Abs(name.GetHashCode());
            Order order = new Order(1, "yc", name, customerID);
            orderService.AddOrder(order);
            string fileName = "orders.xml";
            orderService.Export(fileName);
            string[] contents = File.ReadAllLines(fileName);
            Assert.IsTrue(File.Exists(fileName));
            string[] expectedContents =
            {
                "<?xml version=\"1.0\"?>",
                "<ArrayOfOrder xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">",
                "  <Order>",
                "    <items />",
                "    <ID>1</ID>",
                "    <Address>yc</Address>",
                "    <Time>" + order.Time + "</Time>",
                "    <CustomerName>hwt</CustomerName>",
                "    <CustomerID>" + customerID + "</CustomerID>",
                "  </Order>",
                "</ArrayOfOrder>"
            };
            for (int i = 0; i < expectedContents.Length; i++)
                Assert.AreEqual(expectedContents[i], contents[i]);
        }

        [TestMethod()]
        public void ImportTest()
        {
            OrderService orderService = new OrderService();
            Order order = new Order(1, "yc", "hwt", 1);
            orderService.AddOrder(order);
            string fileName = "orders.xml";
            orderService.Export(fileName);
            List<Order> list = orderService.Import(fileName);
            Assert.AreEqual(list.First(),orderService.orders.First());
        }
    }
}