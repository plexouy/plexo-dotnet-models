using System.Runtime.Serialization;
using Plexo.Models.Sessions;

namespace Plexo.Models.Instruments
{
    [DataContract]
    public class DeleteInstrumentRequest : AuthorizationInfo
    {
        [DataMember] public string InstrumentToken { get; set; }
    }
}
