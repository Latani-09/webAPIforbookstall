using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using webapi.Entities;

namespace webapi
{
    public class SeedData { 

    // private readonly UserManager<AppUser> _usermanager;
    // private readonly RoleManager<AppRole> _rolemanager;

  
        public static async Task Seed(UserManager<AppUser> userManager,RoleManager<AppRole> roleManager)
        {
            if (await userManager.Users.AnyAsync()) return;

            string userdataJSON = System.IO.File.ReadAllText("User_data.json");
            List<AppUser> users = JsonConvert.DeserializeObject<List<AppUser>>(userdataJSON);
            Console.WriteLine(users.Count);
            var roles = new List<AppRole> {

                new AppRole{   Name="member" },
                 new AppRole{ Name="Admin" },
                  new AppRole{ Name="Moderator" }
            };

            //  _builder.Entity<AppUser>().HasData(user);
            // _builder.Entity<AppUser>().HasOne<AppRole>("member");                    }
            if (!roleManager.Roles.Any())
            {
                foreach (var role in roles)
                {
                    await roleManager.CreateAsync(role);

                    //await _builder.Entity<AppRole>().HasData(role);
                    // await _rolemanager.CreateAsync(role);
                }
            }
            foreach (var user in users)
            {

                Console.WriteLine(user.UserName);
                user.UserName = user.UserName.ToLower();
               
                   var result=await userManager.CreateAsync(user,"Pa$sw0rd");
                  
                  
            }
            
        }

    }
}
