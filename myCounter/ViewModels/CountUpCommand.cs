using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace myCounter.ViewModels
{
    public class CountUpCommand: ICommand
    {
        private CounterViewModel _view { get; set; }

        public CountUpCommand(CounterViewModel view)
        {
            _view = view;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; } 
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _view.Value = (_view.Value >= 100) ? 0 : _view.Value + 1;
        }
    }
}
