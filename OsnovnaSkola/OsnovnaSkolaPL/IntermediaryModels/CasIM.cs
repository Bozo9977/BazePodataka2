using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OsnovnaSkolaPL.IntermediaryModels
{
    [DataContract]
    public class CasIM
    {
        [DataMember]
        public int Id_casa { get; set; }
        [DataMember]
        public string pocetak { get; set; }
        [DataMember]
        public string kraj { get; set; }
        [DataMember]
        public System.DateTime datum { get; set; }
        [DataMember]
        public Nullable<int> OblastId_oblasti { get; set; }
        [DataMember]
        public int ZaposleniId_zaposlenog { get; set; }
    }
}
