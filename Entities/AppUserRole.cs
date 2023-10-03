using Microsoft.AspNetCore.Identity;

namespace webapi.Entities
{
    public class AppUserRole :IdentityUserRole<int>
        //to manage relationship between users and role insted of entity frame workt o manage itr
    {
        public AppUser User { get; set; }
        public AppRole Role { get; set; }
    }
}
