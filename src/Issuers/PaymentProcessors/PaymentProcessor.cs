using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class PaymentProcessor
    {
        [DataMember]
        public string Acquirer { get; set; }

        [DataMember]
        public List<CommerceField> Fields { get; set; }
    }

}
