using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpcWebServer.Models
{
    public class ServerDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public ServerDbContext(DbContextOptions options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder.UseMySql(ConfigurationManager.ConnectionStrings["mysql"].ConnectionString);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
