using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class ClientSignedRequest<T> : SignedObject<ClientRequest<T>>
    {
    }

    [DataContract]
    public class ClientSignedRequest : SignedObject<ClientRequest>
    {
    }
}
