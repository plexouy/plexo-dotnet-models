using System.Runtime.Serialization;

namespace Plexo.Models.Commerces
{
    [DataContract]
    public class CommerceRequest
    {
        [DataMember] public string Name { get; set; }
    }
}
