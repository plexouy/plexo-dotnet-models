using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class ClientSignedResponse : SignedObject<ClientResponse>
    {
    }
}
