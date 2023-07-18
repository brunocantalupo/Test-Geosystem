using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Zone
    {
        public int Id { get; set; }
        public int AditionalMountZone { get; set; } //representa el porcentaje de aumento a los servicios --> precio del servicio = costoServicio * (montoZona / 100)
        public string Name { get; set; }
        public int IdInfrastructure { get; set; }

    }
}
