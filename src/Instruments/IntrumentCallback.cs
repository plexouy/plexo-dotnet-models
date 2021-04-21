using System.Runtime.Serialization;
using Plexo.Models.Instruments;
using Plexo.Models.Sessions;

namespace Plexo.Models.Instruments
{
    [DataContract]
    public class IntrumentCallback : InstrumentWithMetadata
    {
        [DataMember] public string SessionId { get; set; }

        [DataMember] public string Client { get; set; }

        [DataMember] public ActionType Action { get; set; }
    }
}
