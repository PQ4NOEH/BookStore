using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Domain
{
    public interface IAggregateRoot<T> : IEntity<T>
    {
    }
}
