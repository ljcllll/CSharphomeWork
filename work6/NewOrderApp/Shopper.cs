using System;
using System.Collections.Generic;
using System.Text;

namespace NewOrderApp
{
    public class Shopper
    {
        public string Name { get; set; }

        private string CardID { get; set; }

        private string Code { get; set; }

        public Shopper() { }

        public Shopper(string Name, string CardID,string Code)
        {
            this.Name = Name;
            this.CardID = CardID != null ? CardID : DateTime.Now.GetHashCode().ToString();
            this.Code = Code != null ? Code : "";
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
