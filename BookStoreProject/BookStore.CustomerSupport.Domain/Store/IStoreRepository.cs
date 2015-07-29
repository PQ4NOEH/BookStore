using System;

namespace BookStore.CustomerSupport.Domain.Store
{
    public interface IStoreRepository
    {
        void Save(Store store);
        void Get(Guid storeId);
    }
}
