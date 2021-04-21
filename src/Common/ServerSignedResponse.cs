using System.Runtime.Serialization;
using Plexo.Models.Common;

namespace Plexo.Models.Common
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
