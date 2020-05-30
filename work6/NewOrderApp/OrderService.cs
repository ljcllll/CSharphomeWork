using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace NewOrderApp
{
    public class OrderService
    {

        public List<Order> Orders { get; set; }

        public OrderService()
        {
            Orders = new List<Order>();
        }

        public Order GetOrder(uint OrderIndex)
        {
            return Orders.Where(Order => Order.orderIndex == OrderIndex).FirstOrDefault();
        }

        public void AddOrder(Order order)
        {
            if (Orders.Contains(order)) { throw new Exception($"Add Order Error: Order with id { order.OrderIndex } already exists!"); }
            Orders.Add(order);
        }

        public void RemoveOrder(uint OrderIndex)
        {
            Order order = GetOrder(OrderIndex);
            Orders.Remove(order);
        }

        public void ReviseOrder(Order newOrder)
        {
            Order oldOrder = GetOrder(newOrder.OrderIndex);
            Orders.Remove(oldOrder);
            Orders.Add(newOrder);
        }

        public List<Order> QueryOrdersByGoodsName(string GoodsName)
        {
            var orders = Orders.Where(order => order.Items.Exists(Item => Item.GoodsName == GoodsName)).OrderBy(order => order.TotalPrice);
            return orders.ToList();
        }

        public List<Order> QueryOrdersByShopper(string Shopper)
        {
            return Orders.Where(order=>order.Shopper.Name==Shopper).OrderBy(order => order.OrderIndex).ToList();
        }

        public void Sort()
        {
            Orders.Sort();
        }

        public void Sort(Func<Order,Order,int> func)
        {
            Orders.Sort((o1, o2) => func(o1, o2));
        }

        public void Export(string fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xs.Serialize(fs, Orders);
            }
        }

        public void Import(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Order> temp = (List<Order>)xs.Deserialize(fs);
                temp.ForEach(order => {
                    if (!Orders.Contains(order))
                    {
                        Orders.Add(order);
                    }
                });
            }
        }
    }
}
