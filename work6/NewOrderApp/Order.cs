using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewOrderApp
{
    public class Order
    {
        public static uint orderIndex = 1;

        public DateTime OrderDate { get; set; }

        public uint OrderIndex { get; set; }

        public Shopper Shopper { get; set; }

        public List<OrderItem> Items { get; set; }//set不能少，否则import时不能二次给items赋值，其值为null会导致totalprice报错

        public Order() { }

        public Order(DateTime OrderDate, Shopper Shopper, List<OrderItem> Items)
        {
            this.OrderDate = OrderDate == null ? DateTime.Now : OrderDate;
            this.OrderIndex = Order.orderIndex++;
            this.Shopper = Shopper;
            this.Items = Items != null ? Items : new List<OrderItem>();
        }

        public Order(uint OrderIndex, DateTime OrderDate, Shopper Shopper, List<OrderItem> Items)
        {
            this.OrderDate = OrderDate == null ? DateTime.Now : OrderDate;
            this.OrderIndex = OrderIndex;
            this.Shopper = Shopper;
            this.Items = Items != null ? Items : new List<OrderItem>();
        }

        public double TotalPrice
        {
            get => Items.Sum(Item => Item.TotalPrice);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"[OrderId: {OrderIndex} OrderDate:{OrderDate} OrderShopper:{Shopper} TotalPrice:{TotalPrice}]");
            Items.ForEach(item => stringBuilder.Append("\n\t" + item.ToString()));
            return stringBuilder.ToString();
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null && this.OrderIndex == order.OrderIndex;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
