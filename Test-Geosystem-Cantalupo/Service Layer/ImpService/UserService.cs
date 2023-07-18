using Entity;
using Test_Geosystem_Cantalupo.DAL;
using Test_Geosystem_Cantalupo.Data_Access_Layer.DAO;
using Test_Geosystem_Cantalupo.Service_Layer.Service;

namespace Test_Geosystem_Cantalupo.Service_Layer.ImpService
{
    public class UserService : IUserService
    {

        private PlanDAO _planDAO;
        private ServiceDAO _serviceDAO;
        private ZoneDAO _zoneDAO;
        private PromoDAO _promoDAO;

        public UserService(PlanDAO planDAO, ServiceDAO serviceDAO, ZoneDAO zoneDAO, PromoDAO promoDAO)
        {
            _planDAO = planDAO;
            _serviceDAO = serviceDAO;
            _zoneDAO = zoneDAO;
            _promoDAO = promoDAO;
        }

        public double getTotalMountToPay(Client client)
        {
            double totalMountToPay = 0;
            Plan plan = _planDAO.getPlanByClientId(client.Id);
            List<Plan_Service> plan_services = _planDAO.getAditionalServicesPlan(plan.Id);
            foreach (Plan_Service ps in plan_services)
            {
                totalMountToPay += _serviceDAO.getMountAditionalServiceByServiceId(ps.IdAdService);
            }
            totalMountToPay += _serviceDAO.getMountBaseServiceByServiceId(plan.IdBaseService);
            totalMountToPay *= _zoneDAO.getAdionalMountServiceByZoneId(client.IdZone) / 100;
            Promo promo = getPromo(plan_services);
            if (promo != null)
            {
                totalMountToPay -= totalMountToPay * (promo.discount / 100);
            }

            return totalMountToPay;
        }

        private Promo getPromo(List<Plan_Service> plan_services)
        {
            List<Promo> promos = getApplicablePromotions(plan_services);
            return getBestPromo(promos);
        }

        private Promo getBestPromo(List<Promo> promos)
        {
            Promo best_promo = null;
            int minimumApply = -1;
            foreach (Promo p in promos)
            {
                if (p.minimum > minimumApply)
                {
                    minimumApply = p.minimum;
                    best_promo = p;
                }
            }
            return best_promo;
        }

        private List<Promo> getApplicablePromotions(List<Plan_Service> plan_services)
        {
            List<Promo> promos = _promoDAO.getPromos();
            return promos.Where(x => x.minimum <= plan_services.Count()).ToList();
        }

        public bool checkServiceInInfrastructure(Client client, AditionalService adService)
        {
            Zone zone = _zoneDAO.getZoneById(client.IdZone);
            return (_zoneDAO.getEnabledServicesByInfrastructureId(zone.IdInfrastructure, adService.Id).FirstOrDefault() != null);
        }

    }
}
