using System.Runtime.Serialization;
using Plexo.Models;

namespace Plexo.Models
{
    [DataContract]
    public class CodeRequest
    {
        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public CodeAction Action { get; set; }

        [DataMember]
        public string IssuerReferenceId { get; set; }

        [DataMember]
        public decimal? ReturnAmount { get; set; }
    }
}
