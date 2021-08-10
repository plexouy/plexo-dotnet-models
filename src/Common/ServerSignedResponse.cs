using System.Runtime.Serialization;
using Plexo.Models;

namespace Plexo.Models
{
    [DataContract]
    public class ServerSignedResponse<T> : SignedObject<ServerResponse<T>>
    {
    }

    [DataContract]
    public class ServerSignedResponse : SignedObject<ServerResponse>
    {
    }
}
