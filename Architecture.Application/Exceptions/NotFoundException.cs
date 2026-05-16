using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Architecture.Application.Exceptions
{
    public class NotFoundException :BaseException
    {
        public NotFoundException(string message) :base(message ,(int)HttpStatusCode.NotFound)
        {
            
        }
    }
}
