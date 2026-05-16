using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.Application.Exceptions
{
    public class UnauthorizedException : BaseException
    {
        public UnauthorizedException(string message) : base(message, (int)System.Net.HttpStatusCode.Unauthorized)
        {

            {
            }
        } 
    }

}
