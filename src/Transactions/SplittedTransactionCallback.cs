using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Plexo.Models
{
    public class SplittedTransactionCallback : SplittedTransaction, IClientCallBack
    {
        [DataMember]
        public string Client { get; set; }
    }
}
