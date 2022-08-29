using CodeFirstNordwind.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNordwind.Entity.Concrete
{
    public class Shipper : BaseEntity<int>
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public override DateTime CreateTime { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
