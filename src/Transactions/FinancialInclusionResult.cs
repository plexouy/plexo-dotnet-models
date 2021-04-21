using System.Runtime.Serialization;
using Plexo.Models.Common;

namespace Plexo.Models.Transactions
{
    [DataContract]
    public class FinancialInclusionResult
    {
        [DataMember] public bool IsApplied { get; set; }

        [DataMember] public decimal ReturnAmount { get; set; }

        [DataMember] public InclusionType LawNumber { get; set; }
    }
}
