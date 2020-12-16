using System;
namespace AccountController.Entities.DomainException
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
