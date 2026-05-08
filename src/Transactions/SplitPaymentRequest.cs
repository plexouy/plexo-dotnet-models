using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class SplitPaymentRequest
    {
        [DataMember]
        public PaymentRequest PaymentRequest { get; set; }
        [DataMember]
        public SplitRequest SplitRequest { get; set; }
    }
}
