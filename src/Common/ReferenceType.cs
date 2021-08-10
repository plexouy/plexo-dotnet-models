using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public enum ReferenceType
    {
        [EnumMember] PlexoTransactionId,
        [EnumMember] ClientPurchaseReferenceId,
        [EnumMember] ClientCancelReferenceId,
        [EnumMember] ClientReserveReferenceId,
        [EnumMember] ClientRefundReferenceId
    }
}
