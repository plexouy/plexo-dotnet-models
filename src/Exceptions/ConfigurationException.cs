namespace Plexo.Models
{
    public class ConfigurationException : ResultCodeException
    {
        public ConfigurationException(params (string language, string message)[] errormessages) : base(
            ResultCodes.SystemError, errormessages)
        {
        }
    }
}
