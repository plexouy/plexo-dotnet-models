using System.Runtime.Serialization;
using Plexo.Models.Common;

namespace Plexo.Models.Common
{
    [DataContract]
    public class AmountLimit
    {
        [DataMember] public decimal Amount { get; set; }

        [DataMember] public decimal ExtendedAmount { get; set; }

        [DataMember] public Currency Currency { get; set; }

        [DataMember] public bool SupportsExtendedLimit { get; set; }
    }
}
