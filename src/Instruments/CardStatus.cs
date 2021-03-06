using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public enum CardStatus
    {
        [EnumMember] Ok,
        [EnumMember] WarningExpirationInLessThanOneMonth,
        [EnumMember] Expired,
        [EnumMember] Disabled,
        [EnumMember] WaitingForConfirmation,
        [EnumMember] Deleted,
        [EnumMember] AuthenticationFailed,
    }

    [DataContract]
    public enum InstrumentStatusEnum
    {
        [EnumMember]
        Created,
        [EnumMember]
        WarningExpirationInLessThanOneMonth,
        [EnumMember]
        Expired,
        [EnumMember]
        Disabled,
        [EnumMember]
        WaitingForConfirmation,
        [EnumMember]
        Deleted,
        [EnumMember]
        AuthenticationFailed
    }
}
