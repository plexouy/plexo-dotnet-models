using System.Runtime.Serialization;
using Plexo.Models.Instruments;

namespace Plexo.Models.Instruments
{
    [DataContract]
    public class InstrumentWithMetadata
    {
        [DataMember] public PaymentInstrument PaymentInstrument { get; set; }

        [DataMember] public string OptionalMetadata { get; set; }
    }
}
