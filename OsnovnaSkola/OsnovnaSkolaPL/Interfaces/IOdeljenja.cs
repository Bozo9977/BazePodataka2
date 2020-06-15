using OsnovnaSkola;
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
    public interface IOdeljenja
    {
        [OperationContract]
        bool AddOdeljenje(OdeljenjeIM odeljenje);
        [OperationContract]
        List<OdeljenjeIM> GetOdeljenja();
        [OperationContract]
        bool ChangeOdeljenje(OdeljenjeIM odeljenje);
        [OperationContract]
        bool AddRazredni(OdeljenjeIM odeljenje, ZaposleniIM zaposleni);
        [OperationContract]
        bool AddNastavnik(OdeljenjeIM odeljenje, ZaposleniIM zaposleni);
        [OperationContract]
        Odeljenje FindById(int id);
        [OperationContract]
        bool DeleteOdeljenje(OdeljenjeIM odeljenje);
        [OperationContract]
        bool ValidateUciteljExistance(int id);
        [OperationContract]
        List<OdeljenjeIM> GetOdeljenjeByRazred(short razred);
        [OperationContract]
        List<OdeljenjeIM> GetOdeljenjaForZaposleni(int zaposleniID);
    }
}
