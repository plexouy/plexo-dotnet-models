using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class PaymentProcessorField
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public FieldType Type { get; set; }

        [DataMember]
        public bool Required { get; set; }
    }
}
