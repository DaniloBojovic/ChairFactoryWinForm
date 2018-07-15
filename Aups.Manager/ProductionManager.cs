using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Repositories;
using Entities.Model;

namespace Aups.Manager
{
    public class ProductionManager
    {
        private readonly UnitOfWork _unitOfWork;

        public ProductionManager(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public DateTime CalculateDeadlineForOperationPlan(OperationPlan operationPlan, int shifts)
        {
            // TODO: Implement this method!!!
            
            return DateTime.Today.AddDays(10);
        }

        public double CalculateParallelTimeForOperationPlan(OperationPlan operationPlan)
        {
            if (operationPlan.ProductionPlans.Count < 1)
            {
                return 0;
            }
            return 0;
        }

        public double CalculateProductionTimeForOperationPlane(OperationPlan operationPlan)
        {
            return operationPlan.ProductionPlans.Count == 0 ? 0 : operationPlan.ProductionPlans.Sum(productionPlan => productionPlan.Quantity * _unitOfWork.WorkOperations.GetOperationTimeForItemId(productionPlan.ItemId));
        }

 
    }
}
