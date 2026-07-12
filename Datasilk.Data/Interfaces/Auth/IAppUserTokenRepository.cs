using Datasilk.Data.Entities.Auth;

namespace Datasilk.Data.Interfaces.Auth
{
    public interface IAppUserTokenRepository
    {
        Task<AppUserTokens> Add(AppUserTokens token);
        Task<AppUserTokens> FindByTokenIP(string token, string ip);
        Task<bool> IsTokenUnique(string token);
        Task ExtendRefreshToken(AppUserTokens token);
    }
}
