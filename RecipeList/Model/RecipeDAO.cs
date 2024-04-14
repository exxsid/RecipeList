using MySql.Data.MySqlClient;
using MySqlX.Serialization;
using Org.BouncyCastle.Utilities;
using RecipeList.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
                obj.Image = reader.IsDBNull(reader.GetOrdinal("image")) ? null: (byte[])reader["image"];
                obj.Category = reader.GetString(8);
                recipes.Add(obj);
            }

            _conn.Close();

            return recipes;
        }

        public Recipe GetRecipeById(int id)
        {
            Recipe obj = new Recipe();

            _conn.Open();
            var cmd = new MySqlCommand($"SELECT * FROM recipes r JOIN categories c ON r.category_id = c.id WHERE r.id = {id};", _conn);
            var reader = cmd.ExecuteReader();

            reader.Read();
            obj.Id = reader.GetInt32(0);
            obj.Name = reader.GetString(1);
            obj.Description = reader.GetString(2);
            obj.Ingredients = ParseJson(reader.GetString(3), "ingredients");
            obj.Procedures = ParseJson(reader.GetString(4), "procedures");
            obj.Image = reader.IsDBNull(reader.GetOrdinal("image")) ? null : (byte[])reader["image"];
            obj.Category = reader.GetString(8);
            _conn.Close();

            return obj;
        }

        public List<Recipe> GetRecipeByString (string str)
        {
            List<Recipe> result = new List<Recipe>();

            _conn.Open();

            string query = $"SELECT * FROM recipes r JOIN categories c ON r.category_id = c.id  WHERE r.name LIKE \'%{str}%\';";

            var cmd = new MySqlCommand(query, _conn);
            var reader = cmd.ExecuteReader();
            

            while (reader.Read())
            {
                Recipe obj = new Recipe();
                obj.Id = reader.GetInt32(0);
                obj.Name = reader.GetString(1);
                obj.Description = reader.GetString(2);
                obj.Ingredients = ParseJson(reader.GetString(3), "ingredients");
                obj.Procedures = ParseJson(reader.GetString(4), "procedures");
                obj.Image = reader.IsDBNull(reader.GetOrdinal("image")) ? null : (byte[])reader["image"];
                obj.Category = reader.GetString(8);
                result.Add(obj);
            }

            _conn.Close();

            return result;
        }

        public bool PostRecipe(Recipe recipe)
        {
            _conn.Open();

            string proceduresText = "{\"procedures\":[";
            for (int i = 0; i < recipe.Procedures.Count - 1; i++)
            {
                proceduresText += $"\"{recipe.Procedures[i].Trim()}\",";
            }
            proceduresText += "\"" + recipe.Procedures[recipe.Procedures.Count - 1].Trim() + "\"]}";


            string ingredientsText = "{\"ingredients\":[";
            for (int i = 0; i < recipe.Ingredients.Count - 1; i++)
            {
                ingredientsText += $"\"{recipe.Ingredients[i].Trim()}\",";
            }
            ingredientsText += "\"" + recipe.Ingredients[recipe.Ingredients.Count - 1].Trim() + "\"]}";

            string query = $"INSERT INTO recipes (`name`, `description`, `ingredients`, `procedures`, `image`, `category_id`) VALUES " +
                    $"(@name, @description, @ingredients, @procedures, @image, @category)";

            var cmd = new MySqlCommand(query, _conn);

            var nameParam = new MySqlParameter("@name", MySqlDbType.String);
            var descParam = new MySqlParameter("@description", MySqlDbType.Text);
            var ingrParam = new MySqlParameter("@ingredients", MySqlDbType.JSON);
            var prodParam = new MySqlParameter("@procedures", MySqlDbType.JSON);
            var imgParam = new MySqlParameter("@image", MySqlDbType.Blob, recipe.Image.Length);
            var catParam = new MySqlParameter("@category", MySqlDbType.Int32);

            nameParam.Value = recipe.Name;
            descParam.Value = recipe.Description;
            ingrParam.Value = ingredientsText;
            prodParam.Value = proceduresText;
            imgParam.Value = recipe.Image;
            catParam.Value = recipe.Category;

            cmd.Parameters.Add(nameParam);
            cmd.Parameters.Add(descParam);
            cmd.Parameters.Add(ingrParam);
            cmd.Parameters.Add(prodParam);
            cmd.Parameters.Add(imgParam);
            cmd.Parameters.Add(catParam);

            var affectedRows = cmd.ExecuteNonQuery();

            if(affectedRows < 1)
            {
                _conn.Close();
                return false;
            }
            _conn.Close();
            return true;
        }

        public bool EditRecipe(Recipe recipe)
        {
            _conn.Open();

            string proceduresText = "{\"procedures\":[";
            for (int i = 0; i < recipe.Procedures.Count - 1; i++)
            {
                proceduresText += $"\"{recipe.Procedures[i].Trim()}\",";
            }
            proceduresText += "\"" + recipe.Procedures[recipe.Procedures.Count - 1].Trim() + "\"]}";


            string ingredientsText = "{\"ingredients\":[";
            for (int i = 0; i < recipe.Ingredients.Count - 1; i++)
            {
                ingredientsText += $"\"{recipe.Ingredients[i].Trim()}\",";
            }
            ingredientsText += "\"" + recipe.Ingredients[recipe.Ingredients.Count - 1].Trim() + "\"]}";

            #region code block if the image is not edited
            if (recipe.Image.Length == 1)
            {
                string query1 = "UPDATE recipes SET " +
                "name = @name, " +
                "description = @description, " +
                "ingredients = @ingredients, " +
                "procedures = @procedures, " +
                "category_id = @category " +
                "WHERE id = @id;";

                var cmd1 = new MySqlCommand(query1, _conn);

                var idParam1 = new MySqlParameter("@id", MySqlDbType.Int32);
                var nameParam1 = new MySqlParameter("@name", MySqlDbType.String);
                var descParam1 = new MySqlParameter("@description", MySqlDbType.Text);
                var ingrParam1 = new MySqlParameter("@ingredients", MySqlDbType.JSON);
                var prodParam1 = new MySqlParameter("@procedures", MySqlDbType.JSON);
                var catParam1 = new MySqlParameter("@category", MySqlDbType.Int32);

                idParam1.Value = recipe.Id;
                nameParam1.Value = recipe.Name;
                descParam1.Value = recipe.Description;
                ingrParam1.Value = ingredientsText;
                prodParam1.Value = proceduresText;
                catParam1.Value = recipe.Category;

                cmd1.Parameters.Add(idParam1);
                cmd1.Parameters.Add(nameParam1);
                cmd1.Parameters.Add(descParam1);
                cmd1.Parameters.Add(ingrParam1);
                cmd1.Parameters.Add(prodParam1);
                cmd1.Parameters.Add(catParam1);

                var affectedRows1 = cmd1.ExecuteNonQuery();

                if (affectedRows1 < 1)
                {
                    _conn.Close();
                    return false;
                }
                _conn.Close();
                return true;
            }
            #endregion

            string query = "UPDATE recipes SET " +
                "name = @name, " +
                "description = @description, " +
                "ingredients = @ingredients, " +
                "procedures = @procedures, " +
                "image = @image, " +
                "category_id = @category " +
                "WHERE id = @id;";

            var cmd = new MySqlCommand(query, _conn);

            var idParam = new MySqlParameter("@id", MySqlDbType.Int32);
            var nameParam = new MySqlParameter("@name", MySqlDbType.String);
            var descParam = new MySqlParameter("@description", MySqlDbType.Text);
            var ingrParam = new MySqlParameter("@ingredients", MySqlDbType.JSON);
            var prodParam = new MySqlParameter("@procedures", MySqlDbType.JSON);
            var imgParam = new MySqlParameter("@image", MySqlDbType.Blob, recipe.Image.Length);
            var catParam = new MySqlParameter("@category", MySqlDbType.Int32);

            idParam.Value = recipe.Id;
            nameParam.Value = recipe.Name;
            descParam.Value = recipe.Description;
            ingrParam.Value = ingredientsText;
            prodParam.Value = proceduresText;
            imgParam.Value = recipe.Image;
            catParam.Value = recipe.Category;

            cmd.Parameters.Add(idParam);
            cmd.Parameters.Add(nameParam);
            cmd.Parameters.Add(descParam);
            cmd.Parameters.Add(ingrParam);
            cmd.Parameters.Add(prodParam);
            cmd.Parameters.Add(imgParam);
            cmd.Parameters.Add(catParam);

            var affectedRows = cmd.ExecuteNonQuery();

            if (affectedRows < 1)
            {
                _conn.Close();
                return false;
            }
            _conn.Close();
            return true;
        }

        public List<Recipe> GetRecipeByCategory(string category)
        {
            List<Recipe> recipes = new List<Recipe>();

            _conn.Open();

            var cmd = new MySqlCommand($"SELECT * FROM recipes r JOIN categories c ON r.category_id = c.id WHERE c.name = \"{category}\";", _conn);
            var reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                Recipe obj = new Recipe();
                obj.Id = reader.GetInt32(0);
                obj.Name = reader.GetString(1);
                obj.Description = reader.GetString(2);
                obj.Ingredients = ParseJson(reader.GetString(3), "ingredients");
                obj.Procedures = ParseJson(reader.GetString(4), "procedures");
                obj.Image = reader.IsDBNull(reader.GetOrdinal("image")) ? null : (byte[])reader["image"];
                obj.Category = reader.GetString(8);
                recipes.Add(obj);
            }

            _conn.Close();

            return recipes; 
        }

        public bool DeleteRecipe(int id)
        {
            _conn.Open();

            string query = $"DELETE FROM recipes WHERE id = {id};";

            var cmd = new MySqlCommand(query, _conn);

            var affectedRows = cmd.ExecuteNonQuery();

            if(affectedRows < 1)
            {
                _conn.Close();
                return false;
            }

            _conn.Close();
            return true;
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
