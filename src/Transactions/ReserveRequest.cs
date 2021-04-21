using System.Runtime.Serialization;
using Plexo.Models.Transactions;

namespace Plexo.Models.Transactions
{
    [DataContract]
    public class ReserveRequest : PaymentRequest
    {
        [DataMember] public long ExpirationUTC { get; set; } //Must be included
    }
}
