using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewOrderApp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NewOrderApp.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {

        OrderService service = new OrderService();
        Shopper shopper1 = new Shopper("lby", null, null);
        Shopper shopper2 = new Shopper("681", null, null);
        OrderItem apple = new OrderItem(1, "apple", 10.0, 80);
        OrderItem egg = new OrderItem(2, "egg", 1.2, 200);
        OrderItem milk = new OrderItem(3, "milk", 50, 10);


        [TestInitialize()]
        public void init()
        {
            Order order1 = new Order(DateTime.Now, shopper1, new List<OrderItem> { apple, egg, milk });
            Order order2 = new Order(DateTime.Now, shopper2, new List<OrderItem> { egg, milk });
            Order order3 = new Order(DateTime.Now, shopper1, new List<OrderItem> { apple, milk });
            service = new OrderService();
            service.AddOrder(order1);
            service.AddOrder(order2);
            service.AddOrder(order3);
        }


        [TestMethod()]
        public void AddOrderTest()
        {

            Order order4 = new Order(DateTime.Now, shopper1, new List<OrderItem> { milk });
            service.AddOrder(order4);
            Assert.AreEqual(4, service.Orders.Count);
            CollectionAssert.Contains(service.Orders, order4);
        }


        [TestMethod()]
        [ExpectedException(typeof(ApplicationException))]
        public void AddOrderTest2()
        {
            Order order4 = new Order(DateTime.Now, shopper1, new List<OrderItem> { milk });
            service.AddOrder(order4);
        }


        [TestMethod()]
        public void RemoveOrderTest()
        {
            service.RemoveOrder(3);
            Assert.AreEqual(2, service.Orders.Count);
            service.RemoveOrder(100);
            Assert.AreEqual(2, service.Orders.Count);
        }

        [TestMethod()]
        public void UpdateOrderTest()
        {
            Order order3 = new Order(DateTime.Now, shopper1, new List<OrderItem> { milk });
            service.ReviseOrder(order3);
            Assert.AreEqual(3, service.Orders.Count);
            Order o = service.GetOrder(3);
            Assert.AreEqual(shopper1, o.Shopper);
        }


        [TestMethod()]
        public void QueryOrderByIdTest()
        {
            Order order2 = new Order(DateTime.Now, shopper1, new List<OrderItem> { egg, milk });
            Order o = service.GetOrder(2);
            Assert.IsNotNull(o);
            Assert.AreEqual(order2, o);
            o = service.GetOrder(4);
            Assert.IsNull(o);
        }

        [TestMethod()]
        public void QueryOrdersByGoodsNameTest()
        {
            Assert.AreEqual(2, service.QueryOrdersByGoodsName("apple").Count);
            Assert.AreEqual(2, service.QueryOrdersByGoodsName("egg").Count);
            Assert.AreEqual(3, service.QueryOrdersByGoodsName("milk").Count);
            Assert.AreEqual(0, service.QueryOrdersByGoodsName("orange").Count);
        }

        [TestMethod()]
        public void QueryOrdersByShopperTest()
        {
            Assert.AreEqual(1, service.QueryOrdersByShopper("lby").Count);
            Assert.AreEqual(2, service.QueryOrdersByShopper("681").Count);
            Assert.AreEqual(0, service.QueryOrdersByShopper("lby").Count);
        }

        [TestMethod()]
        public void ExportTest()
        {
            String file = "temp.xml";
            service.Export(file);
            Assert.IsTrue(File.Exists(file));
            List<String> expectLines = File.ReadLines("expectedOrders.xml").ToList();
            List<String> outputLines = File.ReadLines(file).ToList();
            Assert.AreEqual(expectLines.Count, outputLines.Count);
            for (int i = 0; i < expectLines.Count; i++)
            {
                Assert.AreEqual(expectLines[i].Trim(), outputLines[i].Trim());
            }

        }

        [TestMethod()]
        public void ImportTest1()
        {
            OrderService os = new OrderService();
            os.Import("./expectedOrders.xml");
            Assert.AreEqual(3, os.Orders.Count);

            os.Import("./newOrders.xml");
            Assert.AreEqual(5, os.Orders.Count);
        }


        [TestMethod()]
        [ExpectedException(typeof(FileNotFoundException))]
        public void ImportTest3()
        {
            OrderService os = new OrderService();
            os.Import("./ordersNotExist.xml");
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ImportTest4()
        {
            OrderService os = new OrderService();
            os.Import("./ordersErrorContain.xml");
        }

    }
}