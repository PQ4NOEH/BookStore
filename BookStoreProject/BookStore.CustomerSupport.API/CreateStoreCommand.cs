using BookStore.Core.CQRS;

namespace BookStore.CustomerSupport.API
{
    public class CreateStoreCommand : ICommand
    {
        public string Street { get; set; }
        public int Number { get; set; }
        public string FlatNumber { get; set; }
        public string StoreName { get; set; }
    }
}
