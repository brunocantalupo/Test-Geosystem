using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class AditionalService : Service
    {
        public virtual List<Plan_Service> plans { get; set; }

        public virtual List<Infrastructure_AdService> infraestructures { get; set; }

    }
}
