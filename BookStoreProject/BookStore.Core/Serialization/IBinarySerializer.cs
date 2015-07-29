using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Serialization
{
    public interface IBinarySerializer
    {
        byte[] Serialize(object obj);
        object Deserialize(byte[] obj);
        T Deserialize<T>(byte obj);
    }
}
