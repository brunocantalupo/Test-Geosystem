using Entity;

namespace Test_Geosystem_Cantalupo.DAL
{
    public class ZoneDAO
    {
        public double getAdionalMountServiceByZoneId(int idZone)
        {
            // SELECT AditionalMountZone FROM zone WHERE Id= idZone
        }

        public List<Infrastructure_AdService> getEnabledServicesByInfrastructureId(int idInfrastucture, int idService)
        {
            // SELECT * FROM infrastructure_service WHERE infrastructure_service.IdInfrastructure == idInfrastructure and infrastructure_service == idService
        }

        public Zone getZoneById(int idZone)
        {
            // SELECT * FROM zone WHERE zona.id == idZone
        }
    }
}
