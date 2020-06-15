using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OsnovnaSkolaPL.IntermediaryModels
{
    [DataContract]
    public class RadiIM
    {
        [DataMember]
        public int Kontrolna_tackaId_kontrolne_tacke { get; set; }
        [DataMember]
        public int UcenikId_ucenika { get; set; }
        [DataMember]
        public int ZaposleniId_zaposlenog { get; set; }
        [DataMember]
        public short ocena { get; set; }
        [DataMember]
        public string zadatak { get; set; }
    }
}
