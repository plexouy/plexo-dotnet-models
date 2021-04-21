using System.Runtime.Serialization;

namespace Plexo.Models.Transactions
{
    [DataContract]
    public enum CodeAction
    {
        [EnumMember] Query,
        [EnumMember] Pay,
        [EnumMember] Deny,
        [EnumMember] EndCancelation,
        [EnumMember] Void
    }

    [DataContract]
    public class PaymentCode
    {
        [DataMember] public string Code { get; set; }

        [DataMember] public string Url { get; set; }
    }
}
