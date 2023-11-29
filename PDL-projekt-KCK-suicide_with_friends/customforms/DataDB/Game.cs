using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace customforms.DataDB
{
    public class Game
    {
        public Game(int id,int producerId,string title,string description,float ratings)
        {
            this.id = id;
            this.producerId = producerId;
            this.title = title;
            this.description = description;
            this.ratings = ratings;

        }
        public int id;
        public int producerId;
        public string title;
        public string description;
        public List<Achimevent> ?achimevents;
        //File
        public List<int> ?reviewId;
        public List<int> ?activitiesId;
        public float ratings;
        public void AddAchimevent(Achimevent a)
        {
            achimevents.Add(a);
        }
        public void DeleteAchimevent(int aId)
        {
            foreach (Achimevent a in achimevents)
            {
                if (a.GetId() == aId)
                {
                    achimevents.Remove(a);
                    return;
                }
            }
        }
        public void PostActivity(Activity act)
        {
            activitiesId.Add(act.GetId());
        }
        public List<Activity> GetAllActivities()//Database
        {
            throw new NotImplementedException();
        }
        public List<Review> GetAllReviews()//Database
        {
            throw new NotImplementedException();
        }
    }
    public class GameMap : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.ToTable("Games");
            builder.HasKey(g => g.id);

            builder.Property(g => g.producerId).IsRequired();
            builder.Property(g => g.title).IsRequired().HasMaxLength(50);
            builder.Property(g => g.description).IsRequired().HasMaxLength(1000);
            builder.Property(g => g.reviewId).IsRequired();
            builder.Property(g => g.activitiesId).IsRequired();
            builder.Property(g => g.ratings).IsRequired();
            builder.Property(g => g.id).ValueGeneratedOnAdd();


        }
    }


}
