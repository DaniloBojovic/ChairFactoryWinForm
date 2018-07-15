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
    public class WorkOperationRepository: Repository<WorkOperation>
    {
        public WorkOperationRepository(AppDbContext context) : base(context)
        {
        }

        public List<WorkOperation> GetWorkOperationsForItem(int itemId)
        {
            return Context.WorkOperations.Where(o => o.Item.Id == itemId || o.Item.Part.Id == itemId).ToList();
        }

        public double GetOperationTimeForItemId(int itemId)
        {
            return Context.WorkOperations.Where(o => o.Item.Id == itemId || o.Item.PartId == itemId)
                .Sum(o => o.TimeNeeded * o.Quantity);
        }

        public List<WorkOperation> GetTechnicalProcessForItem(int itemId)
        {
            return Context.WorkOperations.Where(o => o.ItemId == itemId || o.Item.PartId == itemId).Include(i => i.Machine).ToList();
        }
    }
}
