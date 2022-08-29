using CodeFirstNordwind.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNordwind.Entity.Concrete
{
    public class CustomerDemograpgic : BaseEntity<int>
    {
        public int ID { get; set; }
        public override DateTime CreateTime { get; set; }
        public string CustomerDesc { get; set; }
        public ICollection<CustomerCustomerDemo> customerCustomerDemos { get; set; }
    }
}
