using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql;
namespace OrderApp
{
    class mySql
    {
        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(
                "database = localhost;username = root;" +
                "password = 123456;charset=utf8;"
                );
            connection.Open();
            return connection;


        }

        public mySql()
        {
            MySqlCommand cmd = new MySqlCommand("CREATE DATABASE Order;"
                +"CREATE TABLE Customer (ID STRING,NAME STRING);"
                +"CREATE TABLE Goods (ID STRING,NAME STRING,PRICE DOUBLE);"
                +"CREATE TABLE OrderItem (Index INTEGER,GoodsItem STRING," +
                "GoodsName String,UintPrice DOUBLE,Quantity INTEGER," +
                "FOREIGN KEY (GoodsName) REFERENCE Goods (NAME)," +
                "FOREIGN KEY (UintPrice) REFERENCE Goods (PRICE));" +
                "CREATE TABLE Order (OrderId INTEGER,Customer STRING," +
                "CustomerName String,CreateTime INTEGER," +
                "FOREIGN KEY (CustomerName) REFERENCE Customer (NAME));"
                

                ,mySql.GetConnection());

            cmd.ExecuteNonQuery();
            GetConnection().Close();
            
        }

        



    }
}
