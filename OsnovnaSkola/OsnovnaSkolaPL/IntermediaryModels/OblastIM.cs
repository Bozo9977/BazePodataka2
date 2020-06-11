using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OsnovnaSkolaPL.IntermediaryModels
{
    [DataContract]
    public class OblastIM
    {
        [DataMember]
        public int Id_oblasti { get; set; }
        [DataMember]
        public string naziv { get; set; }
        [DataMember]
        public int PredmetId_predmeta { get; set; }
    }
}
