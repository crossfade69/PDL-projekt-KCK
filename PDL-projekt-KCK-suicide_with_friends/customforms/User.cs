using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace customforms
{
    public class User : Account
    {
        public int id;
        public string nick;
        public string name;
        public string surname;
        public bool inGame;
        public List<int> friendsId;
        public List<int> ownedGameId;
        public List<int> ownedItemsId;
        public DateTime userSince;
        public User(string nick,string name,string surname,DateTime userSince,int id)
        {
            this.nick = nick;
            this.name = name;
            this.surname = surname;
            this.userSince = userSince;
            this.id = id;
        }
        public void PostReviews(Review review)
        {

        }
        public void DeleteItem()
        {

        }
        public void ChangeName(string newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                name = newName;
            }
        }

        public void ChangeSurname(string newSurname)
        {
            if (!string.IsNullOrEmpty(newSurname))
            {
                surname = newSurname;
            }
        }

        public void ChangeNick(string newNick)
        {
            if (!string.IsNullOrEmpty(newNick))
            {
                nick = newNick;
            }
        }

        public void AddFriend(int friendId)
        {
            if (!friendsId.Contains(friendId))
            {
                friendsId.Add(friendId);
            }
        }

        public void RemoveFriend(int friendId)
        {
            if (friendsId.Contains(friendId))
            {
                friendsId.Remove(friendId);
            }
        }

        public void AddOwnedGame(int gameId)
        {
            if (!ownedGameId.Contains(gameId))
            {
                ownedGameId.Add(gameId);
            }
        }

        public void RemoveOwnedGame(int gameId)
        {
            if (ownedGameId.Contains(gameId))
            {
                ownedGameId.Remove(gameId);
            }
        }

        public void AddOwnedItem(int itemId)
        {
            if (!ownedItemsId.Contains(itemId))
            {
                ownedItemsId.Add(itemId);
            }
        }

        public void RemoveOwnedItem(int itemId)
        {
            if (ownedItemsId.Contains(itemId))
            {
                ownedItemsId.Remove(itemId);
            }
        }



    }
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(a => a.id);

            builder.Property(u => u.name).IsRequired().HasMaxLength(50);
            builder.Property(u => u.surname).IsRequired().HasMaxLength(50);
            builder.Property(u => u.inGame).IsRequired();
            builder.Property(u => u.friendsId).IsRequired();
            builder.Property(u => u.ownedGameId).IsRequired();
            builder.Property(u => u.ownedItemsId).IsRequired();
            builder.Property(u => u.userSince).IsRequired();
            builder.Property(u => u.id).ValueGeneratedOnAdd();
        }
    }
}