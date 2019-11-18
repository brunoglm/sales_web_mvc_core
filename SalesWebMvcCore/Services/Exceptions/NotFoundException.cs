using System;

namespace SalesWebMvcCore.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message)
        {
        } 
    }
}
