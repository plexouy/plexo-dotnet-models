using System.Runtime.Serialization;
using Plexo.Models.Common;

namespace Plexo.Models.Common
{
    [DataContract]
    public class ClientResponse : ServerResponse
    {
        [DataMember] public string Client { get; set; }
    }
}
