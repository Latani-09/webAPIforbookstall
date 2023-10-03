using Microsoft.AspNetCore.Identity;
using webapi.Entities;

namespace webapi.Interface
{
    public interface ITokenService
    {
         Task<string> createToken(AppUser user);
    }
}
