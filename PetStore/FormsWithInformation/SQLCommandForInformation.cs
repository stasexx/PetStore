using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.FormsWithInformation
{
    public static class SQLCommandForInformation
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


        public static DataTable Filter(int variation, string argument1, string argument2, string argument3)
        {
            string mainSql = "";
            if(variation == 1)
            {
                mainSql = $"SELECT * FROM Feed WHERE Caloric > {argument1} ";

            }
            if (variation == 2)
            {
                mainSql = $"SELECT * FROM Feed WHERE Caloric < {argument2} ";

            }
            if (variation == 3)
            {
                mainSql = $"SELECT * FROM Feed WHERE Caloric BETWEEN {argument1} AND {argument2}";

            }
            if (variation == 4)
            {
                mainSql = $"SELECT * FROM Feed WHERE Kind = '{argument3}'";
            }

            if (variation == 5)
            {
                mainSql = $"SELECT * FROM Feed WHERE Kind = '{argument3}' AND Caloric > {argument1}";
            }

            if (variation == 6)
            {
                mainSql = $"SELECT * FROM Feed WHERE Kind = '{argument3}' AND Caloric < {argument2}";
            }

            if (variation == 7)
            {
                mainSql = $"SELECT * FROM Feed WHERE Kind = '{argument3}' AND Caloric BETWEEN {argument1} AND {argument2}";
            }

            using (SqlCommand comFeed = new SqlCommand(mainSql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public static DataTable FilterForAnimal(int variation, string argument1, string argument2, int argument3)
        {
            string mainSql = "";
            if (variation == 1)
            {
                mainSql = $"SELECT * FROM Animal WHERE Age > {argument1} ";

            }
            if (variation == 2)
            {
                mainSql = $"SELECT * FROM Animal WHERE Age < {argument2} ";

            }
            if (variation == 3)
            {
                mainSql = $"SELECT * FROM Animal WHERE Age BETWEEN {argument1} AND {argument2}";

            }
            if (variation == 4)
            {
                mainSql = $"SELECT * FROM Animal WHERE Group_of_animal_id = {argument3}";
            }

            if (variation == 5)
            {
                mainSql = $"SELECT * FROM Animal WHERE Group_of_animal_id = {argument3} AND Age > {argument1}";
            }

            if (variation == 6)
            {
                mainSql = $"SELECT * FROM Animal WHERE Group_of_animal_id = {argument3} AND Age < {argument2}";
            }

            if (variation == 7)
            {
                mainSql = $"SELECT * FROM Animal WHERE Group_of_animal_id = {argument3} AND Age BETWEEN {argument1} AND {argument2}";
            }

            using (SqlCommand comFeed = new SqlCommand(mainSql, Connection))
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
