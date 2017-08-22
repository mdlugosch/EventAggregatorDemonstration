using EventAggregatorDemonstration.Commands;
using EventAggregatorDemonstration.Events;
using EventAggregatorDemonstration.Models;
using Microsoft.Practices.Prism.PubSubEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.ComponentModel.Composition;
using MainEventManager;

namespace EventAggregatorDemonstration.ViewModels
{
    class MainViewModel
    {

        readonly IEventAggregator _aggregator = AggregatorList.AggregatorFactory;

        public Message messageObj = new Message();
        public string MessageText
        {
            get
            {
                return messageObj.Text;
            }
            set
            {
                messageObj.Text = value;
            }
        }

        public MainViewModel()
        {
            MessageText = "Hallo Welt";
        }

        public SendCommand send;
        public SendCommand Send
        {
            get {
                if (send == null)
                {
                    send = new SendCommand(this);
                }
                    return send;
            } private set { }
        }

        public void Sending()
        {
            _aggregator.GetEvent<DataMessagePostedEvent>().Publish(messageObj);
        }
    }
}
