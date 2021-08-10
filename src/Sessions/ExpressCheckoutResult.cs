using System.Runtime.Serialization;

namespace Plexo.Models
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
