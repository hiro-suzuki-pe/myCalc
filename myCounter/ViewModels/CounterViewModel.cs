using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using myCounter.Models;

namespace myCounter.ViewModels
{
    public class CounterViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Counter counter { get; set; }
        public CountDownCommand countDownCommand { get; private set; }
        public CountUpCommand countUpCommand { get; private set; }

        public CounterViewModel()
        {
            countDownCommand = new CountDownCommand(this);
            countUpCommand = new CountUpCommand(this);
            counter = new Counter();
        }

        public int Value
        {
            get
            {
                return counter.Value;
            }
            set
            {
                counter.Value = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Value"));
                }
            }
        }
    }
}
