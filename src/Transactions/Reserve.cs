using System.Runtime.Serialization;
using Plexo.Models.Common;

namespace Plexo.Models.Transactions
{
    [DataContract]
    public class Reserve : Reference
    {
        [DataMember] public bool Commit { get; set; }
    }
}
