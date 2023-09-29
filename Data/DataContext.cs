using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace webapi.Data
{
    public class DataContext : DbContext
    {
        //contructor that will be called when a classed is called
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Entities.AppUser> Users { get; set; }
        public DbSet<Entities.Movie> Movies { get; set; }
    }
}