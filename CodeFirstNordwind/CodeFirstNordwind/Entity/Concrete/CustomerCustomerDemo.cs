using CodeFirstNordwind.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNordwind.Entity.Concrete
{
    public class CustomerCustomerDemo:BaseEntity<int>
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int CustomerTypeID { get; set; }
        public Customer Customers { get; set; }
        public CustomerDemograpgic CustomerDemograpgics { get; set; }
        public override DateTime CreateTime { get;set; }
    }
}
