using Entity;

namespace Test_Geosystem_Cantalupo.Service_Layer.Service
{
    public interface IUserService
    {

        double getTotalMountToPay(Client client);
        bool checkServiceIsInfrastructure(Client client, AditionalService adService);
    }
}
