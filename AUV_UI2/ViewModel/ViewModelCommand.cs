using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AquaDesk.ViewModel
{
    public class ViewModelCommand: ICommand
    {
        private readonly Action<object> _executeAction;
        private readonly Predicate<object>? _canexecuteAction;


        public ViewModelCommand(Action<object> executeAction)
        {
            _executeAction = executeAction;
            _canexecuteAction = null;
        }
        public ViewModelCommand(Action<object> executeAction, Predicate<object> canexecuteAction)
        {
            _executeAction = executeAction;
            _canexecuteAction = canexecuteAction;
        }

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return _canexecuteAction == null || _canexecuteAction(parameter!);
        }

        public void Execute(object? parameter)
        {
            _executeAction(parameter!);
        }


    }
}
