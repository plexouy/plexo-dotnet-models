using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class BlacklistRequest
    {
        [DataMember]
        public string InstrumentToken { get; set; }

        [DataMember]
        public string Reason { get; set; }

        [DataMember]
        public string OptionalUserName { get; set; }
    }
}
