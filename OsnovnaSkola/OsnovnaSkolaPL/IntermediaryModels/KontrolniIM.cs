using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OsnovnaSkolaPL.IntermediaryModels
{
    [DataContract]
    public class KontrolniIM: KontrolnaTackaIM
    {
        [DataMember]
        public System.DateTime datum_odrzavanja { get; set; }
    }
}
