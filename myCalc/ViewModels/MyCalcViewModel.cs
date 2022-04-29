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
        public Calculator calculator { get; set; }

        public KeyInCommand keyInCommand { get; private set; }

        public MyCalcViewModel()
        {
            keyInCommand = new KeyInCommand(this);
            calculator = new Calculator();
        }

        public String CalcResult
        {
            get
            {
                return calculator.CalcResult;
            }
            set
            {
                calculator.CalcResult = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("CalcResult"));
                }
            }
        }
    }
}
