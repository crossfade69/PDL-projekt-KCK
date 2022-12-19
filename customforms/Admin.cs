using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace customforms
{
    public class Admin : Account
    {
        public List<Producer> producers;
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
        public void AddProducer(Producer p)
        {
            producers.Add(p);
        }
    }
    public class AdminMap : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.ToTable("Admins");
            builder.HasKey(a => a.id);

            builder.Property(a => a.nick).IsRequired().HasMaxLength(50);
            builder.Property(a => a.email).IsRequired().HasMaxLength(50);
            builder.Property(a => a.password).IsRequired().HasMaxLength(50);
            builder.Property(a => a.typeOfUser).IsRequired().HasMaxLength(50);
            builder.Property(a => a.id).ValueGeneratedOnAdd();
            builder.Property(a => a.image).IsRequired();

        }
    }
    
}

