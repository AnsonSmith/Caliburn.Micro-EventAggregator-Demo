using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventAggregatorDemo.Messages
{
    public class MessageForNumberTwo
    {
        public string Message { get; set; }


        public MessageForNumberTwo(string message)
        {
            Message = message;
        }
    }
}
