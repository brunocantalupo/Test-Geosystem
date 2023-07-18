using Entity;

namespace Test_Geosystem_Cantalupo.DAL
{
    public class ServiceDAO
    {
        public AditionalService getAditionalServiceById(int idAditionalService)
        {
            // SELECT * FROM aditional_service WHERE aditional_service.id == idAditionalService
        }
        public double getMountAditionalServiceByServiceId(int idAditionalService)
        {
            // SELECT mountService FROM aditional_service WHERE aditional_service.id == idAditionalService
        }

        public double getMountBaseServiceByServiceId(int idBaseService)
        {
            // SELECT mountService FROM base_service WHERE base_service.id == idBaseService
        }
        }
    }
}
