using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caliburn.Micro;
using System.Collections.ObjectModel;

namespace EventAggregatorDemo.ViewModels
{
    public abstract class BaseViewModel : PropertyChangedBase
    {
        private ObservableCollection<String> messagesRecieved;

        public ObservableCollection<String> MessagesRecieved
        {
            get
            {
                if (messagesRecieved == null)
                {
                    messagesRecieved = new ObservableCollection<string>();
                }

                return messagesRecieved;
            }
        }



        protected void AddMessage(string message)
        {

            MessagesRecieved.Add(message);
            NotifyOfPropertyChange(() => MessagesRecieved);
        }

    }
}
