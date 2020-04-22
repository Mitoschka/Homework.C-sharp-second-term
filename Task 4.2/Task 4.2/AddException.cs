using System;

namespace Task_4._2
{
    /// <summary>
    /// Class with implementation exception
    /// </summary>
    [Serializable]
    public class AddException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddException"/> class.
        /// </summary>
        public AddException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public AddException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        /// <param name="inner">Inner exception.</param>
        public AddException(string message, Exception inner)
            : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddException"/> class.
        /// </summary>
        /// <param name="info">Sarialization information.</param>
        /// <param name="context">Streaming context.</param>
        protected AddException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
    }
}
