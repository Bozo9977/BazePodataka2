using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OsnovnaSkolaPL.IntermediaryModels
{
    [DataContract]
    public class PredmetIM
    {
        [DataMember]
        public int Id_predmeta { get; set; }
        [DataMember]
        public short razred { get; set; }
        [DataMember]
        public string naziv { get; set; }
        [DataMember]
        public short broj_oblasti { get; set; }
    }
}
