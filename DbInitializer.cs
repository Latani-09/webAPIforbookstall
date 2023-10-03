using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Data;
using webapi.Entities;

namespace webapi
{
    public class DbInitializer 
    {
       
            private readonly ModelBuilder _builder;
       // private readonly UserManager<AppUser> _usermanager;
       // private readonly RoleManager<AppRole> _rolemanager;

        public DbInitializer(ModelBuilder modelBuilder){

             _builder = modelBuilder;
            }
   
        public async Task Seed(ModelBuilder builder)
        {
           
                string userdataJSON = System.IO.File.ReadAllText("User_data.json");
                List<AppUser> users= JsonConvert.DeserializeObject<List<AppUser>>(userdataJSON);
            var roles = new List<AppRole>
            {
                new AppRole{  Id=1, Name="member" },
                 new AppRole{Id=2, Name="Admin" },
                  new AppRole{Id=3, Name="Moderator" }
            };

               //  _builder.Entity<AppUser>().HasData(user);
             // _builder.Entity<AppUser>().HasOne<AppRole>("member");                    }
            foreach (var role in roles)
            {
                builder.Entity<AppRole>().HasData(role);

                //await _builder.Entity<AppRole>().HasData(role);
                // await _rolemanager.CreateAsync(role);
            }
            foreach (var user in users)
            {

                builder.Entity<AppUser>().HasData(user);
             //   await _usermanager.CreateAsync(user, "Password");
              //  await _usermanager.AddToRoleAsync(user, "member");
            }
        }
    }
}

