using System.Runtime.Serialization;
using Plexo.Models.Common;

namespace Plexo.Models.Common
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
