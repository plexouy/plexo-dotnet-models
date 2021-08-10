using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class WebFormSettings
    {
        [DataMember] public UIOptions UI { get; set; } // Opciones generales de UI
        [DataMember] public ExpressCheckoutSettings ExpressCheckout { get; set; }  // Opciones especificas de ExpressCheckout
    }

}
