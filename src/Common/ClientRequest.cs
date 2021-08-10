using System.Runtime.Serialization;
using Plexo.Models;

namespace Plexo.Models
{
    [DataContract]
    public class ClientRequest<T> : ClientRequest
    {
        [DataMember] public T Request { get; set; }
    }

    [DataContract]
    public class ClientRequest
    {
        [DataMember] public string Client { get; set; }
    }
}
