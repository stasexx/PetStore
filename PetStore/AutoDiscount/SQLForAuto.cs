using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.AutoDiscount
{
    public static class SQLForAuto
    {
        public static SqlConnection Connection = Program.SqlConnection;

        public static List<string> Combo()
        {
            string sql = "SELECT DISTINCT Animal_id, Animal.Animal_name, Feed.Feed_id, ((Animal.Calories_per_day/Feed.Caloric)*30)/3, Feed.Cost*90 AS 'Cost90Days'" +
                "\r\nFROM Animal, Feed, GroupOfAnimal, Supply\r\nWHERE Animal.Group_of_animal_id = GroupOfAnimal.Group_of_animal_id AND Feed.Purpose = Group_name" +
                "\r\nAND GroupOfAnimal.Food_method = Feed.Kind AND Supply.Amount >= 30*((Animal.Calories_per_day/3)/(Feed.Caloric*10))";
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                List<string> result = new List<string>();
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    foreach (var item in dt.Rows[i].ItemArray)
                    {
                        result.Add(item.ToString());
                    }
                }
                return result;
            }
        }
        public static DataTable TableCalc()
        {
            string sql = "SELECT Animal.Animal_id, Animal.Animal_name, MIN(Feed.Cost) AS 'MinCost', MIN(Feed.Cost)*MIN(((Animal.Calories_per_day/(Feed.Caloric*10))*30)) AS 'TotalForMonth'" +
                "\r\nFROM GroupOfAnimal, Feed, Animal, Supply" +
                "\r\nWHERE Feed.Purpose = Group_name AND Animal.Group_of_animal_id = GroupOfAnimal.Group_of_animal_id AND Supply.Feed_id = Feed.Feed_id" +
                "\r\nAND Supply.Amount >= 30*((Animal.Calories_per_day/3)/(Feed.Caloric*10))" +
                "\r\nGROUP BY Animal.Animal_id, Animal.Cost, GroupOfAnimal.Group_name, Animal.Animal_name" +
                "\r\nORDER BY Animal.Cost/MIN(Feed.Cost)*MIN(((Animal.Calories_per_day/(Feed.Caloric*10))*30))";
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public static void UpdateDiscountForFeed(int discount, int id)
        {
            string sql = $"UPDATE Feed " +
                $"\r\nSET Discount = {discount}" +
                $"\r\nWHERE Feed_id = {id}";
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
            }
        }
        public static void UpdateDiscountForAnimal(int id, int discount)
        {
            string sql = $"UPDATE Animal " +
                $"\r\nSET Discount = {discount}" +
                $"\r\nWHERE Animal_id = {id}";
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
            }
        }




    }
}
