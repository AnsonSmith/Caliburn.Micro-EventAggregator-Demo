using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventAggregatorDemo.Messages
{
    public class MessageForNumberFour
    {
        public string Message { get; set; }

        public MessageForNumberFour(string message)
        {
            Message = message;
        }
    }
}
