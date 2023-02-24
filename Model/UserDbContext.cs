using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DemoDeploy.Model
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> tblDetail { get; set; }

    }
}
