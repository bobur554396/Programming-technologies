using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormIntro
{
    class Calc
    {
        public double first;
        public double second;
        private double result;
        public string operation;

        public void Calculate(){
            switch (operation) { 
                case "+":
                    result = first + second;
                    break;
                case "-":
                    result = first - second;
                    break;
                case "*":
                    break;
                case "/":
                    break;
                default:
                    break;
            }
        }
        public double Result {
            get { return result; }
            set { result = value; }
        }
    }
}
