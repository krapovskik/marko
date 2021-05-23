using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lab4.Models
{
    public class FriendContext : DbContext
    {
        public DbSet<Friend> friends { get; set; }

        public FriendContext() : base("DefaultConnection") { }
        
        public static FriendContext Create()
        {
            return new FriendContext();
        }
    }
}