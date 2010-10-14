using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using Caliburn.Micro;
using EventAggregatorDemo.Messages;

namespace EventAggregatorDemo.ViewModels
{
    public class NumberOneViewModel : BaseViewModel, IHandle<MessageForNumberOne>, IHandle<MessageForOddNumbers>
    {
        public NumberOneViewModel()
        {
            IoC.Get<IEventAggregator>().Subscribe(this);
        }

        #region IHandle<MessageForOddNumbers> Members

        public void Handle(MessageForOddNumbers message)
        {
            AddMessage(message.Message);
        }

        #endregion

        #region IHandle<MessageForNumberOne> Members

        public void Handle(MessageForNumberOne message)
        {
            AddMessage(message.Message);
        }

        #endregion

       
    }
}
