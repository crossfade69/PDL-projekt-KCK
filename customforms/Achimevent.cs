using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customforms
{
    public class Achimevent
    {
        public int id;
        public string name;
        public string description;
        public int GetId()
        {
            return id;
        }
        //FILE
        public int gameId;
    }
    public class AchimeventMap : IEntityTypeConfiguration<Achimevent>
    {
        public void Configure(EntityTypeBuilder<Achimevent> builder)
        {
            builder.ToTable("Achimevents");
            builder.HasKey(a => a.id);

            builder.Property(a => a.name).IsRequired().HasMaxLength(50);
            builder.Property(a => a.description).IsRequired().HasMaxLength(1000);
            builder.Property(a => a.gameId).IsRequired();
            builder.Property(a => a.id).ValueGeneratedOnAdd();

        }
    }
    


}

