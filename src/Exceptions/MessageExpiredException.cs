using Plexo.Models.Common;
using Plexo.Models.Exceptions;
namespace Plexo.Models.Exceptions
{
    public class MessageExpiredException : ResultCodeException
    {
        public MessageExpiredException(params (string language, string message)[] errormessages) : base(
            ResultCodes.MessageExpired, errormessages)
        {
        }
    }
}
