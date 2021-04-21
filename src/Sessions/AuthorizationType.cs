using System.Runtime.Serialization;

namespace Plexo.Models.Sessions
{
    [DataContract]
    public enum AuthorizationType
    {
        [EnumMember] ClientReference,
        [EnumMember] OAuth,
        [EnumMember] Anonymous
    }
}
