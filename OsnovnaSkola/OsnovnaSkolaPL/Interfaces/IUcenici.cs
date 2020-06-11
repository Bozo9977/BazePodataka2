using OsnovnaSkolaPL.IntermediaryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OsnovnaSkolaPL.Interfaces
{
    [ServiceContract]
    public interface IUcenici
    {
        [OperationContract]
        bool AddUcenik(UcenikIM newUcenik);
        [OperationContract]
        List<UcenikIM> GetIcenici();
        [OperationContract]
        bool ChangeUcenik(UcenikIM ucenik);
        [OperationContract]
        bool DeleteUcenik(int id);
    }
}
