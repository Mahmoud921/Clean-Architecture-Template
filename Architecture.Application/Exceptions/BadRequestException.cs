using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.Application.Exceptions
{
    public class BadRequestException:BaseException
    {
        public BadRequestException(string message) : base(message, (int)System.Net.HttpStatusCode.BadRequest)
        {

            {

            }
        }
    }
}
