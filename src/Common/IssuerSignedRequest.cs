using System.Runtime.Serialization;

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
