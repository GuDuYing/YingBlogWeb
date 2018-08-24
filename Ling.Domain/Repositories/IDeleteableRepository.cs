using System.Threading.Tasks;
using Ling.Domain.Models;

namespace Ling.Domain.Repositories
{
    public interface IDeleteableRepository<TDomainEntity, TKey>: IRepository<TDomainEntity, TKey>
        where TDomainEntity : DomainEntity<TKey>, IAggregateRoot
    {
        Task DeleteAsync(TKey id);
    }
}