using System.Runtime.Serialization;
using Plexo.Models.Common;

namespace Plexo.Models.Common
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
