using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingPlt.Domain.Exceptions
{
    public class DomainException : Exception
    {
        public DomainException(string message) : base(message) { }
    }

    public class NotFoundException : DomainException
    {
        public NotFoundException(string name, object key)
            : base($"Entity '{name}' with key '{key}' was not found.") { }
    }

    public class UnauthorizedException : DomainException
    {
        public UnauthorizedException(string message = "Unauthorized access.") : base(message) { }
    }
}
