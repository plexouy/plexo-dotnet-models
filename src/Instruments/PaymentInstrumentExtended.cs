using System.Runtime.Serialization;

namespace Plexo.Models.Instruments
{
    [DataContract]
    public class PaymentInstrumentExtended
    {
        [DataMember]
        public string BinInformation { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string UniqueIDInformation { get; set; }
    }
}
