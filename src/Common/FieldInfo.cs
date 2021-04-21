using System.Runtime.Serialization;
using Plexo.Models.Common;

namespace Plexo.Models.Common
{
    [DataContract]
    public class FieldInfo
    {
        [DataMember] public string LabelName { get; set; }

        [DataMember] public FieldType FieldType { get; set; }

        [DataMember] public bool Required { get; set; }
    }
}
