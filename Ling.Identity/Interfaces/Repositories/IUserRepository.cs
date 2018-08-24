using System.Threading.Tasks;
using Ling.Domain.Repositories;
using Ling.Identity.Models;

namespace Ling.Identity.Interfaces.Repositories
{
    public interface IUserRepository: IAddableRepository<User, int>, IDeleteableRepository<User, int>, IUpdateableRepository<User, int>
    {
        Task<User> GetAsync(string username);
        Task<User> GetAsync(string username, string password);
        Task AddAsync(User entity, string password);
    }
}