using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class BuiltInPagesOptions
    {
        [DataMember] public bool? CheckoutSuccessPage { get; set; }
        [DataMember] public bool? CheckoutErrorPage { get; set; }
    }
}
