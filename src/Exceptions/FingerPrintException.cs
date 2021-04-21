using Plexo.Models.Common;
using Plexo.Models.Exceptions;
namespace Plexo.Models.Exceptions
{
    public class FingerprintException : ResultCodeException
    {
        public FingerprintException(params (string language, string message)[] errormessages) : base(
            ResultCodes.InvalidFingerprint, errormessages)
        {
        }
    }
}
