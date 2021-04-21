using System.Runtime.Serialization;

namespace Plexo.Models.Commerces
{
    [DataContract]
    public class CommerceIdRequest
    {
        [DataMember] public int CommerceId { get; set; }
    }
}
