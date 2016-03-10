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
        public double result;

        public void Calculate(string s){
            switch (s) { 
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
