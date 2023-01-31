using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Reports
{
    public static class SQLCommandsForReport
    {
        public static SqlConnection Connection = Program.SqlConnection;
        public static DataTable SearchingForFeed(int FeedID, int ClientId)
        {
            string sql = $"SELECT DISTINCT Client.Email, Client.Phone_number, Client.Full_name, " +
                $"\r\nSelling.Selling_date, Feed_name, Feed.Cost, Feed.Discount" +
                $"\r\nFROM Client, Feed, Selling, Product" +
                $"\r\nWHERE Feed.Feed_id = {FeedID} AND Client.Client_id = {ClientId} AND Client.Client_id = Selling.Client_id " +
                $"\r\nAND Product.Product_id = Feed.Feed_id AND Product.Product_id = Selling.Product_id";
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static DataTable SearchingForAnimal(int AnimalID, int ClientId)
        {
            string sql = $"SELECT DISTINCT Client.Email, Client.Phone_number, Client.Full_name, " +
                $"\r\nSelling.Selling_date, Animal_name, Animal.Cost, Animal.Discount" +
                $"\r\nFROM Client, Animal, Selling, Product" +
                $"\r\nWHERE Animal.Animal_id = {AnimalID} AND Client.Client_id = {ClientId} AND Client.Client_id = Selling.Client_id " +
                $"\r\nAND Product.Product_id = Animal.Animal_id AND Product.Product_id = Selling.Product_id";
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }



        public static DataTable ReportBySeasons()
        {
            string sql = $"SELECT SUM(Selling.Total_price)" +
                $"\r\nFROM Selling" +
                $"\r\nWHERE Selling.Selling_date BETWEEN '01.09.2023' AND '01.12.2023'" +
                $"\r\nUNION" +
                $"\r\nSELECT SUM(Selling.Total_price)" +
                $"\r\nFROM Selling" +
                $"\r\nWHERE Selling.Selling_date BETWEEN '01.12.2022' AND '01.02.2023'" +
                $"\r\nUNION" +
                $"\r\nSELECT SUM(Selling.Total_price)" +
                $"\r\nFROM Selling" +
                $"\r\nWHERE Selling.Selling_date BETWEEN '01.03.2023' AND '01.06.2023'" +
                $"\r\nUNION" +
                $"\r\nSELECT SUM(Selling.Total_price)" +
                $"\r\nFROM Selling" +
                $"\r\nWHERE Selling.Selling_date BETWEEN '01.06.2023' AND '01.09.2023'";
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }



        public static List<double> ReportBySeasonsRevolution(int year)
        {
            List<double> list = new List<double>();
            string sqlForAutumn = $"SELECT SUM(Selling.Total_price)" +
                $"\r\nFROM Selling" +
                $"\r\nWHERE Selling.Selling_date BETWEEN '01.09.{year}' AND '01.12.{year}'";
            using (SqlCommand comFeed = new SqlCommand(sqlForAutumn, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (DBNull.Value.Equals(dt.Rows[0].ItemArray[0]))
                {
                    list.Add(0);
                }
                else
                {
                    list.Add(Convert.ToDouble(dt.Rows[0].ItemArray[0]));
                }
            }
            string sqlForWinter = $"SELECT SUM(Selling.Total_price)" +
                $"\r\nFROM Selling" +
                $"\r\nWHERE Selling.Selling_date BETWEEN '01.12.{year-1}' AND '01.03.{year}'";
            using (SqlCommand comFeed = new SqlCommand(sqlForWinter, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (DBNull.Value.Equals(dt.Rows[0].ItemArray[0]))
                {
                    list.Add(0);
                }
                else
                {
                    list.Add(Convert.ToDouble(dt.Rows[0].ItemArray[0]));
                }
            }

            string sqlForSpring = $"SELECT SUM(Selling.Total_price)" +
                $"\r\nFROM Selling" +
                $"\r\nWHERE Selling.Selling_date BETWEEN '01.03.{year}' AND '01.06.{year}'";
            using (SqlCommand comFeed = new SqlCommand(sqlForSpring, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (DBNull.Value.Equals(dt.Rows[0].ItemArray[0]))
                {
                    list.Add(0);
                }
                else
                {
                    list.Add(Convert.ToDouble(dt.Rows[0].ItemArray[0]));
                }
            }

            string sqlForSummer = $"SELECT SUM(Selling.Total_price)" +
                $"\r\nFROM Selling" +
                $"\r\nWHERE Selling.Selling_date BETWEEN '01.06.{year}' AND '01.09.{year}'";
            using (SqlCommand comFeed = new SqlCommand(sqlForSummer, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (DBNull.Value.Equals(dt.Rows[0].ItemArray[0]))
                {
                    list.Add(0);
                }
                else
                {
                    list.Add(Convert.ToDouble(dt.Rows[0].ItemArray[0]));
                }
            }
            return list;
        }
    }
}
