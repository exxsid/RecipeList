﻿using MySql.Data.MySqlClient;
using MySqlX.Serialization;
using RecipeList.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeList.Model
{
    public class RecipeDAO
    {

        private MySqlConnection _conn;

        public RecipeDAO()
        {
            _conn = DbConnector.Connector();
        }

        public List<Recipe> GetRecipes()
        {
            List<Recipe> recipes = new List<Recipe>();

            _conn.Open();

            var cmd = new MySqlCommand("SELECT * FROM recipes r JOIN categories c ON r.category_id = c.id;", _conn);
            var reader = cmd.ExecuteReader();
           

            while (reader.Read())
            {
                Recipe obj = new Recipe();
                obj.Id = reader.GetInt32(0);
                obj.Name = reader.GetString(1);
                obj.Description = reader.GetString(2);
                obj.Ingredients = ParseJson(reader.GetString(3), "ingredients");
                obj.Procedures = ParseJson(reader.GetString(4), "procedures");
                obj.Image = reader.IsDBNull(reader.GetOrdinal("image")) ? "" : reader.GetString(5);
                obj.Category = reader.GetString(8);
                recipes.Add(obj);
            }

            _conn.Close();

            return recipes;
        }

        private List<string> ParseJson(string json, string key)
        {
            Object[] temps = (object[])JsonParser.Parse(json)[key];
            List<string> result = new List<string>();
            foreach(Object temp in temps)
            {
                result.Add((string)temp);
            }

            return result;

        }
    }
}