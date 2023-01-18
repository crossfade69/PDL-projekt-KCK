using customforms.DataDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customforms
{
    public class DataBase
    {
        private List<Game> games;
        private User currentUser;
        public AccountType currentAccountType;
        private static SqlConnection connection;
        private string connectionString = "Server=tcp:pdl.database.windows.net,1433;" +
               "Initial Catalog=PDL;Persist Security Info=False;" +
               "User ID=adminpdl;Password=Minecrafte123;MultipleActiveResultSets=False;" +
               "Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private DataBase()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }
        private static DataBase instance = new DataBase();
        public static DataBase GetInstance()
        {
            return instance;
        }
        public static SqlConnection GetConnection() { return connection; }
        public List<Game> GetAllGames()
        {
            if (games == null)
            {
                games = new List<Game>();
                string sql = "SELECT * FROM Game ";
                using SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    games.Add(new Game((int)reader[0], (int)reader[5], (string)reader[1], (string)reader[3], (int)reader[4]));
                }
                reader.Close();

            }

            return games;
        }
        public void LogOut()
        {
            currentUser = null;
            currentAccountType = AccountType.normal;
        }
        public void LogIn(User u, string type)
        {
            switch (type)
            {
                case "normal":
                    currentAccountType=AccountType.normal;
                    break;
                case "developer":
                    currentAccountType = AccountType.developer;
                    break;
                case "admin":
                    currentAccountType = AccountType.admin;
                    break;
                default:
                    break;
            }

            currentUser = u;
        }




    }
}
