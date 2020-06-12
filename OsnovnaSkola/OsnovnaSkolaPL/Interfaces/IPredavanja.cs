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
    public interface IPredavanja
    {
        [OperationContract]
        bool AddPredavanjeForZaposleni(/*ZaposleniIM zaposleni,*/ PredavanjeIM predavanje);
        [OperationContract]
        List<PredavanjeIM> GetPredavanjaForZaposleni(ZaposleniIM zaposleni);
        [OperationContract]
        bool ChangePredavanje(PredavanjeIM predavanje);
        [OperationContract]
        bool DeletePredavanje(PredavanjeIM predavanje);
    }
}
