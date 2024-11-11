using System.Runtime.Serialization;

namespace Plexo.Models
{
    public class ExpressCheckoutSplitRequest
    {
        [DataMember]
        public Authorization AuthorizationData { get; set; }

        [DataMember]
        public SplitRequest PaymentData { get; set; }
    }
}
