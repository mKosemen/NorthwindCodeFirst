﻿using CodeFirstNordwind.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNordwind.Entity.Concrete
{
    public class Supplier: BaseEntity<int>
    {
        public override int ID { get; set; }
        public override DateTime CreateTime { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string HomePage { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
