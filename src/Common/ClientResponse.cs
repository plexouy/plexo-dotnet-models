using System.Runtime.Serialization;
using Plexo.Models;

namespace Plexo.Models
{
    [DataContract]
    public class ClientResponse : ServerResponse
    {
        [DataMember] public string Client { get; set; }
    }
}
