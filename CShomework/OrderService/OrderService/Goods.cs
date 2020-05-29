using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;

namespace OrderApp {
  public class Goods {
    public string ID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public Goods() {

            MySqlCommand cmd1 = new MySqlCommand("SELECT ID FROM Goods;", mySql.GetConnection());
            MySqlDataReader dataReader1 = cmd1.ExecuteReader();
            ID = dataReader1.GetString(1);
            MySqlCommand cmd2 = new MySqlCommand("SELECT NAME FROM Goods;", mySql.GetConnection());
            MySqlDataReader dataReader2 = cmd2.ExecuteReader();
            Name = dataReader2.GetString(1);
            MySqlCommand cmd3 = new MySqlCommand("SELECT PRICE FROM Goods;", mySql.GetConnection());
            MySqlDataReader dataReader3 = cmd3.ExecuteReader();
            Price = dataReader3.GetString(1);


            mySql.GetConnection().Close();
        }

    public Goods(string iD, string name, double price) {
      ID = iD;
      Name = name;
      Price = price;
    }

    public override bool Equals(object obj) {
      var goods = obj as Goods;
      return goods != null &&
             ID == goods.ID &&
             Name == goods.Name;
    }

    public override int GetHashCode() {
      var hashCode = 1479869798;
      hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
      hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
      return hashCode;
    }
  }


}
