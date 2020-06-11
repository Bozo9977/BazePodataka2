using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OsnovnaSkolaPL.IntermediaryModels
{
    [DataContract]
    public class ZaposleniIM
    {
        [DataMember]
        public int Id_zaposlenog { get; set; }
        [DataMember]
        public string ime { get; set; }
        [DataMember]
        public string prezime { get; set; }
        [DataMember]
        public string zvanje { get; set; }
        [DataMember]
        public bool Ucitelj { get; set; }
    }
}
