using System.Runtime.Serialization;

namespace WebTests.Excepciones
{
    public class ParseExcepcion : Exception
    {
        public ParseExcepcion():base() { }

        public ParseExcepcion(string? message) : base(message)
        {
        }

        public ParseExcepcion(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ParseExcepcion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
