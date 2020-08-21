using Microsoft.EntityFrameworkCore;
using exam1_csharp.Models;

namespace login_register.Models
{ 
    // the MyContext class representing a session with our MySQL 
    // database allowing us to query for or save data
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        // the "Monsters" table name will come from the DbSet variable name
        public DbSet<User> Users { get; set; }
        public DbSet<RSVP> RSVPs {get;set;}
        public DbSet<Party> Parties{get;set;}
    }
}
