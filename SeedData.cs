using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using webapi.Data;
using webapi.Entities;

namespace webapi
{
    //claas to seed old data into user entity
    public class SeedData
    {
        public static async Task Seed(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {

            if (!roleManager.Roles.Any())
            {
                var roles = new List<AppRole>
                {

                new AppRole{   Name="member" },
                 new AppRole{ Name="Admin" },
                  new AppRole{ Name="Moderator" }
                };
                foreach (var role in roles)
                {
                    await roleManager.CreateAsync(role);

                }
            }

            if (!await userManager.Users.AnyAsync())
            {
                var admin = new AppUser{UserName = "admin"};
                await userManager.CreateAsync(admin, "Pa$$w0rd");
                var results = await userManager.AddToRolesAsync(admin, new[] { "Admin", "Moderator" });

                string userdataJSON = System.IO.File.ReadAllText("User_data.json");
                List<AppUser> users = JsonConvert.DeserializeObject<List<AppUser>>(userdataJSON);

                foreach (var user in users)
                {
                    user.UserName = user.UserName.ToLower();
                    await userManager.CreateAsync(user, "Pa$sw0rd");
                    await userManager.AddToRoleAsync(user, "member");

                }
            }

        }


        public static async Task SeedBook(DataContext datacontext)
        {

            if (!datacontext.Books.Any())
            {

                string bookDataJson = System.IO.File.ReadAllText("Books_data.json");
                List<Book> books = JsonConvert.DeserializeObject<List<Book>>(bookDataJson);

                foreach (var book in books)
                {

                    
                    await datacontext.AddAsync(book);
                    await datacontext.SaveChangesAsync();


                }
               
            }

        }

    }
}
