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
        public static DataTable Searching(int FeedID, int ClientId)
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
    }
}
