using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Repositories.Generic;
using Entities.Model;

namespace Dal.Repositories
{
    public class ItemRepository: Repository<Item>
    {
        public ItemRepository(AppDbContext context) : base(context)
        {
        }

        public List<Item> GetAllFinalItems()
        {
            return Context.Items.Where(i => i.Part == null).ToList();
        }
    }
}
