using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Ling.Identity.Interfaces.Repositories;
using Ling.Identity.Models;

namespace Ling.Identity.Interfaces.Services
{
    public interface IUserService: IUserRepository
    {
        Task<User> AutoProvisionUserAsync(string provider, string userId, List<Claim> claims);
        Task<bool> ValidateCredentialsAsync(string username, string password);
        Task<User> FindByExternalProviderAsync(string provider, string userId);
    }
}