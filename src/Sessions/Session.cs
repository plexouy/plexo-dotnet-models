using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class Session
    {
        [DataMember] public string Id { get; set; }

        [DataMember] public string Uri { get; set; }

        [DataMember] public long ExpirationUTC { get; set; }
    }
}
