using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventAggregatorDemo.Messages
{
    public class MessageForOddNumbers
    {
        public string Message { get; set; }

        public MessageForOddNumbers(string message)
        {
            Message = message;
        }
    }
}
