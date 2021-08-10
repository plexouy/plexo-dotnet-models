using System.Collections.Generic;
using System.Runtime.Serialization;
using Plexo.Models;

namespace Plexo.Models
{
    [DataContract]
    public class PaymentInstrumentInput
    {
        [DataMember] public string InstrumentToken { get; set; }

        [DataMember] public Dictionary<FieldType, string> NonStorableItems { get; set; }

        [DataMember] public bool UseExtendedClientCreditIfAvailable { get; set; }

        [DataMember] public Dictionary<FieldType, string> OptionalInstrumentFields { get; set; }
    }
}
