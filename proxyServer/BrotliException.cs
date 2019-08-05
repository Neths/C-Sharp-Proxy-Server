using System;
using System.IO;
using System.Runtime.Serialization;

namespace Brotli
{
    [Serializable]
    public class BrotliException : IOException
    {
        public BrotliException()
            : base(string.Empty)
        {
        }

        public BrotliException(string message)
            : base(message)
        {
        }

        public BrotliException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public BrotliException(Exception innerException)
            : base(null, innerException)
        {
        }

        protected BrotliException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}