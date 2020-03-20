using System;

namespace Task_4._1
{
    [Serializable]
    public class NullException : Exception
    {
        public NullException() { }
        public NullException(string message) : base(message) { }
        public NullException(string message, Exception inner)
        : base(message, inner) { }
        protected NullException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context)
        : base(info, context) { }
    }

}
