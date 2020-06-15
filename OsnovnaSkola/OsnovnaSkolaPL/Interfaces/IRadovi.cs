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
    public interface IRadovi
    {
        [OperationContract]
        List<RadiIM> GetRadoviForKontrolnaTacka(int idZaposlenog, int idKT);

        [OperationContract]
        bool ChangeRad(RadiIM rad);
    }
}
