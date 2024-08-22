using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Plexo.Models.Instruments
{
    [DataContract]
    public class PaymentInstrumentExtended
    {
        [DataMember]
        public string BINInformation { get; set; }
        [DataMember]
        public string Country { get; set; }
    }
}
