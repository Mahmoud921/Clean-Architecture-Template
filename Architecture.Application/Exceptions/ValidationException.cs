using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.Application.Exceptions
{
    public class ValidationException:BaseException
    {
        public IEnumerable<string> Errors { get; }
        public ValidationException(IEnumerable<string> errors) : base("Validation Faild", (int)System.Net.HttpStatusCode.BadRequest)
        {

            {
                Errors = errors;
            }
        }
    }
}
