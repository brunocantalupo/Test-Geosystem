using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Plan_Service
    {
        public int Id { get; set; }
        public int IdPlan { get; set; }

        public Plan Plan { get; set; }
        public int IdAdService { get; set; }
        public AditionalService AdService { get; set; }

    }
}
