using webapi.Entities;

namespace webapi.Interface
{
    public interface ITokenService
    {
        string createToken(AppUser user);
    }
}
