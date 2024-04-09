using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeList.Utils;
using MySql.Data.MySqlClient;

namespace RecipeList.Model
{
    public class CategoryDAO
    {
        private MySqlConnection _conn;
        public CategoryDAO() 
        {
            _conn = DbConnector.Connector();
        }

        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();

            _conn.Open();
            var cmd = new MySqlCommand("SELECT * FROM categories;", _conn);

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                categories.Add(new Category(id, name));
            }

            _conn.Close();
            return categories;
        }
    }
}
