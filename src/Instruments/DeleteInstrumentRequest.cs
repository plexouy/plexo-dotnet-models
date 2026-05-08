using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class DeleteInstrumentRequest : AuthorizationInfo
    {
        [DataMember] public string InstrumentToken { get; set; }
    }
}
