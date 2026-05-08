using System.Runtime.Serialization;

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
