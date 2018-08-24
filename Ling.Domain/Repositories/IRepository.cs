using System.Threading.Tasks;
using Ling.Domain.Models;

namespace Ling.Domain.Repositories
{
    public interface IRepository<TDomainEntity, TKey> where TDomainEntity : DomainEntity<TKey>, IAggregateRoot
    {
        Task<TDomainEntity> GetAsync(TKey id);
    }
}