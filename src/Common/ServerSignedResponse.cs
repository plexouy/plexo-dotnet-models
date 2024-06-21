using System.Runtime.Serialization;

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
