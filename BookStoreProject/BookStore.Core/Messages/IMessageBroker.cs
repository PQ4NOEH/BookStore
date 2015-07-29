using BookStore.Core.CQRS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Messages
{
    public interface IMessageBroker
    {
        void Push(IEvent @event);
    }
}
