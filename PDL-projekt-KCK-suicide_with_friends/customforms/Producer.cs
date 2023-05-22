using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using customforms.DataDB;

namespace customforms
{
    public class Producer : Account
    {
        public List<int> publishedGames = new List<int>();
        public string description;
        public void PublishGame(Game game)
        {
            if (!publishedGames.Contains(game.id))
            {
                publishedGames.Add(game.id);
                Console.WriteLine($"Game with ID {game.id} published successfully.");
            }
            else Console.WriteLine($"Game with ID {game.id} is already published.");
        }

        public void DeleteGame(int id)
        {
            if (publishedGames.Contains(id))
            {
                publishedGames.Remove(id);
                Console.WriteLine($"Game with ID {id} deleted successfully.");
            }
            else Console.WriteLine($"Game with ID {id} is not found.");
        }
    }
    public class ProducerMap : IEntityTypeConfiguration<Producer>
    {
        public void Configure(EntityTypeBuilder<Producer> builder)
        {
            builder.ToTable("Producers");
            builder.HasKey(a => a.id);

            builder.Property(p => p.publishedGames).IsRequired();
            builder.Property(p => p.description).IsRequired().HasMaxLength(1000);
            builder.Property(p => p.id).ValueGeneratedOnAdd();

            
        }
    }
}
