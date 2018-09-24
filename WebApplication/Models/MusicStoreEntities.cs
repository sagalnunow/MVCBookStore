using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication.Models
{
    public class MusicStoreEntities : DbContext
    {
        public DbSet<Album> Album { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}