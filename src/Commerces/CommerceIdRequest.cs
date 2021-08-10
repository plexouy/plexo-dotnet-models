using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class CommerceIdRequest
    {
        [DataMember] public int CommerceId { get; set; }
    }
}
