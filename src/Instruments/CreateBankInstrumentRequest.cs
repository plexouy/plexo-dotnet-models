using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class CreateBankInstrumentRequest
    {
        [DataMember] public int IssuerId { get; set; }

        [DataMember] public AuthorizationInfo User { get; set; }

        [DataMember] public Dictionary<FieldType, string> InstrumentData { get; set; }
    }
}
