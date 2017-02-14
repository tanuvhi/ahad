using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ahad.Models
{
    public class EFDbContext : DbContext
    {
        public DbSet<Position> Positions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Useer> Useers { get; set; }
        public DbSet<Unit> Units { get; set; }
    }
}