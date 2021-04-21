using System.Runtime.Serialization;
using Plexo.Models.Common;

namespace Plexo.Models.Transactions
{
    [DataContract]
    public class FinancialInclusion
    {
        [DataMember] public InclusionType Type { get; set; }

        [DataMember] public decimal TaxedAmount { get; set; }

        [DataMember] public decimal BilledAmount { get; set; }

        [DataMember] public int InvoiceNumber { get; set; }

        [DataMember] public string InvoiceNumberStr { get; set; }
    }
}
