using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Infrastructure
    {
        public int Id { get; set; }
        public int SubscriberCapacity { get; set; }
        public virtual List<Infrastructure_AdService> services { get; set; }
    }
}
