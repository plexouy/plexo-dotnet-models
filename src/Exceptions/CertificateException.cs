using Plexo.Models.Common;
using Plexo.Models.Exceptions;
namespace Plexo.Models.Exceptions
{
    public class CertificateException : ResultCodeException
    {
        public CertificateException(params (string language, string message)[] errormessages) : base(
            ResultCodes.SystemError, errormessages)
        {
        }
    }
}
