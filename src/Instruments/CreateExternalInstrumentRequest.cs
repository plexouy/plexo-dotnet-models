using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class CreateExternalInstrumentRequest
    {
        [DataMember]
        public int IssuerId { get; set; }
        [DataMember]
        public Authorization AuthorizationData { get; set; }
        [DataMember]
        public Dictionary<FieldType, string> InstrumentData { get; set; }
    }
}
