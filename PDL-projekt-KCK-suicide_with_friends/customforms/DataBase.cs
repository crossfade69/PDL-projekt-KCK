using customforms.DataDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace customforms
{
    public class DataBase
    {
        private List<Game> games;
        public User currentUser;
        public List<Game> currentUserGameList;
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
        public List<Game> GetCurrentGames() 
        {
            if (currentUserGameList == null)
            {
                currentUserGameList = new List<Game>();
                string sql = "select * from [dbo].[Game] where id=any(select gameId from [dbo].[GameOwner] where userId=@id) ";
                using SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", currentUser.id);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    currentUserGameList.Add(new Game((int)reader[0], (int)reader[5], (string)reader[1], (string)reader[3], (int)reader[4]));
                }
                reader.Close();
            }

            return currentUserGameList;
        }
        public List<User> GetCurrentFriends()
        {
            List<User> friends = new List<User>();
            while (rdr.Read())
            {
                int id = rdr.GetInt32(0);
                string firstName = rdr.GetString(1);
                string lastName = rdr.GetString(2);
                string username = rdr.GetString(3);
                string password = rdr.GetString(4);
                string email = rdr.GetString(5);
                DateTime timestamp = rdr.GetDateTime(6);
                User newUser = new User(firstName, lastName, username, password, email, timestamp, id);
                newUser.ImgURL = rdr.GetString(7);
                friends.Add(newUser);
            }

            if (rdr != null)
            {
                rdr.Close();
            }

            SqlCommand cmd2 = new SqlCommand("SELECT users.* FROM users JOIN user_friendships ON (users.id = user_friendships.user1_id) WHERE user2_id = @UserId;", conn);
            cmd2.Parameters.Add(new SqlParameter("@UserId", this.Id));

            SqlDataReader rdr2 = cmd2.ExecuteReader();

            while (rdr2.Read())
            {
                int id = rdr2.GetInt32(0);
                string firstName = rdr2.GetString(1);
                string lastName = rdr2.GetString(2);
                string username = rdr2.GetString(3);
                string password = rdr2.GetString(4);
                string email = rdr2.GetString(5);
                DateTime timestamp = rdr2.GetDateTime(6);
                User newUser = new User(firstName, lastName, username, password, email, timestamp, id);
                newUser.ImgURL = rdr2.GetString(7);
                friends.Add(newUser);
            }

            if (rdr2 != null)
            {
                rdr2.Close();
            }
            if (conn != null)
            {
                conn.Close();
            }
            return friends;

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
