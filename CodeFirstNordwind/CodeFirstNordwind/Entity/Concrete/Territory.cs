using CodeFirstNordwind.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNordwind.Entity.Concrete
{
    public class Territory : BaseEntity<int>
    {
        public int ID { get; set; }
        public override DateTime CreateTime { get; set; }
        public string TerritortDescription { get; set; }
        public int RegionID { get; set; }
        public Region Regions { get; set; }
        public ICollection<EmployeeTerritory> EmployeeTerritories { get; set; }
    }
}
