using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caliburn.Micro;
using System.Collections.ObjectModel;
using EventAggregatorDemo.Messages;

namespace EventAggregatorDemo.ViewModels
{
    public class NumberFourViewModel : BaseViewModel, IHandle<MessageForNumberFour>, IHandle<MessageForEvenNumbers>
    {
        public NumberFourViewModel()
        {
            IoC.Get<IEventAggregator>().Subscribe(this);
        }

        #region IHandle<MessageForNumberFour> Members

        public void Handle(MessageForNumberFour message)
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
