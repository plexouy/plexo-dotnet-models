﻿using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class ExtendedCredit
    {
        [DataMember] public decimal Amount { get; set; }

        [DataMember] public int CurrencyId { get; set; }
    }
}
