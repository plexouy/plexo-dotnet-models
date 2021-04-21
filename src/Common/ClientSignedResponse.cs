using System.Runtime.Serialization;
using Plexo.Models.Common;

namespace Plexo.Models.Common
{
    [DataContract]
    public class ClientSignedResponse : SignedObject<ClientResponse>
    {
    }
}
