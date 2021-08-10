using System.Runtime.Serialization;
using Plexo.Models;

namespace Plexo.Models
{
    [DataContract]
    public class SignedObject<T>
    {
        [DataMember] public StateObject<T> Object { get; set; }

        [DataMember] public string Signature { get; set; }
    }

    [DataContract]
    public class SignedObject
    {
        [DataMember] public StateObject Object { get; set; }

        [DataMember] public string Signature { get; set; }
    }
}
