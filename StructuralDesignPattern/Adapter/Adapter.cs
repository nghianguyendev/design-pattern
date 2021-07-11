using System.Collections.Generic;
using System.Linq;

namespace Adapter
{
    internal class MessageResource
    {
        public IEnumerable<string> GetMessages()
        {
            return new List<string> {
                "One message",
                "Another message",
                "Third message"
            };
        }
    }

    internal interface IMessageProvider
    {
        IEnumerable<string> GetMessages();
    }

    internal class MessageProvider : IMessageProvider
    {
        private MessageResource _messageResource = new MessageResource();

        public IEnumerable<string> GetMessages()
        {
            return ModifyMessages(_messageResource.GetMessages());
        }

        private IEnumerable<string> ModifyMessages(IEnumerable<string> messages)
        {
            return messages.ToList().Select(x => $"From me: {x}").AsEnumerable();
        }
    }
}