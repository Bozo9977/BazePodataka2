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
    public interface IZaposleni
    {
        [OperationContract]
        ZaposleniIM Login(string ime, string prezime);
        [OperationContract]
        List<ZaposleniIM> GetZaposleni();
        [OperationContract]
        bool AddZaposleni(ZaposleniIM zaposleni);
        [OperationContract]
        bool DeleteZaposleni(int idZaposlenog);
        [OperationContract]
        bool ChangeZaposleni(ZaposleniIM zaposleniToChange);
    }
}
