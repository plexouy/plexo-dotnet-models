using System.Runtime.Serialization;
using Plexo.Models.Common;

namespace Plexo.Models.Transactions
{
    [DataContract]
    public class CancelRequest : Reference
    {
        [DataMember] public string ClientReferenceId { get; set; }
    }
}
