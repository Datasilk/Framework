using Datasilk.Data.Entities.Auth;

namespace Datasilk.Data.Interfaces.Auth
{
    public interface IAppRoleRepository
    {
        Task<IEnumerable<AppRole>> GetAll();
        Task<AppRole> GetById(int id);
        Task<AppRole> GetByName(string name);
    }
}
