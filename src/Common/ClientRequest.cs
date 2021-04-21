using System.Runtime.Serialization;
using Plexo.Models.Common;

namespace Plexo.Models.Common
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
