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
    public interface IPredmeti
    {
        [OperationContract]
        List<PredmetIM> GetPredmeti();
        [OperationContract]
        bool AddPredmet(PredmetIM predmet);
        [OperationContract]
        List<OblastIM> GetOblastiForPRedmet(int id);
    }
}
