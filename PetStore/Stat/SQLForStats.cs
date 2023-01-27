using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace PetStore.Stat
{
    public static class SQLForStats
    {
        public static SqlConnection Connection = Program.SqlConnection;
        public static DataTable SecondStats()
        {
            string sql = $"SELECT Cage.Cage_id, Cage.Capacity, ROUND(CAST(COUNT(Animal.Animal_id) AS DECIMAL (9,2))/Cage.Capacity, 3) AS Filling_the_cage" +
                $"\r\nFROM Cage, Animal" +
                $"\r\nWHERE Cage.Cage_id = Animal.Cage_id" +
                $"\r\nGROUP By Cage.Cage_id, Cage.Capacity, Cage.Group_of_animal_id";
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static DataTable ThirdStats()
        {
            string sql = $"SELECT Animal.Animal_id, Animal.Animal_name, MIN(Feed.Cost) AS 'MinCost', MIN(Feed.Cost)*MIN(((Animal.Calories_per_day/(Feed.Caloric*10))*30)) AS 'TotalForMonth'" +
                $"\r\nFROM GroupOfAnimal, Feed, Animal, Supply" +
                $"\r\nWHERE Feed.Purpose = Group_name AND Animal.Group_of_animal_id = GroupOfAnimal.Group_of_animal_id AND Supply.Feed_id = Feed.Feed_id" +
                $"\r\nAND Supply.Amount >= 3*((Animal.Calories_per_day/3)/(Feed.Caloric*10))*30" +
                $"\r\nGROUP BY Animal.Animal_id, Animal.Cost, GroupOfAnimal.Group_name, Animal.Animal_name" +
                $"\r\nORDER BY Animal.Cost/MIN(((Animal.Calories_per_day/(Feed.Caloric*10))*30))";
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static DataTable FirstStats()
        {
            string sql = $"SELECT Feed.Feed_name, Selling.Selling_date, COUNT(Selling_id) AS CountOFSelling" +
                $"\r\nFROM Selling, Product, Feed" +
                $"\r\nWHERE Selling.Product_id = Product.Product_id AND Product.Type = 'Корм' AND Product.Product_id = Feed.Feed_id" +
                $"\r\nAND (DATEDIFF(day, GETDATE(), Selling.Selling_date))<30" +
                $"\r\nGROUP BY Selling.Selling_date, Feed.Feed_name\r\n";
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static DataTable FourthStats()
        {
            string sql = $"SELECT GroupOfAnimal.Group_name, COUNT(Feed_id) AS 'CountOfFeeds'" +
                $"\r\nFROM GroupOfAnimal, Feed" +
                $"\r\nWHERE Feed.Purpose = GroupOfAnimal.Group_name" +
                $"\r\nGROUP BY GroupOfAnimal.Group_name";
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
