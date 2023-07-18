using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Infrastructure_AdService
    {
        public int Id { get; set; }
        public int IdInfrastructure { get; set; }
        public Infrastructure Infrastructure { get; set; }
        public int IdAdService { get; set; }
        public AditionalService AdService { get; set; }

    }
}
