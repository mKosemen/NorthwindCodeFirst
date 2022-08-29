using CodeFirstNordwind.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNordwind.Entity.Concrete
{
    public class Category: BaseEntity<int>
    {
        public int ID { get; set; }
        public override DateTime CreateTime { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
