using System.Runtime.Serialization;
using Plexo.Models;

namespace Plexo.Models
{
    [DataContract]
    public class DeleteInstrumentRequest : AuthorizationInfo
    {
        [DataMember] public string InstrumentToken { get; set; }
    }
}
