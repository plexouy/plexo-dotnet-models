using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class CommerceModifyRequest
    {
        [DataMember] public int CommerceId { get; set; }

        [DataMember] public string Name { get; set; }
    }
}
