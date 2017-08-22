using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.PubSubEvents;

namespace MainEventManager
{
    public class AggregatorList
    {
        public static IEventAggregator _aggregator;
        private AggregatorList() { }       

        public static IEventAggregator AggregatorFactory
        {
            get
            {
                if (_aggregator == null)
                {
                    _aggregator = new EventAggregator();
                }
                return _aggregator;
            }
        }
    }
}
