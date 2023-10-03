using Microsoft.AspNetCore.Identity;
using webapi.Entities;

namespace webapi.Interface
{
    public interface IDataInitializer
    {
        Task SeedData(UserManager<AppUser> userMnaager,RoleManager<AppRole> roleManager);
    }
}
