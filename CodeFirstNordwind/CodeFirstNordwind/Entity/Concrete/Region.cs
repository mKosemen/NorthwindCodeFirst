using CodeFirstNordwind.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNordwind.Entity.Concrete
{
    public class Region : BaseEntity<int>
    {
        public override int ID { get; set; }
        public override DateTime CreateTime { get; set; }
        public int RegionDescription { get; set; }
        public ICollection<Territory> Territories { get; set; }
    }
}
