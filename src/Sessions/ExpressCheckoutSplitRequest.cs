using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Plexo.Models
{
    public class ExpressCheckoutSplitRequest
    {
        [DataMember]
        public Authorization AuthorizationData { get; set; }

        [DataMember]
        public SplitRequest PaymentData { get; set; }

    }
}
