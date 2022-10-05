using DatingApp.Entities;

namespace DatingAPP.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
