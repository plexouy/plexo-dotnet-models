using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class ServerSignedCallback<T> : SignedObject<T>
    {
    }
}
