using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using webapi.Entities;

namespace webapi.Data
{
    public class DataContext : IdentityDbContext<AppUser, AppRole,int,
        IdentityUserClaim<int>,AppUserRole, IdentityUserLogin<int>,
        IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        //contructor that will be called when a classed is called
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Entities.AppUser> Users { get; set; }
        public DbSet<Entities.Book> Books { get; set; }
       // public RoleManager<AppRole> roleManager;
       // public UserManager<AppUser> userManager;
        protected override async void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AppUser>()
                .HasMany(ur => ur.UserRoles)
                .WithOne(u => u.User)
                .HasForeignKey(u => u.UserId)
                .IsRequired();
            builder.Entity<AppRole>()
            .HasMany(ur => ur.UserRoles)
            .WithOne(u => u.Role)
            .HasForeignKey(u => u.RoleId)
            ;



      //      var dbInitializer = new DbInitializer(builder);
       //    dbInitializer.Seed(builder);




        }
    }
}