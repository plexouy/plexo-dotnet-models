using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Plexo.Models.ThreeDS
{
    [DataContract]
    public class ThreeDSSession
    {
        [DataMember]
        public string SessionId { get; set; }

        [DataMember]
        public string RedirectUrl { get; set; }

        [DataMember]
        public bool IsRequired { get; set; }
    }
}
