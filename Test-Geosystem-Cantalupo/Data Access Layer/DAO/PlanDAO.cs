using Entity;

namespace Test_Geosystem_Cantalupo.DAL
{
    public class PlanDAO
    {

        public Plan getPlanByClientId(int idClient)
        {
            // SELECT * FROM plan WHERE plan.IdClient == idClient

        }

        public List<Plan_Service> getAditionalServicesPlan(int idPlan)
        {
            // SELECT * FROM plan_service WHERE plan_service.IdPlan  == idPlan
        }
    }
}
