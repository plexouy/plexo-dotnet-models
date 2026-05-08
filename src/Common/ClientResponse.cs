using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class ClientResponse : ServerResponse
    {
        [DataMember] public string Client { get; set; }
    }
}
