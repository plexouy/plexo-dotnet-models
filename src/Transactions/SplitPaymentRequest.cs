using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Plexo.Models
{
    [DataContract]
    public class SplitPaymentRequest
    {
        [DataMember]
        public PaymentRequest PaymentRequest { get; set; }
        [DataMember]
        public SplitRequest SplitRequest { get; set; }
    }
}
