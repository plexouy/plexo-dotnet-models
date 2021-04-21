using System.Runtime.Serialization;

namespace Plexo.Models.Common
{
    [DataContract]
    public enum ReferenceType
    {
        [EnumMember] PlexoTransactionId,
        [EnumMember] ClientPurchaseReferenceId,
        [EnumMember] ClientCancelReferenceId,
        [EnumMember] ClientReserveReferenceId
    }
}
