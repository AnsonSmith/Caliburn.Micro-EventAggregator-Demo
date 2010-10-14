namespace EventAggregatorDemo.ViewModels
{
    using Caliburn.Micro;
    using EventAggregatorDemo.Messages;

    public class ShellViewModel : PropertyChangedBase
    {

        private NumberOneViewModel numberOne;
        private NumberTwoViewModel numberTwo;
        private NumberThreeViewModel numberThree;
        private NumberFourViewModel numberFour;


        public NumberOneViewModel NumberOne
        {
            get { return numberOne; }
            set { numberOne = value; }
        }

        public NumberTwoViewModel NumberTwo
        {
            get { return numberTwo; }
            set { numberTwo = value; }
        }

        public NumberThreeViewModel NumberThree
        {
            get { return numberThree; }
            set { numberThree = value; }
        }

        public NumberFourViewModel NumberFour
        {
            get { return numberFour; }
            set { numberFour = value; }
        }

        private string currentMessage;
        public string CurrentMessage {
            get
            {
                return currentMessage;
            }
            set
            {
                currentMessage = value;
                NotifyOfPropertyChange(() => CurrentMessage);
                NotifyOfPropertyChange(() => CanMessageNumberOne);
                NotifyOfPropertyChange(() => CanMessageNumberTwo);
                NotifyOfPropertyChange(() => CanMessageNumberThree);
                NotifyOfPropertyChange(() => CanMessageNumberFour);
                NotifyOfPropertyChange(() => CanMessageEvens);
                NotifyOfPropertyChange(() => CanMessageOdds);
            }
        }

        public ShellViewModel()
        {
            numberOne = new NumberOneViewModel();
            numberTwo = new NumberTwoViewModel();
            numberThree = new NumberThreeViewModel();
            numberFour = new NumberFourViewModel();
        }

        public void MessageNumberOne()
        {
            IoC.Get<IEventAggregator>().Publish(new MessageForNumberOne(CurrentMessage));
            CurrentMessage = string.Empty;
        }

        public bool CanMessageNumberOne
        {
            get
            {
                return canSendMessage();
            }
        }


        public void MessageNumberTwo()
        {
            IoC.Get<IEventAggregator>().Publish(new MessageForNumberTwo(CurrentMessage));
            CurrentMessage = string.Empty;
        }

        public bool CanMessageNumberTwo
        {
            get
            {
                return canSendMessage();
            }
        }

        public void MessageNumberThree()
        {
            IoC.Get<IEventAggregator>().Publish(new MessageForNumberThree(CurrentMessage));
            CurrentMessage = string.Empty;
        }

        public bool CanMessageNumberThree
        {
            get
            {
                return canSendMessage();
            }
        }

        public void MessageNumberFour()
        {
            IoC.Get<IEventAggregator>().Publish(new MessageForNumberFour(CurrentMessage));
            CurrentMessage = string.Empty;
        }

        public bool CanMessageNumberFour
        {
            get
            {
                return canSendMessage();
            }
        }

        public void MessageEvens()
        {
            IoC.Get<IEventAggregator>().Publish(new MessageForEvenNumbers(CurrentMessage));
            CurrentMessage = string.Empty;
        }

        public bool CanMessageEvens
        {
            get
            {
                return canSendMessage();
            }
        }

        public void MessageOdds()
        {
            IoC.Get<IEventAggregator>().Publish(new MessageForOddNumbers(CurrentMessage));
            CurrentMessage = string.Empty;
        }

        public bool CanMessageOdds
        {
            get
            {
                return canSendMessage();
            }
        }



        private bool canSendMessage()
        {
            return !string.IsNullOrEmpty(CurrentMessage);
        }
    }
}
