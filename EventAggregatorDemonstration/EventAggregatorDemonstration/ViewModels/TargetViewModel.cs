using EventAggregatorDemonstration.Events;
using EventAggregatorDemonstration.Models;
using MainEventManager;
using Microsoft.Practices.Prism.PubSubEvents;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAggregatorDemonstration.ViewModels
{
    public class TargetViewModel : ModelBase
    {
        readonly IEventAggregator _aggregator = AggregatorList.AggregatorFactory;

        public string messageText;
        public string MessageText
        {
            get
            {
                return messageText;
            }
            set {
                messageText = value;
                OnPropertyChanged("messageText");
            }
        }

        public TargetViewModel()
        {
            MessageText = "Default";
            _aggregator.GetEvent<DataMessagePostedEvent>().Subscribe(GetDataMessage);
        }
        private void GetDataMessage(Message messageObj)
        {
            MessageText = messageObj.Text;
        }

    
    }
}
