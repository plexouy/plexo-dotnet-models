﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using Plexo.Models;

namespace Plexo.Models
{
    [DataContract]
    public class IssuerData
    {
        [DataMember] public int IssuerId { get; set; }

        [DataMember] public int CommerceId { get; set; }

        [DataMember] public Dictionary<FieldType, string> Metadata { get; set; }

        [DataMember]
        public int? PaymentFacilitatorCommerceId { get; set; }

        [DataMember]
        public int? PaymentFacilitatorId { get; set; }

        [DataMember]
        public string? PaymentProcessorId { get; set; }
    }
}
