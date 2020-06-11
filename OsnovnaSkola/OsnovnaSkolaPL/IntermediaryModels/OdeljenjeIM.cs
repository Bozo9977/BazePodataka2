using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OsnovnaSkolaPL.IntermediaryModels
{
    [DataContract]
    public class OdeljenjeIM
    {
        [DataMember]
        public int Id_odeljenja { get; set; }
        [DataMember]
        public short razred { get; set; }
        [DataMember]
        public string Razredni { get; set; }
    }
}
