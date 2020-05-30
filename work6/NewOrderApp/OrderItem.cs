using System;
using System.Collections.Generic;
using System.Text;

namespace NewOrderApp
{
    public class OrderItem
    {
        public uint Index { get; set; }

        public string GoodsName { get; set; }

        public double Price { get; set; }

        public uint Quantity { get; set; }

        public OrderItem() { }

        public OrderItem(uint Index,string GoodsName,double Price,uint Quantity)
        {
            this.Index = Index;
            this.GoodsName = GoodsName;
            this.Price = Price;
            this.Quantity = Quantity;
        }

        public double TotalPrice { get => Price * Quantity; }

        public override string ToString()
        {
            return $"[NO:{Index} Goods:{GoodsName} Quantity:{Quantity} TotalPrice:{TotalPrice}]";
        }

        public override bool Equals(object obj)
        {
            var Item = obj as OrderItem;
            return Item != null && this.GoodsName == Item.GoodsName;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
