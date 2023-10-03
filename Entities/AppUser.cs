using Microsoft.AspNetCore.Identity;

namespace webapi.Entities
{
    public class AppUser:IdentityUser<int>  //just to tell that id is int
    {

        public string? Gender { get ; set; }
        public string? City { get; set; }
        public ICollection<AppUserRole> UserRoles { get; set; }

    }
}
