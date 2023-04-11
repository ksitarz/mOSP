using mOSP.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mOSP.Application.Contracts.Persistence
{
    public interface IUserRepository : IAsyncRepository<User>
    {
        Task<bool> EmailInUse(string email);
        Task<User> GetUserByEmail(string email);
    }
}
