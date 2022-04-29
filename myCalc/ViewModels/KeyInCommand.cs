using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace myCalc.ViewModels
{
    class KeyInCommand: ICommand
    {
        private MyCalcViewModel _view { get; set; }
        public KeyInCommand(MyCalcViewModel view)
        {
            _view = view;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value;  }
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            _view.calcResult += parameter;
        }
    }


}
