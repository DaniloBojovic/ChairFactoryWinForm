using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public class WorkOperation: BaseEntity
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public double TimeNeeded { get; set; }

        public int ItemId { get; set; }

        public Item Item { get; set; }

        public int MachineId { get; set; }

        public Machine Machine { get; set; }

        public int Quantity { get; set; }
    }
}
