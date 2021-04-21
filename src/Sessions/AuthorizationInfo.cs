using System.Runtime.Serialization;
using Plexo.Models.Sessions;

namespace Plexo.Models.Sessions
{
    [DataContract]
    public class AuthorizationInfo
    {
        [DataMember] public AuthorizationType Type { get; set; }

        [DataMember] public string MetaReference { get; set; }
    }
}
