using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public class ProductionPlan: BaseEntity
    {

        public int ItemId { get; set; }

        public virtual Item Item { get; set; }

        public int Quantity { get; set; }

        public int Shifts { get; set; }

        public int  OperationPlanId { get; set; }

        public virtual OperationPlan OperationPlan { get; set; }
    }
}
