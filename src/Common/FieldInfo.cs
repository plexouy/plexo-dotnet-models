using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class FieldInfo
    {
        [DataMember] public string LabelName { get; set; }

        [DataMember] public FieldType FieldType { get; set; }

        [DataMember] public bool Required { get; set; }
    }
}
