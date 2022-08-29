using CodeFirstNordwind.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNordwind.Entity.Concrete
{
    public class EmployeeTerritory : BaseEntity<int>
    {
        public override DateTime CreateTime { get; set; }
        public int EmployeeID { get; set; }
        public int TerritoryID { get; set; }

        public Employee Employees { get; set; }
        public Territory Territories { get; set; }

    }
}
