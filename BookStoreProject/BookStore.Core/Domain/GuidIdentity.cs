using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Domain
{
    public class GuidIdentity: IIdentity<Guid>
    {
        public Guid Value { get; set; }
        public bool Same(object obj)
        {
            var objCasted = obj as Guid?;
            return objCasted != null && Value.Equals(objCasted.Value);
        }
    }
}
