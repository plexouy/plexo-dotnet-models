using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public enum TransactionType
    {
        [EnumMember] Reserve,
        [EnumMember] Purchase,
        [EnumMember] Cancel,
        [EnumMember] Refund
    }
}
