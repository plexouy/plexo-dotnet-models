namespace Plexo.Models
{
    public class MessageExpiredException : ResultCodeException
    {
        public MessageExpiredException(params (string language, string message)[] errormessages) : base(
            ResultCodes.MessageExpired, errormessages)
        {
        }
    }
}
