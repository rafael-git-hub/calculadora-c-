using System;

namespace Calculadora.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException (string message) : base(message)
        {
        }
    }
}
