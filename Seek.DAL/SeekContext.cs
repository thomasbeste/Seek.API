using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seek.DAL
{
    public class SeekContext : DbContext
    {
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Canditate> Candidates { get; set; }

        public SeekContext(string nameOrConnectionString)
            : base (nameOrConnectionString)
        {
            //force call to base, and disallow default constructor
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure Code First to ignore PluralizingTableName convention 
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
