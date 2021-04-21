using System.Runtime.Serialization;

namespace Plexo.Models.Common
{
    [DataContract]
    public class PublicKeyInfo
    {
        [DataMember] public string Fingerprint { get; set; }

        [DataMember] public string Key { get; set; }
    }
}
