using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class UIOptions
    {
        [DataMember] public Dictionary<string, string> Colors { get; set; } // primary color, seconday color, background color
        [DataMember] public string Theme { get; set; } // default, default_dark
        [DataMember] public bool AutoDarkTheme { get; set; } // Cambiar de tema automaticamente segun preferencias del usuario en su explorador
        [DataMember] public string LogoURL { get; set; } // URL de Logo de 196x64
    }
}
