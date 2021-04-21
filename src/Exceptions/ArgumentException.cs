using Plexo.Models.Common;
using Plexo.Models.Exceptions;
namespace Plexo.Models.Exceptions
{
    public class ArgumentException : ResultCodeException
    {
        public ArgumentException(params (string language, string message)[] errormessages) : base(
            ResultCodes.ArgumentError, errormessages)
        {
        }
    }
}
