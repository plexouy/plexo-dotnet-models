using System.Runtime.Serialization;
using Plexo.Models.Transactions;

namespace Plexo.Models.Transactions
{
    [DataContract]
    public class TransactionCallback : Transaction
    {
        [DataMember] public string Client { get; set; }
    }
}
