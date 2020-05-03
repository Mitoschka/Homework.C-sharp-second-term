using System;

namespace Task_4._1
{
    /// <summary>
    /// Class with implementation exception
    /// </summary>
    [Serializable]
    public class NullException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NullException"/> class.
        /// </summary>
        public NullException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public NullException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        /// <param name="inner">Inner exception.</param>
        public NullException(string message, Exception inner)
            : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullException"/> class.
        /// </summary>
        /// <param name="info">Sarialization information.</param>
        /// <param name="context">Streaming context.</param>
        protected NullException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
    }

}
