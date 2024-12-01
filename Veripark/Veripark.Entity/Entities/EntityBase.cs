using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veripark.Entity.Entities
{
    public abstract class EntityBase : IEntityBase
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public bool Silindi { get; set; }
    }
}