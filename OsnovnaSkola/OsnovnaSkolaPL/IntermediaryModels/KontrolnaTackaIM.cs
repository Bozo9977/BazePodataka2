using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OsnovnaSkolaPL.IntermediaryModels
{
    [DataContract]
    public class KontrolnaTackaIM
    {
        [DataMember]
        public int Id_kontrolne_tacke { get; set; }
        [DataMember]
        public string zadatak { get; set; }
        [DataMember]
        public int ZaposleniId_zaposlenog { get; set; }
        [DataMember]
        public DateTime datum { get; set; }
        [DataMember]
        public bool Domaci { get; set; }
    }
}
