using System.Runtime.Serialization;
using Plexo.Models;

namespace Plexo.Models
{
    [DataContract]
    public class TransactionCallback : Transaction
    {
        [DataMember] public string Client { get; set; }
    }
}
