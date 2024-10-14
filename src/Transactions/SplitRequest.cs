using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Plexo.Models
{
    public class SplitRequest : PaymentRequest
    {
        [DataMember]
        public string SplitClientReferenceId { get; set; }
        [DataMember]
        public Item Item { get; set; }
        [DataMember]
        public int SplitCurrencyId { get; set; }
        [DataMember]
        public FinancialInclusion SplitFinancialInclusion { get; set; }
        [DataMember]
        public int SplitCommerceId { get; set; }
        [DataMember]
        public string SplitOptionalMetadata { get; set; }
        [DataMember]
        public PaymentInstrumentInput SplitPaymentInstrumentInput { get; set; }
        [DataMember]
        public string CallbackURL { get; set; }
    }
}
