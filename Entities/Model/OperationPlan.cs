using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public sealed class OperationPlan:BaseEntity
    {
        public string Client { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime Deadline { get; set; }

        public ICollection<ProductionPlan> ProductionPlans { get; set; }

        public OperationPlan()
        {
            this.ProductionPlans = new List<ProductionPlan>();
        
            
        }
    }
}
