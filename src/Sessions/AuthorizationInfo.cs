using System.Runtime.Serialization;
using Plexo.Models;

namespace Plexo.Models
{
    [DataContract]
    public class AuthorizationInfo
    {
        [DataMember] public AuthorizationType Type { get; set; }

        [DataMember] public string MetaReference { get; set; }
    }
}
