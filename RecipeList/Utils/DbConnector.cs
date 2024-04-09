using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RecipeList.Utils
{
    public class DbConnector
    {
        public static MySqlConnection Connector()
        {
            var connector = new MySqlConnection();
            connector.ConnectionString = "Server=localhost;Database=sangkap;Uid=root";
            return connector;
        }
    }
}
