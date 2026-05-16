using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.Domain.Primatives
{
    public class AuditableEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

    }
}
