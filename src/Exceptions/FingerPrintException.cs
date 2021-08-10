namespace Plexo.Models
{
    public class FingerprintException : ResultCodeException
    {
        public FingerprintException(params (string language, string message)[] errormessages) : base(
            ResultCodes.InvalidFingerprint, errormessages)
        {
        }
    }
}
