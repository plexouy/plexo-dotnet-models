﻿using System.Runtime.Serialization;
using Plexo.Models.Common;

namespace Plexo.Models.Common
{
    [DataContract]
    public class ServerSignedRequest<T> : SignedObject<T>
    {
    }
}
