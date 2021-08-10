using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public enum AuthorizationType
    {
        [EnumMember] ClientReference,
        [EnumMember] OAuth,
        [EnumMember] Anonymous
    }
}
