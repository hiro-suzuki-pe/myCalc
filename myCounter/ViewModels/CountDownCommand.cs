using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace myCounter.ViewModels
{
    public class CountDownCommand: ICommand
    {
        private CounterViewModel _view { get; set; }

        public CountDownCommand(CounterViewModel view)
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
            _view.Value = (_view.Value <= 0) ? 100 : _view.Value - 1;
        }
    }
}
