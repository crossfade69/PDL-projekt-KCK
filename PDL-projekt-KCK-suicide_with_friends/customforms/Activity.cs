using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customforms {
    public class Activity
    {
        public int id;
        public string title;
        public string description;
        public DateTime postDate;

        public int GetId()
        {
            return id;
        }
        //File
    }
    public class ActivityMap : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.ToTable("Activities");
            builder.HasKey(a => a.id);

            builder.Property(a => a.title).IsRequired().HasMaxLength(50);
            builder.Property(a => a.description).IsRequired().HasMaxLength(1000);
            builder.Property(a => a.postDate).IsRequired();
            builder.Property(a => a.id).ValueGeneratedOnAdd();
        }
    }

}

