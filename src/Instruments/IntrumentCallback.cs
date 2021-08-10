using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class IntrumentCallback : InstrumentWithMetadata
    {
        [DataMember] public string SessionId { get; set; }

        [DataMember] public string Client { get; set; }

        [DataMember] public ActionType Action { get; set; }
    }
}
