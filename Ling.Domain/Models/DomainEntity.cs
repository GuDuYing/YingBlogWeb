using System;

namespace Ling.Domain.Models
{
    public class DomainEntity<T>
    {
        private T uniqueId;

        public T Id
        {
            get
            {
                return uniqueId;
            }
        }

        protected DomainEntity(T id)
        {
            if (id.Equals(default(T)))
            {
                throw new ArgumentOutOfRangeException(nameof(id), "The identifier cannot be equal to the default value of the type.");
            }

            uniqueId = id;
        }

        public override bool Equals(object obj)
        {
            var entity = obj as DomainEntity<T>;

            if (entity == null)
            {
                return false;
            }
            else
            {
                return uniqueId.Equals(entity.Id);
            }
        }

        public static bool operator ==(DomainEntity<T> x, DomainEntity<T> y)
        {
            if ((object)x == null)
            {
                return (object)y == null;
            }

            if ((object)y == null)
            {
                return (object)x == null;
            }

            return x.Id.Equals(y.Id);
        }

        public static bool operator !=(DomainEntity<T> x, DomainEntity<T> y)
        {
            return !(x == y);
        }

        public override int GetHashCode()
        {
            return uniqueId.GetHashCode();
        }
    }
}