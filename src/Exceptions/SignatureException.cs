using Plexo.Models.Common;

namespace Plexo.Models.Exceptions
{
    public class SignatureException : ResultCodeException
    {
        public SignatureException(params (string language, string message)[] errormessages) : base(
            ResultCodes.InvalidSignature, errormessages)
        {
        }
    }
}
