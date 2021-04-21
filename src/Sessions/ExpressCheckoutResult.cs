using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Plexo.Models.Instruments;
using Plexo.Models.Transactions;

namespace Plexo.Models.Sessions
{
    [DataContract]
    public class ExpressCheckoutResult
    {
        [DataMember]
        public IntrumentCallback IntrumentCallback { get; set; }

        [DataMember]
        public TransactionCallback Transaction { get; set; }
    }
}
