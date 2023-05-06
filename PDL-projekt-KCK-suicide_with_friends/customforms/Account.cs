using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace customforms
{
    public abstract class Account
    {
        public string nick;
        public string email;
        public string password;
        public string typeOfUser;
        public int id;
        public byte[] image;

        public Image Image
        {
            get
            {
                // Convert the byte array to an Image object and return it
                using (MemoryStream ms = new MemoryStream(image))
                {
                    return Image.FromStream(ms);
                }
            }
            set
            {
                // Convert the Image object to a byte array and store it
                using (MemoryStream ms = new MemoryStream())
                {
                    value.Save(ms, value.RawFormat);
                    image = ms.ToArray();
                }
            }
        }
        
        public bool Login(string email, string password)
        {
            // Replace with your own connection string and database name
            string connectionString = "Server=tcp:pdl.database.windows.net,1433;" +
                "Initial Catalog=PDL;Persist Security Info=False;" +
                "User ID=adminpdl;Password=Minecrafte123;MultipleActiveResultSets=False;" +
                "Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Replace with your own SQL query to retrieve the user from the database
                string sql = "SELECT * FROM accounts WHERE email = @email AND password = @password";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Login successful
                            this.nick = reader["nick"].ToString();
                            this.email = reader["email"].ToString();
                            this.password = reader["password"].ToString();
                            this.typeOfUser = reader["typeOfUser"].ToString();
                            this.id = (int)reader["id"];
                            this.image = (byte[])reader["image"]; // Add this line to retrieve the image data
                            return true;
                        }
                        else
                        {
                            // Login failed
                            return false;
                        }
                    }
                }
            }
        }
    }
    public class AccountMap : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Accounts");
            builder.HasKey(a => a.id);

            builder.Property(a => a.nick).IsRequired().HasMaxLength(50);
            builder.Property(a => a.email).IsRequired().HasMaxLength(50);
            builder.Property(a => a.password).IsRequired().HasMaxLength(50);
            builder.Property(a => a.typeOfUser).IsRequired().HasMaxLength(50);
            builder.Property(a => a.id).ValueGeneratedOnAdd();
            builder.Property(a => a.image).IsRequired();
        }
    }
    public class MyDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountMap());
        }
    }
    public void DownloadFileFromDatabase(string connectionString, string tableName, string fileNameColumn, string idColumn, int idValue, string localFilePath)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            // Zapytanie SQL pobierające nazwę pliku
            string query = $"SELECT {fileNameColumn} FROM {tableName} WHERE {idColumn} = @idValue";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Ustawienie wartości parametru w zapytaniu SQL
                command.Parameters.AddWithValue("@idValue", idValue);

                // Wykonanie zapytania i pobranie wyniku
                string fileName = (string)command.ExecuteScalar();

                // Pobranie strumienia z plikiem z bazy danych
                using (SqlCommand fileCommand = new SqlCommand($"SELECT Data FROM {tableName} WHERE {idColumn} = @idValue", connection))
                {
                    // Ustawienie wartości parametru w zapytaniu SQL
                    fileCommand.Parameters.AddWithValue("@idValue", idValue);

                    // Pobranie strumienia z plikiem z bazy danych
                    using (SqlDataReader reader = fileCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Zapisanie strumienia do pliku na dysku twardym
                            using (FileStream fileStream = new FileStream(localFilePath, FileMode.Create))
                            {
                                byte[] buffer = (byte[])reader["Data"];
                                fileStream.Write(buffer, 0, buffer.Length);
                            }
                        }
                    }
                }
            }
        }
    }
}


