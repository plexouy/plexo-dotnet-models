using System.Runtime.Serialization;
using Plexo.Models;

namespace Plexo.Models
{
    [DataContract]
    public class TimeLimit
    {
        [DataMember] public int SecondsLeft;

        [DataMember] public FieldType RequirementAfterTimeLimit { get; set; }
    }
}
