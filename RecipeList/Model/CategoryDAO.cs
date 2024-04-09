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

        public List<string> GetCategories()
        {
            List<string> categories = new List<string>();

            _conn.Open();
            var cmd = new MySqlCommand("SELECT name FROM categories;", _conn);

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                categories.Add(reader.GetString(0));
            }

            _conn.Close();
            return categories;
        }
    }
}
