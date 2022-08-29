using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNordwind.Entity.Abstract
{
    public abstract class BaseEntity<T>
    {
        public virtual T ID { get; set; }
        public abstract DateTime CreateTime { get; set; }
    }
}
