using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Domain
{
    public class DomainException : Exception
    {
        public  readonly int ExceptionId;
        public DomainException(int exceptionID):base()
        {
            ExceptionId = exceptionID;
        }

        public DomainException(int exceptionID, string message)
            : base(message)
        {
            ExceptionId = exceptionID;
        }
    }
}
