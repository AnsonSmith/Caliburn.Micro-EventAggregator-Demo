using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventAggregatorDemo.Messages
{
    public class MessageForNumberThree
    {
        public string Message { get; set; }

        public MessageForNumberThree(string message)
        {
            Message = message;
        }
    }
}
