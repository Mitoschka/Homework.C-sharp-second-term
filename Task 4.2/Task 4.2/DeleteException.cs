using System;

namespace Task_4._2
{
    /// <summary>
    /// Class with implementation exception to delete
    /// </summary>
    [Serializable]
    public class DeleteException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteException"/> class.
        /// </summary>
        public DeleteException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public DeleteException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        /// <param name="inner">Inner exception.</param>
        public DeleteException(string message, Exception inner)
        : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteException"/> class.
        /// </summary>
        /// <param name="info">Sarialization information.</param>
        /// <param name="context">Streaming context.</param>
        protected DeleteException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context)
        : base(info, context)
        {
        }
    }
}
