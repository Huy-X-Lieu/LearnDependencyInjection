using System.Security.Principal;

namespace Chapter01Library
{
    public class SecureMessageWriter : IMessageWriter
    {
        private readonly IMessageWriter _writer;
        private readonly IIdentity _identity;

        public SecureMessageWriter(IMessageWriter writer, IIdentity identity)
        {
            if(writer == null)
                throw new ArgumentNullException("writer");
            if (identity == null)
                throw new ArgumentNullException("Identity");

            _writer = writer;
            _identity = identity;
        }

        public void Write(string message)
        {
            if (_identity.IsAuthenticated)
            {
                _writer.Write(message);
            }
        }
    }
}
