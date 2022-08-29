using CodeFirstNordwind.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNordwind.Entity.Concrete
{
    public class Order_Detail : BaseEntity<int>
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public double Discount { get; set; }
        public override DateTime CreateTime { get; set; }
        public Order Orders { get; set; }
        public Product Products { get; set; }
    }
}
