using System.Runtime.Serialization;
using Plexo.Models;

namespace Plexo.Models
{
    [DataContract]
    public class ServerSignedCallback<T> : SignedObject<T>
    {
    }
}
