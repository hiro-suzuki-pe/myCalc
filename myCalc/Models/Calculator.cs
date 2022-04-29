using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCalc.Models
{
    class Calculator
    {
        public string Result { get; set; } = "";

        public Calculator() 
        {
        }

        public int add(int a, int b)
        {
            return a + b;
        }
    }
}
