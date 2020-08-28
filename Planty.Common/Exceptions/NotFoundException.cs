namespace Planty.Common.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class NotFoundException : Exception
    {
        public NotFoundException()
            : base("Entity not found")
        {
        }

        public NotFoundException(string message)
            : base(message)
        {
        }

        public NotFoundException(Type type)
            : base($"Entity of type {type?.ToString()} not found")
        {
        }

        public NotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected NotFoundException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
