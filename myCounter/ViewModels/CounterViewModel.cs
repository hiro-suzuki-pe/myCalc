using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using myCounter.Models;

namespace myCounter.ViewModels
{
    public class CounterViewModel
    {
        public event PropertyChangedEventHandler propertyChanged;

        public Counter counter { get; set; }
        public CountDownCommand countDownCommand { get; private set; }

        public CounterViewModel()
        {
            countDownCommand = new CountDownCommand(this);
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

                if (propertyChanged != null)
                {
                    propertyChanged(this, new PropertyChangedEventArgs("Value"));
                }
            }
        }
    }
}
