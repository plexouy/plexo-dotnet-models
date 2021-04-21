using System.Runtime.Serialization;
using Plexo.Models.Common;

namespace Plexo.Models.Common
{
    [DataContract]
    public class ServerSignedCallback<T> : SignedObject<T>
    {
    }
}
