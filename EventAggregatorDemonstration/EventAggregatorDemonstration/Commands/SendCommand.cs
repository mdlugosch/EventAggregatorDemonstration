using EventAggregatorDemonstration.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EventAggregatorDemonstration.Commands
{
    class SendCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Object view;

        public SendCommand(Object obj)
        {
            view = obj;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ((MainViewModel)view).Sending();
        }
    }
}
