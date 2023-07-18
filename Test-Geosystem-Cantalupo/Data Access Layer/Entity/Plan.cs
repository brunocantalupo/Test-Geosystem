using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Plan
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public int IdBaseService { get; set; }
        public virtual List<Plan_Service> services { get; set; }
    }
}
