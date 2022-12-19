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
    public class Producer : Account
    {
        public List<int> publishedGames = new List<int>();
        public string description;
        public void PublishGame(Game game)
        {

        }
        public void DeleteGame(int id)
        {

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
