using System.Runtime.Serialization;

namespace Plexo.Models
{
    [DataContract]
    public class TimeLimit
    {
        [DataMember] public int SecondsLeft { get; set; }

        [DataMember] public FieldType RequirementAfterTimeLimit { get; set; }
    }
}
