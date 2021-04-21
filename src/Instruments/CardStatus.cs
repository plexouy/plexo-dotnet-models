using System.Runtime.Serialization;

namespace Plexo.Models.Instruments
{
    [DataContract]
    public enum CardStatus
    {
        [EnumMember] Ok,
        [EnumMember] WarningExpirationInLessThanOneMonth,
        [EnumMember] Expired,
        [EnumMember] Disabled,
        [EnumMember] WaitingForConfirmation
    }
}
