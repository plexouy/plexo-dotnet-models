using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class ExpressCheckoutRequest
    {
        [DataMember]
        public Authorization AuthorizationData { get; set; }

        [DataMember]
        public PaymentRequest PaymentData { get; set; }

        [DataMember]
        public bool? Disable3DS { get; set; }
    }


}
