using System.Runtime.Serialization;

namespace Plexo.Models.Commerces
{
    [DataContract]
    public class Commerce
    {
        [DataMember] public int CommerceId { get; set; }

        [DataMember] public string Name { get; set; }
    }
}
