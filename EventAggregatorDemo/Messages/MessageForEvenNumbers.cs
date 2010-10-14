using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventAggregatorDemo.Messages
{
    public class MessageForEvenNumbers
    {
        public string Message { get; set; }

        public MessageForEvenNumbers(string message)
        {
            Message = message;
        }
    }
}
