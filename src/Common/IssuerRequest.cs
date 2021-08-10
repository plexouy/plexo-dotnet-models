using System.Runtime.Serialization;
using Plexo.Models;

namespace Plexo.Models
{
    [DataContract]
    public class IssuerRequest<T> : IssuerRequest
    {
        [DataMember] public T Request { get; set; }
    }

    [DataContract]
    public class IssuerRequest
    {
        [DataMember] public string Issuer { get; set; }
    }
}
