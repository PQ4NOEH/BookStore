using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Serialization
{
    public interface ITextSerializer
    {
        String Serialize(object obj);
        object Deserialize(string obj);
        T Deserialize<T>(string obj);
    }
}
