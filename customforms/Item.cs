using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customforms
{
    public class Item
    {
        public int id;
        public string name;
        public string description;
        //File
        public int gameId;
    }
    public class ItemMap : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Items");
            builder.HasKey(i => i.id);

            builder.Property(i => i.name).IsRequired().HasMaxLength(50);
            builder.Property(i => i.description).IsRequired().HasMaxLength(1000);
            builder.Property(i => i.gameId).IsRequired();
            builder.Property(i => i.id).ValueGeneratedOnAdd();

            
        }
        

    }

}
