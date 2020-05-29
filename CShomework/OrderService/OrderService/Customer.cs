using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;

namespace OrderApp {
  public class Customer {
    public string ID { get; set; }
    public string Name { get; set; }

    public Customer() {


            //mySql.GetConnection();
            MySqlCommand cmd1 = new MySqlCommand("SELECT ID FROM Customer;", mySql.GetConnection());
            MySqlDataReader dataReader1 = cmd1.ExecuteReader();
            ID = dataReader1.GetString(1);
            MySqlCommand cmd2 = new MySqlCommand("SELECT NAME FROM Customer;", mySql.GetConnection());
            MySqlDataReader dataReader2 = cmd2.ExecuteReader();
            Name = dataReader2.GetString(1);
            mySql.GetConnection().Close();
    }

        

    public Customer(string iD, string name) {
      //ID = iD;
      //Name = name;
    }


    public override bool Equals(object obj) {
      var customer = obj as Customer;
      return customer != null &&
             ID == customer.ID &&
             Name == customer.Name;
    }

    public override int GetHashCode() {
      var hashCode = 1479869798;
      hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
      hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
      return hashCode;
    }
  }
}
