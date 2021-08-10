using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class CommerceRequest
    {
        [DataMember] public string Name { get; set; }
    }
}
