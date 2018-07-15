using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public class Machine:BaseEntity
    {

        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
