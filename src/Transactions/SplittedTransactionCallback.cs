using System.Runtime.Serialization;

namespace Plexo.Models
{
    public class SplittedTransactionCallback : SplittedTransaction, IClientCallBack
    {
        [DataMember]
        public string Client { get; set; }
    }
}
