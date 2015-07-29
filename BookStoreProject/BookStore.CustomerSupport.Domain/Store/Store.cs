using BookStore.Core.Domain;
using System;

namespace BookStore.CustomerSupport.Domain.Store
{
    public class Store : IAggregateRoot<Guid>
    {
        public void ChangeAddres(Address newAddress)
        {
            throw new NotImplementedException();
        }

        public void ChangeName(string Name)
        {
            throw new NotImplementedException();
        }

        public IIdentity<Guid> Identity
        {
            get { throw new NotImplementedException(); }
        }
    }
}
