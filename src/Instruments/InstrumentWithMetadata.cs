using System.Runtime.Serialization;
using Plexo.Models;

namespace Plexo.Models
{
    [DataContract]
    public class InstrumentWithMetadata
    {
        [DataMember] public PaymentInstrument PaymentInstrument { get; set; }
        [DataMember] public string OptionalMetadata { get; set; }
        [DataMember] public string OptionalBIN { get; set; }
        [DataMember] public string OptionalUniqueID { get; set; }
    }
}
