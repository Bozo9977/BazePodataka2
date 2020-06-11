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
    public interface IOblast
    {
        [OperationContract]
        List<OblastIM> GetAllOblast();
        [OperationContract]
        bool AddOblast(OblastIM oblast);
        [OperationContract]
        bool ChangeOblast(OblastIM oblast);
        [OperationContract]
        bool DeleteOblast(OblastIM oblast);
    }
}
