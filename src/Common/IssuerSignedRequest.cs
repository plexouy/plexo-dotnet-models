using System.Runtime.Serialization;
using Plexo.Models;

namespace Plexo.Models
{
    [DataContract]
    public class IssuerSignedRequest<T> : SignedObject<IssuerRequest<T>>
    {
    }

    [DataContract]
    public class IssuerSignedRequest : SignedObject<IssuerRequest>
    {
    }
}
