using BookStore.Core.CQRS;
using BookStore.Core.Messages;
using BookStore.CustomerSupport.Domain.Store;
using System;

namespace BookStore.CustomerSupport.API
{
    public class StoreAPI : ICommandHandler<CreateStoreCommand>
    {
        readonly IStoreRepository _storeRepository;
        readonly IMessageBroker _messageBroker;
        public StoreAPI(IStoreRepository storeRepository, IMessageBroker messageBroker)
        {
            _storeRepository = storeRepository;
            _messageBroker = messageBroker;
        }

        public void Execute(CreateStoreCommand comand)
        {
            Store newStore = new Store();
            newStore.ChangeName(comand.StoreName);
            Address storeAddress = new Address{
                Street = comand.Street,
                FlatNumber = new FlatNumber(comand.FlatNumber),
                Number = comand.Number
            };
            newStore.ChangeAddres(storeAddress);

            _storeRepository.Save(newStore);
            _messageBroker.Push(new ShopCreatedEvent(comand));
        }
    }
}
