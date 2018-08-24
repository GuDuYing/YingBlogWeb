using System.Threading.Tasks;
using Ling.Domain.Models;

namespace Ling.Domain.Repositories
{
    public interface IUpdateableRepository<TDomainEntity, TKey> : IRepository<TDomainEntity, TKey>
        where TDomainEntity : DomainEntity<TKey>, IAggregateRoot
    {
        Task UpdateAsync(TDomainEntity entity);
    }
}