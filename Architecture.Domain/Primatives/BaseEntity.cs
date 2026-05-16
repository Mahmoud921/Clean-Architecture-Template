using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.Domain.Primatives
{
    public class BaseEntity: AuditableEntity
    {
        public Guid Id { get; set; }
    }
}
