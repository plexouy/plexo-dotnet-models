using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Plexo.Models
{
    [DataContract]
    public class IssuerPaymentProcessor
    {
        [DataMember]
        public int IssuerId { get; set; } // 4
        [DataMember]
        public string Name { get; set; } // Mastercard
        [DataMember]
        public List<PaymentProcessor> PaymentProcessors { get; set; } // ej fiserv, oca, cybersource
    }
}
