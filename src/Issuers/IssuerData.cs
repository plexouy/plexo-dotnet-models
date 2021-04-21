using System.Collections.Generic;
using System.Runtime.Serialization;
using Plexo.Models.Common;

namespace Plexo.Models.Issuers
{
    [DataContract]
    public class IssuerData
    {
        [DataMember] public int IssuerId { get; set; }

        [DataMember] public int CommerceId { get; set; }

        [DataMember] public Dictionary<FieldType, string> Metadata { get; set; }
    }
}
