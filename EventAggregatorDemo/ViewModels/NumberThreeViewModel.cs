using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caliburn.Micro;
using System.Collections.ObjectModel;
using EventAggregatorDemo.Messages;

namespace EventAggregatorDemo.ViewModels
{
    public class NumberThreeViewModel : BaseViewModel, IHandle<MessageForNumberThree>, IHandle<MessageForOddNumbers>
    {
        public NumberThreeViewModel()
        {
            IoC.Get<IEventAggregator>().Subscribe(this);
        }

        #region IHandle<MessageForNumberThree> Members

        public void Handle(MessageForNumberThree message)
        {
            AddMessage(message.Message);
        }

        #endregion

        #region IHandle<MessageForOddNumbers> Members

        public void Handle(MessageForOddNumbers message)
        {
            AddMessage(message.Message);
        }

        #endregion
    }
}
