using System.Runtime.Serialization;
using System.ServiceModel;

namespace ModsonDbAccessorService.BL
{
    [ServiceContract]
    public interface IModsonDbAccessorService
    {
        [OperationContract]
        string GetUsers(string connectionString);
    }
}
