using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ChatServer.Database
{
    public class BloggingContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=Chat;Username=postgres;Password=database");
    }

    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
    
    
}