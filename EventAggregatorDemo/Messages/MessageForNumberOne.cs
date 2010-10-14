using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventAggregatorDemo.Messages
{
    public class MessageForNumberOne
    {
        public string Message { get; set; }

        public MessageForNumberOne(string message)
        {
            Message = message;
        }
    }
}
