﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using Plexo.Models;

namespace Plexo.Models
{
    [DataContract]
    public class TransactionCursor
    {
        [DataMember] public int Start { get; set; }

        [DataMember] public int TotalCount { get; set; }

        [DataMember] public List<Transaction> Transactions { get; set; }
    }
}
