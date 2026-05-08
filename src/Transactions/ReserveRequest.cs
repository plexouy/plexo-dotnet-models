using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class ReserveRequest : PaymentRequest
    {
        [DataMember] public long ExpirationUTC { get; set; } //Must be included
    }
}
