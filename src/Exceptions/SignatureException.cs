using Plexo.Models;

namespace Plexo.Models
{
    public class SignatureException : ResultCodeException
    {
        public SignatureException(params (string language, string message)[] errormessages) : base(
            ResultCodes.InvalidSignature, errormessages)
        {
        }
    }
}
