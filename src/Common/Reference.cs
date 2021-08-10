using System.Runtime.Serialization;
using Plexo.Models;

namespace Plexo.Models
{
    [DataContract]
    public class Reference
    {
        [DataMember]
        public ReferenceType Type { get; set; }

        [DataMember]
        public string MetaReference { get; set; }
    }
}
