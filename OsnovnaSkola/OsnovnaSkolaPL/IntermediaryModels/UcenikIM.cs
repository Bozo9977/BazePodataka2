using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OsnovnaSkolaPL.IntermediaryModels
{
    [DataContract]
    public class UcenikIM
    {
        [DataMember]
        public int Id_ucenika { get; set; }
        [DataMember]
        public string ime { get; set; }
        [DataMember]
        public string prezime { get; set; }
        [DataMember]
        public int OdeljenjeId_odeljenja { get; set; }
    }
}
