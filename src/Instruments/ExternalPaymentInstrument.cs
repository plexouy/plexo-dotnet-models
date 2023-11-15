using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class ExternalPaymentInstrument
    {
        [DataMember]
        public PaymentInstrument PaymentInstrument { get; set; }

        [DataMember]
        public string URL3DS { get; set; }
    }
}
