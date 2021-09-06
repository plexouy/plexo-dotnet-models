using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class TokenizationSettings
    {
        [DataMember]
        public DisplayOptions Display { get; set; }
    }

}
