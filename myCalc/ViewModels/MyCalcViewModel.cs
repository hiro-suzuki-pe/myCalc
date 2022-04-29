using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using myCalc.Models;

namespace myCalc.ViewModels 
{ 
    public class MyCalcViewModel : INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Calculator Calculator { get; set; }

        public keyInCommand keyInCommand { get; private set; }

        public MyCalcViewModel()
        {
            keyInCommand = new KeyInCommand(this);
            Calculator = new Calculator();
        }

        public String calcResult
        {
            get
            {
                return my
            }
        }
    }
}
