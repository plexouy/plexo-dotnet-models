using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class TransactionCallback : Transaction
    {
        [DataMember] public string Client { get; set; }
    }
}
