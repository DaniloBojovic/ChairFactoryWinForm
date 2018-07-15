using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Repositories.Generic;
using Entities.Model;

namespace Dal.Repositories
{
    public class MachineRepository: Repository<Machine>
    {
        public MachineRepository(AppDbContext context) : base(context)
        {
        }
    }
}
