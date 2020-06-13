using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OsnovnaSkolaPL.IntermediaryModels
{
    [DataContract]
    public class DomaciIM: KontrolnaTackaIM
    {
        [DataMember]
        public System.DateTime dan_zadavanja { get; set; }
        [DataMember]
        public System.DateTime dan_predaje { get; set; }
    }
}
