using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Repositories.Generic;
using Entities.Model;

namespace Dal.Repositories
{
    public class ProductionPlanRepository: Repository<ProductionPlan>
    {
        public ProductionPlanRepository(AppDbContext context) : base(context)
        {
        }
    }
}
