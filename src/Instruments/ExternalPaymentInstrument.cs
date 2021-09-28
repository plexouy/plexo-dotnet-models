using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Plexo.Models
{
    [DataContract]
    public class ExternalPaymentInstrument
    {
        [DataMember]
        public PaymentInstrument PaymentInstrument { get; set; }

        [DataMember]
        [JsonProperty("URL3DS")]
        public string Url3DS { get; set; }
    }
}
