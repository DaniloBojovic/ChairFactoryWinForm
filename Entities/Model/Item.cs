using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public class Item: BaseEntity
    {
        public string Name { get; set; }

        public string Material { get; set; }

        public int? PartId { get; set; }

        public virtual Item Part { get; set; }
        public virtual ICollection<Item> Parts { get; set; }
       
        
        public override string ToString()
        {
            return this.Name;
        }
        
    }
}
