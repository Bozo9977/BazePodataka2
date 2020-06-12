using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OsnovnaSkolaPL.IntermediaryModels
{
    [DataContract]
    public class PredavanjeIM
    {
        [DataMember]
        public int Id_predavanja { get; set; }
        [DataMember]
        public string opis { get; set; }
        [DataMember]
        public System.DateTime datum_odrzavanja { get; set; }
        [DataMember]
        public int OblastId_oblasti { get; set; }
        [DataMember]
        public int ZaposleniId_zaposlenog { get; set; }
    }
}
