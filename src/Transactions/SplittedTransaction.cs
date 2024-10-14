using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Plexo.Models
{
    [DataContract]
    public class SplittedTransaction
    {
        [DataMember]
        public Transaction PurchaseTransaction { get; set; }
        [DataMember]
        public Transaction SplitTransaction { get; set; }
        [DataMember]
        public TransactionResult Status { get; set; }
    }
}
