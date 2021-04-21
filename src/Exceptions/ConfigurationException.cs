using Plexo.Models.Common;
using Plexo.Models.Exceptions;
namespace Plexo.Models.Exceptions
{
    public class ConfigurationException : ResultCodeException
    {
        public ConfigurationException(params (string language, string message)[] errormessages) : base(
            ResultCodes.SystemError, errormessages)
        {
        }
    }
}
