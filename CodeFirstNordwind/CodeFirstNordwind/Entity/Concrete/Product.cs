using CodeFirstNordwind.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNordwind.Entity.Concrete
{
    public class Product : BaseEntity<int>
    {
        [Key]
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int SuplierID { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitInStock { get; set; }
        public short UnitsOnOrder { get; set; }
        public short ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public override DateTime CreateTime { get; set; }
        public ICollection<Order_Detail> Order_Details { get; set; }
        public Supplier Suppliers { get; set; }
        public Category Categories { get; set; }
    }
}
