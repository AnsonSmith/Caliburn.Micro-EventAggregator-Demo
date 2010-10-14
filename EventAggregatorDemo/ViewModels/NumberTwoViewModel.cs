using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caliburn.Micro;
using System.Collections.ObjectModel;
using EventAggregatorDemo.Messages;

namespace EventAggregatorDemo.ViewModels
{
    public class NumberTwoViewModel : BaseViewModel, IHandle<MessageForNumberTwo>, IHandle<MessageForEvenNumbers>
    {
        public NumberTwoViewModel()
        {
            IoC.Get<IEventAggregator>().Subscribe(this);
        }


        #region IHandle<MessageForNumberTwo> Members

        public void Handle(MessageForNumberTwo message)
        {
            AddMessage(message.Message);
        }

        #endregion

        #region IHandle<MessageForEvenNumbers> Members

        public void Handle(MessageForEvenNumbers message)
        {
            AddMessage(message.Message);
        }

        #endregion
    }
}
