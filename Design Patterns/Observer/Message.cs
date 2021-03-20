using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Message
    {
        private readonly string _messageContent;

        public Message(string m)
        {
            _messageContent = m;
        }

        public string GetMessageContent()
        {
            return _messageContent;
        }
    }
}