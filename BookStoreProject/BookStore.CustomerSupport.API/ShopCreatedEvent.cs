using BookStore.Core.CQRS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.CustomerSupport.API
{
    public class ShopCreatedEvent : IEvent
    {
        public ShopCreatedEvent(CreateStoreCommand cmd)
        {

        }
    }
}
