using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class ExpressCheckoutSettings
    {
        [DataMember] public DisplayOptions Display { get; set; }
        [DataMember] public BuiltInPagesOptions BuiltInPages { get; set; }
    }
}
