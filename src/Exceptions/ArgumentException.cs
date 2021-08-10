namespace Plexo.Models
{
    public class ArgumentException : ResultCodeException
    {
        public ArgumentException(params (string language, string message)[] errormessages) : base(
            ResultCodes.ArgumentError, errormessages)
        {
        }
    }
}
