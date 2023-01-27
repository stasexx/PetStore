using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetStore
{
    internal class SQLCommandForAdmin
    {
        public static SqlConnection Connection = Program.SqlConnection;
        public static DataTable Searching(string argument, string table, string column)
        {
            string sql = $"SELECT *" +
                $"\r\nFROM {table}" +
                $"\r\nWHERE {column} LIKE '%{argument}%'";
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static List<string> Combo(string name)
        {
            string sql = "SELECT COLUMN_NAME" +
                "\r\nFROM Zoo.INFORMATION_SCHEMA.COLUMNS" +
                $"\r\nWHERE TABLE_NAME = N'{name}'";
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
        public static List<int> SelectorForCageInAnimalEdit(string str)
        {
            string sql = "SELECT Cage.Cage_id" +
                "\r\nFROM Cage, GroupOfAnimal" +
                "\r\nWHERE Cage.Capacity > (SELECT COUNT(Animal.Animal_id)" +
                "\r\nFROM Animal" +
                "\r\nWHERE Animal.Cage_id = Cage.Cage_id) AND Cage.Group_of_animal_id = GroupOfAnimal.Group_of_animal_id " +
                $"\r\nAND Group_name = '{str}'";

            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                List<int> result = new List<int>();
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    foreach (var item in dt.Rows[i].ItemArray)
                    {
                        result.Add(Convert.ToInt32(item));
                    }
                }
                return result;
            }
        }
        public static List<string> SelectForGroup()
        {
            string sql = "SELECT Group_name FROM GroupOfAnimal";
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


        public static int GroupIdSelector(string name)
        {
            int result = 0;
            string sql = $"SELECT Group_of_animal_id FROM GroupOfAnimal WHERE Group_name = '{name}'";
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                result = Convert.ToInt32(dt.Rows[0].ItemArray[0]);
            }
            return result;
        }
        public static string GroupSelectorNameWithId(int id)
        {
            string result = "";
            string sql = $"SELECT Group_name FROM GroupOfAnimal WHERE Group_of_animal_id = '{id}'";
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                result = dt.Rows[0].ItemArray[0].ToString();
            }
            return result;
        }

        public static List<int> SelectorTypeAnimal()
        {
            string sql = "SELECT Product_id FROM Product WHERE Product.Type = 'Тварина'";

            List<int> listProductsId = new List<int>();
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                List<int> result = new List<int>();
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    foreach (var item in dt.Rows[i].ItemArray)
                    {
                        listProductsId.Add(Convert.ToInt32(item));
                    }
                }
            }

            string sql2 = "SELECT Animal_id FROM Animal";
            List<int> listAnimalId = new List<int>();

            using (SqlCommand comFeed = new SqlCommand(sql2, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                List<int> result = new List<int>();
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    foreach (var item in dt.Rows[i].ItemArray)
                    {
                        listAnimalId.Add(Convert.ToInt32(item));
                    }
                }
            }
            List<int> resultAnimalId = new List<int>();
            foreach (int id in listProductsId)
            {
                if (!listAnimalId.Contains(id))
                {
                    resultAnimalId.Add(id);
                }
            }
            return resultAnimalId;
        }

        public static List<int> SelectorTypeFeed()
        {
            string sql = "SELECT Product_id FROM Product WHERE Product.Type = 'Корм'";

            List<int> listProductsId = new List<int>();
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                List<int> result = new List<int>();
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    foreach (var item in dt.Rows[i].ItemArray)
                    {
                        listProductsId.Add(Convert.ToInt32(item));
                    }
                }
            }

            string sql2 = "SELECT Feed_id FROM Feed";
            List<int> listFeedId = new List<int>();

            using (SqlCommand comFeed = new SqlCommand(sql2, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                List<int> result = new List<int>();
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    foreach (var item in dt.Rows[i].ItemArray)
                    {
                        listFeedId.Add(Convert.ToInt32(item));
                    }
                }
            }
            List<int> resultAnimalId = new List<int>();
            foreach (int id in listProductsId)
            {
                if (!listFeedId.Contains(id))
                {
                    resultAnimalId.Add(id);
                }
            }
            return resultAnimalId;
        }

        public static List<string> SelectForFeedPurpose()
        {
            string sql = "SELECT DISTINCT GroupOfAnimal.Group_name FROM GroupOfAnimal";
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
        
        public static List<string> ForCheck()
        {
            string sql = "SELECT Product_id FROM Product";
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

        public static int IdSelect()
        {
            string sql = "SELECT MAX(Product_id) FROM Product";
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                string result = dt.Rows[0].ItemArray[0].ToString();
                return Convert.ToInt32(result);
            }
        }

        public static void Delete(string table, int id)
        {
            string result = "";
            string sql1 = $"select COLUMN_NAME" +
                $"\r\nfrom INFORMATION_SCHEMA.COLUMNS" +
                $"\r\nwhere TABLE_NAME = '{table}'";
            using (SqlCommand comFeed = new SqlCommand(sql1, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                result = dt.Rows[0].ItemArray[0].ToString();
            }

            string sql = $"DELETE FROM {table} WHERE {result} = {id}";
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
