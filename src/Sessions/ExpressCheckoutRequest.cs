using System.Runtime.Serialization;
using Plexo.Models.Sessions;
using Plexo.Models.Transactions;

namespace Plexo.Models.Sessions
{
    [DataContract]
    public class ExpressCheckoutRequest
    {
        [DataMember]
        public Authorization AuthorizationData { get; set; }

        [DataMember]
        public PaymentRequest PaymentData { get; set; }
    }
}
