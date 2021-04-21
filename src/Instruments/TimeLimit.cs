using System.Runtime.Serialization;
using Plexo.Models.Common;

namespace Plexo.Models.Instruments
{
    [DataContract]
    public class TimeLimit
    {
        [DataMember] public int SecondsLeft;

        [DataMember] public FieldType RequirementAfterTimeLimit { get; set; }
    }
}
