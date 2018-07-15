using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Repositories.Generic;
using Entities.Model;

namespace Dal.Repositories
{
    public class OperationPlanRepository: Repository<OperationPlan>
    {
        public OperationPlanRepository(AppDbContext context) : base(context)
        {
        }

        public void ClearProductionListById(int id)
        {
            var items = Context.ProductionPlans.Where(i => i.OperationPlanId == id);
            Context.ProductionPlans.RemoveRange(items);
        }

        public OperationPlan GetOperationPlanById(int id)
        {
            return Context.OperationPlans.Include(o => o.ProductionPlans).SingleOrDefault(o => o.Id == id);
        }

        public DateTime CalculateProductionDeadline(OperationPlan operationPlan)
        {
            //TODO: Implement this method
            return operationPlan.StartDate.AddDays(7);
        }
    }
}
