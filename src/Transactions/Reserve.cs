using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class Reserve : Reference
    {
        [DataMember] public bool Commit { get; set; }
        [DataMember] public decimal? FinalAmount { get; set; }
    }
}
